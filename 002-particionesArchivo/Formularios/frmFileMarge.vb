Imports System.IO

Public Class frmFileMarge
    Private WithEvents _fileMarge As New FileMarge()
    Private _fileHelper As New FilePathFormat()

    Private Sub LlenarLista(path As String)
        Dim infoDirectorio As New DirectoryInfo(path)

        Dim archivosDivididos = _fileMarge.ObtieneArchivosParticionados(infoDirectorio)

        Dim archivosDivididosCheckbox = archivosDivididos.Select(Of FileMargeInfoCheckBox)(Function(file)
                                                                                               Return New FileMargeInfoCheckBox(_fileHelper.DevuelvePathSinNumeroParte(file), file)
                                                                                           End Function).ToArray()
        'For Each infoDividido As FileInfo In archivosDivididos

        '    CheckedListBoxDivi.Items.Add()
        'Next
        CheckedListBoxDivi.ClearSelected()
        CheckedListBoxDivi.Items.Clear()
        CheckedListBoxDivi.Items.AddRange(archivosDivididosCheckbox)




    End Sub

    Private Sub btnSelecCarpeta_Click(sender As Object, e As EventArgs) Handles btnSelecCarpeta.Click
        Dim folder As New FolderBrowserDialog()

        If folder.ShowDialog() = DialogResult.OK Then


            LlenarLista(folder.SelectedPath)

        End If

    End Sub
    Private Sub EmpezarUniones(infoPrimerasPartes As FileInfo())

        Task.Run(Sub()

                     _fileMarge.MezclarArchivos(infoPrimerasPartes)

                 End Sub)


    End Sub

    Private Sub fileMarge_ProgressChange(sender As Object, e As FileMargeProgressArgs) Handles _fileMarge.Progreso

        prgActual.Value = e.ProgresoParteActual * 100
        prgTotal.Value = e.ProgresoArchivo * 100

        sslblInfoActual.Text = $"Parte {e.ParteDeArchivo} - {e.PartesDeArchivo}"

        stlblInfoTotal.Text = $"Archivo {e.ArchivoActual} - {e.ArchivosEncontrados}"


    End Sub
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click


        If CheckedListBoxDivi.SelectedItems.Count = 0 Then
            Return
        End If

        Dim listaSeleccionados As FileInfo() = CheckedListBoxDivi.SelectedItems.Cast(Of FileMargeInfoCheckBox).Select(Of FileInfo)(Function(f)
                                                                                                                                       Return f.RutaPrimeraParte
                                                                                                                                   End Function).ToArray()
        EmpezarUniones(listaSeleccionados)

    End Sub

    Private Sub EliminarParticionesAlCompletarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarParticionesAlCompletarToolStripMenuItem.Click
        EliminarParticionesAlCompletarToolStripMenuItem.Checked = Not EliminarParticionesAlCompletarToolStripMenuItem.Checked
    End Sub
End Class