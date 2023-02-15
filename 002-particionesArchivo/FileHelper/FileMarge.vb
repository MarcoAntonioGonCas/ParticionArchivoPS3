Imports System.Diagnostics.Tracing
Imports System.IO
Imports System.Text.RegularExpressions

Public Class FileMargeProgressArgs
    Inherits EventArgs


    Public Property ArchivosEncontrados As Integer
    Public Property ArchivoActual As Integer
    Public Property ParteDeArchivo As Integer
    Public Property PartesDeArchivo As Integer

    Public Property ProgresoArchivo As Decimal
    Public Property ProgresoArchivos As Decimal
    Public Property ProgresoParteActual As Decimal
End Class

Public Class FileMarge
    Private _archivosAMezclar As Integer
    Private _archivoActual As Integer
    Private _tamanioBloque As Long = 16777216
    Private _fileFormat As New FilePathFormat()

    Public Event Progreso(ByVal sender As Object, args As FileMargeProgressArgs)
    Public Event Completado(ByVal sender As Object, args As EventArgs)
    Public Sub New()

        _archivoActual = 0
        _archivosAMezclar = 0

    End Sub
    Private Sub ReiniciarContadores()
        _archivoActual = 0
        _archivosAMezclar = 0
    End Sub

    Public Function Mezclar(archivoPrimeraParte As FileInfo) As Boolean

        If ExisteArchivoOriginal(archivoPrimeraParte) Then
            Return True
        End If

        Try
            Dim nombreArchivoUnido = Me._fileFormat.DevuelveNombreSinParte(archivoPrimeraParte)
            Dim rutaArchivoNuevo = Path.Combine(archivoPrimeraParte.DirectoryName, nombreArchivoUnido)


            Dim partesDeArchivo As FileInfo() = _fileFormat.ObtenerPartesDeArchivo(archivoPrimeraParte)
            Dim lenPartesDeArchivo As Integer = partesDeArchivo.Length

            Dim tamanioPartesUnidas As Long = TamanioBytes(partesDeArchivo)
            Dim contadorPastesUnidas As Long = 0


            Using fsArchivo As New FileStream(rutaArchivoNuevo, FileMode.Create)

                Dim bytesTotalesParte As Long = 0
                Dim contadorParte As Long = 0
                Dim parteActual As FileInfo
                Dim buffer(_tamanioBloque - 1) As Byte
                Dim leidos As Integer

                For i = 0 To partesDeArchivo.Length - 1

                    parteActual = partesDeArchivo(i)
                    bytesTotalesParte = parteActual.Length
                    contadorParte = 0
                    Using fsParte As New FileStream(parteActual.FullName, FileMode.Open)


                        Do Until contadorParte = bytesTotalesParte


                            leidos = fsParte.Read(buffer, 0, _tamanioBloque)
                            fsArchivo.Write(buffer, 0, leidos)
                            contadorParte += leidos
                            contadorPastesUnidas += leidos

                            RaiseEvent Progreso(Me, New FileMargeProgressArgs() With
                            {
                            .ArchivoActual = _archivoActual,
                            .ArchivosEncontrados = _archivosAMezclar,
                            .ParteDeArchivo = i + 1,
                            .PartesDeArchivo = lenPartesDeArchivo,
                            .ProgresoParteActual = contadorParte / parteActual.Length,
                            .ProgresoArchivo = contadorPastesUnidas / tamanioPartesUnidas,
                            .ProgresoArchivos = _archivoActual / _archivosAMezclar
                            })
                            '.ProgresoParteActual = contadorParte / parteActual.Length,
                        Loop

                    End Using


                Next i


            End Using


        Catch ex As Exception
            MessageBox.Show($"{ex.Message} {ex.StackTrace}")
            Return False
        End Try
        Return True

    End Function

    Public Sub MezclarArchivos(ParamArray archivos As FileInfo())
        ReiniciarContadores()
        _archivosAMezclar = archivos.Length




        For i = 0 To archivos.Length - 1

            Me._archivoActual = i + 1
            Mezclar(archivos(i))
        Next
        RaiseEvent Completado(Me, New EventArgs())


    End Sub
    Public Function ExisteArchivoOriginal(primeraParte As FileInfo) As Boolean

        Dim directorioActual As DirectoryInfo = primeraParte.Directory
        Dim nombre As String = primeraParte.Name

        nombre = _fileFormat.DevuelveNombreSinParte(primeraParte)


        Return File.Exists(Path.Combine(directorioActual.FullName, nombre))
    End Function

    Private Function TamanioBytes(ParamArray archivos As FileInfo()) As Long
        Dim tamanio As Long = 0L

        For Each a In archivos
            tamanio += a.Length
        Next

        Return tamanio
    End Function
    Public Function ObtieneArchivosParticionados(directorio As DirectoryInfo, Optional opcionesBusqueda As SearchOption = SearchOption.AllDirectories) As FileInfo()


        Dim archivosParticionados As New List(Of FileInfo)


        archivosParticionados.AddRange(
            directorio.EnumerateFiles($"*.{66600}", opcionesBusqueda)
        )


        archivosParticionados.AddRange(
            directorio.EnumerateFiles($"*.part.00", opcionesBusqueda)
        )

        archivosParticionados.AddRange(
            directorio.EnumerateFiles($"*.00", opcionesBusqueda)
        )
        Return archivosParticionados.ToArray()
    End Function
End Class
