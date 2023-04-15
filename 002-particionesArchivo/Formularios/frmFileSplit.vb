Imports System.ComponentModel
Imports System.IO
Imports System.Threading

Public Class frmFileSplit
    Dim ruta As String = ""
    Dim enProgreso As Boolean = False

    Private WithEvents fileSplit As New FileSplit

    Private Sub frmFileSplit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub btnSeleccionaRuta_Click(sender As Object, e As EventArgs) Handles btnSeleccionaRuta.Click


        If FolderBrowserDialog1.ShowDialog() <> DialogResult.OK Then
            Return
        End If


        Dim lst As New List(Of FileSplitInfoCheckBox)()

        Dim archivosPesados() As FileInfo = Me.fileSplit.EscanearArchivosPesados(FolderBrowserDialog1.SelectedPath, IIf(BuscarRecursivamenteToolStripMenuItem.Checked, SearchOption.AllDirectories, SearchOption.TopDirectoryOnly))

        If archivosPesados Is Nothing Then
            Return
        End If

        ruta = FolderBrowserDialog1.SelectedPath
        lblRuta.Text = ruta
        lblEncontrados.Text = archivosPesados.Length.ToString()


        For Each archivo In archivosPesados
            lst.Add(New FileSplitInfoCheckBox(archivo))
        Next



        CheckedListBoxDivi.DataSource = lst


    End Sub


    Private Function ObtieneTipoParticion() As TipoParticion
        If ComboBox1.SelectedIndex = 0 Then
            Return TipoParticion.archivo666Num
        ElseIf ComboBox1.SelectedIndex = 1 Then
            Return TipoParticion.archivoNumPart

        ElseIf ComboBox1.SelectedIndex = 2 Then

            Return TipoParticion.archivoPuntoNum
        Else
            Return TipoParticion.archivo666Num
        End If



    End Function
    Public Sub ErrorSpli(obj As Object, e As FileSplitErrorArgs) Handles fileSplit.ErrorSplit
        MessageBox.Show(e.Mensaje)
        enProgreso = False
    End Sub



    Private Sub Reset()

        ruta = ""
        lblRuta.Text = ""
        lblEncontrados.Text = ""
        CheckedListBoxDivi.DataSource = Nothing

    End Sub


    Private Function ValidarCampos() As Boolean
        Dim band = True


        If ruta = "" Then
            ErrorProvider1.SetError(btnSeleccionaRuta, "Selecciona una ruta")
            band = False
        End If

        If ruta <> "" And CheckedListBoxDivi.CheckedItems.Count = 0 Then
            band = False
            MessageBox.Show("No existen o no selecciono un archivo para dividirlo")
        End If






        Return band
    End Function
    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        If enProgreso Then
            MessageBox.Show("Operacion en progreso")
        End If

        If Not ValidarCampos() Then
            Return
        End If

        BackgroundWorker1.RunWorkerAsync()



    End Sub


#Region "Progreso"

    Private Sub progreso(sender As Object, e As FileSplitProgressArgs) Handles fileSplit.ProgresoSplit
        pgr.Value = e.Progreso * 100
    End Sub
    Private Sub completado(sender As Object, e As EventArgs) Handles fileSplit.ProgresoCompletado
        MessageBox.Show("Completado")
        enProgreso = False
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim lstSeleccionados = CheckedListBoxDivi.CheckedItems.Cast(Of FileSplitInfoCheckBox)
        Dim archivos() As FileInfo = lstSeleccionados.Select(Function(f)
                                                                 Return f.Ruta
                                                             End Function).ToArray()

        fileSplit.CambiarTipoParticion(ObtieneTipoParticion())
        fileSplit.DividirArchivo(archivos)
        enProgreso = True


    End Sub
#End Region
End Class