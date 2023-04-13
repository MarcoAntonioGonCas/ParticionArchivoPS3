Imports System.Diagnostics.Tracing
Imports System.IO
Imports System.Text.RegularExpressions


Public Class FileMarge

    'Contador de los archivos que se uniran
    Private _archivosAMezclar As Integer
    'Contador del archivo actual
    Private _archivoActual As Integer

    'Tamaño del boque de lectura 16MB
    Private _tamanioBloque As Long = 16777216 '16MB = 16 * 1024 * 1024
    Private _fileFormat As New FilePathFormat()

    'Lista auxiliar la cual indica que partes ya fueron mezcladas
    Private lstPartesMezcladas As New List(Of FileInfo)

    'Evento el cual indica el progreso de la operacion 
    Public Event Progreso(ByVal sender As Object, args As FileMargeProgressArgs)
    'Evento el cual se invoco cual 
    Public Event Completado(ByVal sender As Object, args As EventArgs)



    Public Sub New()

        _archivoActual = 0
        _archivosAMezclar = 0
    End Sub

    'Metodo ayuda a eliminar las partes que se estaban mezclando en caso de algun error
    Public Function BorrarPartesUnidas() As Boolean

        Try
            For Each parte In lstPartesMezcladas
                parte.Delete()
            Next

            lstPartesMezcladas.Clear()

        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    'Reiniciar en caso de nuevas mezclas
    Private Sub Reset()

        lstPartesMezcladas.Clear()
        _archivoActual = 0
        _archivosAMezclar = 0
    End Sub



    Public Sub InvocarProgreso(parteActual As Integer, partes As Integer, bytesParte As Long, bytesTotalesParte As Long, bytesArchivoCombinado As Long, bytesTotalesArchivoCombinado As Long)


        RaiseEvent Progreso(Me, New FileMargeProgressArgs() With
                            {
                            .ArchivoActual = _archivoActual,
                            .ArchivosEncontrados = _archivosAMezclar,
                            .ParteDeArchivo = parteActual,
                            .PartesDeArchivo = partes,
                            .ProgresoParteActual = bytesParte / bytesTotalesParte,
                            .ProgresoArchivo = bytesArchivoCombinado / bytesTotalesArchivoCombinado,
                            .ProgresoArchivos = _archivoActual / _archivosAMezclar
                            })
    End Sub
    'Metodo principal 
    Public Function Mezclar(archivoPrimeraParte As FileInfo) As Boolean

        If ExisteArchivoOriginal(archivoPrimeraParte) Then
            Return True
        End If

        Try

            'Obtiene el nombre original sin el numero de parte
            Dim rutaArchivoNuevo = _fileFormat.DevuelvePathSinNumeroParte(archivoPrimeraParte)

            'Obtiene todas las partes del archivo en un array 
            Dim partesDeArchivo As FileInfo() = _fileFormat.ObtenerPartesDeArchivo(archivoPrimeraParte)

            'Cantidad de las partes del archivo
            Dim len As Integer = partesDeArchivo.Length

            'Bytes de todas las partes ya mezcladas
            Dim tamanioPartesUnidas As Long = TamanioBytes(partesDeArchivo)

            'Contador de bytes de las partes unidas
            Dim contadorPastesUnidas As Long = 0

            Dim buffer(_tamanioBloque - 1) As Byte

            Using fsArchivo As New FileStream(rutaArchivoNuevo, FileMode.Create)

                Dim bytesTotalesParte As Long = 0
                Dim contadorParte As Long = 0
                Dim parteActual As FileInfo
                Dim leidos As Long

                For i = 0 To len - 1

                    parteActual = partesDeArchivo(i)
                    bytesTotalesParte = parteActual.Length
                    contadorParte = 0

                    Using fsParte As New FileStream(parteActual.FullName, FileMode.Open)


                        Do Until contadorParte = bytesTotalesParte


                            leidos = fsParte.Read(buffer, 0, _tamanioBloque)
                            fsArchivo.Write(buffer, 0, leidos)


                            contadorParte += leidos
                            contadorPastesUnidas += leidos
                            InvocarProgreso(i + 1, len, contadorParte, parteActual.Length, contadorPastesUnidas, tamanioPartesUnidas)

                        Loop

                    End Using


                Next i


            End Using
            lstPartesMezcladas.AddRange(partesDeArchivo)
        Catch ex As Exception

            MessageBox.Show($"{ex.Message} {ex.StackTrace}")

            Return False
        End Try

        Return True
    End Function

    Public Sub MezclarArchivos(ParamArray archivos As FileInfo())

        Reset()

        _archivosAMezclar = archivos.Length

        For i = 0 To archivos.Length - 1

            Me._archivoActual = i + 1

            Mezclar(archivos(i))

        Next


        RaiseEvent Completado(Me, New EventArgs())

    End Sub
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
