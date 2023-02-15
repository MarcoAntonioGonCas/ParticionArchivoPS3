Imports System.Diagnostics.Eventing.Reader
Imports System.IO
Imports System.Security.Cryptography

Public Class ProgressSplitArgs
    Inherits EventArgs

    Public Property Mensaje As String
    Public Property ArchivoActual As Integer
    Public Property ArchivosTotales As Integer
    Public Property TotalPartes As Integer
    Public Property ParteActual As Integer
    Public Property BytesTotales As Long
    Public Property ByteActual As Long
    Public Property ProgresosParteActual As Decimal
    Public Property ProgresoGeneralArchivo As Decimal
    Public Property ProgresoGeneral As Decimal
End Class



Public Class FileSplit
    Public IdPartes As Integer = 66600

    Private Const maximoBytesFAT32 As Long = 4294967296 '4GB
    'Private tamanioBytesParte As Long = 1073741824
    Private tamanioBytesParte As Long = 4293918720 '3.99GB
    'Private tamanioBloque As Long = 16777216
    Private tamanioBloque As Long = 16773120
    '   16Mb
    '    Private 4,193,280
    '8,388,608

    Public archivosAdividir As Integer
    Public archivoActual As Integer

    Private bytesArchivosTotales As Long = 0
    Private bytesContadorArchivos As Long = 0

    Private tipoParticion As TipoParticion = tipoParticion.archivo666Num

    Private fileFormat As New FilePathFormat()

    Public Sub CambiarTipoParticion(tipoParticion As TipoParticion)


        tipoParticion = tipoParticion

        If tipoParticion = tipoParticion.archivoNumPart OrElse tipoParticion = tipoParticion.archivoPuntoNum Then

            Me.IdPartes = 0
        Else
            Me.IdPartes = 66600
        End If

    End Sub
    Public Event ProgresoSplit(ByVal sender As Object, progress As ProgressSplitArgs)
    Public Event ProgresoCompletado(ByVal sender As Object, e As EventArgs)
    Public ReadOnly Property TamanioBytesSplit As Long
        Get
            Return Me.tamanioBytesParte
        End Get

    End Property

    Public Function EscanearArchivosPesados(path As String, opcionesBsuqeuda As SearchOption) As FileInfo()
        Dim lstArchivosPesados As New List(Of FileInfo)


        Dim directorio As New DirectoryInfo(path)

        Dim archivos = directorio.EnumerateFiles("*.*", opcionesBsuqeuda)


        For Each archivo In archivos

            If archivo.Length > maximoBytesFAT32 Then
                lstArchivosPesados.Add(archivo)
            End If
        Next





        Return lstArchivosPesados.ToArray()
    End Function


    Public Function BorrarDivisionesErroneas(archivoSeleccionado As FileInfo) As Boolean
        Try
            Dim nombre As String = archivoSeleccionado.Name
            Dim directorioArchivo As DirectoryInfo = archivoSeleccionado.Directory


            Dim archivosEncontradors = directorioArchivo.EnumerateFiles($"{nombre}.*")


            For Each archivo In archivosEncontradors
                If archivo.Exists Then
                    archivo.Delete()
                End If
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message & ex.StackTrace)
            Return False

        End Try

        Return True
    End Function




    Private Sub ReiniciarContadores(archivos As FileInfo())
        Me.bytesArchivosTotales = 0
        Me.bytesContadorArchivos = 0
        Me.archivosAdividir = 0
        Me.archivoActual = 0
        For Each a In archivos
            bytesArchivosTotales += a.Length
        Next
    End Sub



    Private Function DividirArchivo(fsArchivo As FileStream, partesTotales As Integer, directorio As String, archivoSeleccionado As FileInfo)

        Dim numPart As Integer = IdPartes
        Dim i As Integer = 0

        Dim restante = fsArchivo.Length Mod Me.tamanioBytesParte

        Do While i < partesTotales

            Using fsParteArchivo As New FileStream(Me.fileFormat.ObtenerNumeroDeParte(archivoSeleccionado, i, Me.tipoParticion), FileMode.CreateNew)

                Dim bytesBuffer(Me.tamanioBloque) As Byte
                Dim bytesLeidosContador As Long = 0
                Dim bytesLeidos As Long = 0



                Dim dividirEntre As Long = Me.tamanioBytesParte

                If (restante <> 0 And i = partesTotales - 1) Then
                    dividirEntre = restante
                End If

                Do Until bytesLeidosContador = Me.tamanioBytesParte

                    bytesLeidos = fsArchivo.Read(bytesBuffer, 0, Me.tamanioBloque)
                    bytesLeidosContador += bytesLeidos
                    Me.bytesContadorArchivos += bytesLeidos


                    Dim info As New ProgressSplitArgs With {
                        .BytesTotales = archivoSeleccionado.Length,
                        .ByteActual = (tamanioBytesParte * i) + bytesLeidosContador,
                        .Mensaje = $"{bytesLeidosContador} {bytesLeidos} : {Me.bytesArchivosTotales} {Me.bytesContadorArchivos}",
                        .ParteActual = i + 1,
                        .TotalPartes = partesTotales,
                        .ProgresoGeneralArchivo = (.ByteActual / .BytesTotales),
                        .ProgresosParteActual = (bytesLeidosContador / dividirEntre),
                        .ArchivoActual = Me.archivoActual,
                        .ArchivosTotales = Me.archivosAdividir,
                        .ProgresoGeneral = Me.bytesContadorArchivos / Me.bytesArchivosTotales
                    }


                    RaiseEvent ProgresoSplit(Me, info)




                    If bytesLeidos = 0 Then
                        Exit Do
                    End If

                    fsParteArchivo.Write(bytesBuffer, 0, bytesLeidos)


                    If bytesLeidosContador = Me.tamanioBytesParte Then
                        Exit Do
                    End If
                Loop
            End Using
            i += 1
        Loop

        Return True
    End Function

    Private Function DividirArchivoHelper(archivoSeleccionado As FileInfo) As Boolean

        Try
            Dim totalPartes As Integer = Math.Ceiling(archivoSeleccionado.Length / tamanioBytesParte)


            Dim directorio As String = archivoSeleccionado.FullName

            Using fsArchivo As New FileStream(archivoSeleccionado.FullName, FileMode.Open)
                DividirArchivo(fsArchivo, totalPartes, directorio, archivoSeleccionado)
            End Using


        Catch ex As Exception

            MessageBox.Show($"{ex.StackTrace} {ex.Message}")
            Return False
        End Try

        Return True
    End Function



    Public Function DividirArchivo(ParamArray archivos As FileInfo()) As Boolean
        ReiniciarContadores(archivos)
        Dim band = True
        Me.archivosAdividir = archivos.Length
        Me.archivoActual = 0

        For i = 0 To archivos.Length - 1

            archivoActual = i + 1

            If Not DividirArchivoHelper(archivos(0)) Then
                band = False
                Exit For
            End If
        Next i

        RaiseEvent ProgresoCompletado(Me, New EventArgs())
        Return band

    End Function
End Class
