
Imports System.IO

Public Class frmFileSpam

    Private ruta As String
    Private rdn As New Random()
    '97 - 122
    Private WithEvents fileSpam As New FileSpam()

    Private Function ObtieneNumeroBytes() As Long
        Try
            Return Long.Parse(txtNumBytes.Text)
        Catch ex As Exception
            Return 0L
        End Try
    End Function
    Private Function GenName(Optional len As Integer = 10)


        Dim name = ""

        For i = 1 To len

            name += Strings.Chr(rdn.Next(97, 122))
        Next

        Return name
    End Function
    Private Sub btnSeleccionaRuta_Click(sender As Object, e As EventArgs) Handles btnSeleccionaRuta.Click, SeleccionarToolStripMenuItem.Click

        OpenFileDialog1.Filter = "Totos los archios(*.*)|*.*"
        OpenFileDialog1.FileName = GenName() & "" & ".spam"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then

            ruta = OpenFileDialog1.FileName
            lblRuta.Text = ruta
            lblNombre.Text = Path.GetFileName(OpenFileDialog1.FileName)

        End If

    End Sub
    Private Function ValidarCampos() As Boolean

        ErrorProvider1.Clear()
        Dim band = True

        If ruta = "" Then
            ErrorProvider1.SetError(btnSeleccionaRuta, "Selecciona una ruta")
            band = False
        End If

        Return band

    End Function
    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        If Not ValidarCampos() Then
            Return
        End If
        Dim numBytes = ObtieneNumeroBytes()

        RichTextBox1.Clear()
        RichTextBox1.AppendText("Iniciando...")

        If ValidarInicio() Then

            Task.Run(Sub()
                         Iniciar(numBytes)
                     End Sub
                )

        End If

    End Sub

    Private Sub AbrirCarpeta(ruta As String)

        Try
            Process.Start(Path.GetDirectoryName(ruta))
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Iniciar(cantidadBytes As Long)
        fileSpam.CrearArchivoSpan(cantidadBytes, ruta)
    End Sub

    Private Function ValidarInicio()

        If (ExisteArchivo(ruta)) Then
            If MostrarMensajeRemplazo(Path.GetFileName(ruta)) Then
                RichTextBox1.AppendText(vbNewLine + "Se remplazara el archivo...")
            Else
                RichTextBox1.AppendText(vbNewLine + "Cancelando..")
                Return False
            End If
        End If

        If ObtieneNumeroBytes() <= 0 Then

            RichTextBox1.AppendText(vbNewLine + "No se indico el numero de bytes se creara un archivo de 0 bytes...")
        End If

        Return True
    End Function
    Private Function MostrarMensajeRemplazo(nombreArchivo) As Boolean
        Return MessageBox.Show($"El archivo {Path.GetFileName(nombreArchivo)} deseas remplazarlo", "Remplazar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes

    End Function
    Private Function ExisteArchivo(ruta As String) As Boolean

        Try
            Return File.Exists(ruta)
        Catch ex As Exception
            RichTextBox1.AppendText(ex.Message)
            Return False
        End Try
    End Function

    Private Sub progreso(sender As Object, e As FileSpamProgressArgs) Handles fileSpam.Progreso
        pgr.Value = e.Progreso * 100

    End Sub
    Private Sub progreso_completado(sender As Object, e As EventArgs) Handles fileSpam.ProgresoCompletado
        RichTextBox1.AppendText(vbNewLine + "........Completado...........")


        AbrirCarpeta(ruta)
    End Sub

    Private Sub txtNumBytes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumBytes.KeyPress

        If Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub



    Private Sub txtNumBytes_Leave(sender As Object, e As EventArgs) Handles txtNumBytes.Leave
        If txtNumBytes.Text = "" Then
            txtNumBytes.Text = "0"
        End If
    End Sub
End Class