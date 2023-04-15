Imports System.Diagnostics.Eventing.Reader
Imports System.IO
Imports System.Security.Cryptography



Public Class FileSplit

    Private Const maximoBytesFAT32 As Long = 4294967296 '4GB
    'Private tamanioBytesParte As Long = 1073741824
    Private Const tamanioBytesParte As Long = 4293918720 '3.99GB
    'Private tamanioBloque As Long = 16777216
    Public Const tamanioBloque As Long = 16773120
    '   16Mb
    '    Private 4,193,280
    '8,388,608

    Private ReadOnly fileFormat As New FilePathFormat()

    Private archivosAdividir As Integer
    Private archivoActual As Integer

    Private bytesTotalArchivos As Long = 0
    Private contadorBytesArchivos As Long = 0

    Private tipoParticion As TipoParticion = TipoParticion.archivo666Num
    Public IdPartes As Integer = 66600


    Public Sub CambiarTipoParticion(tipoParticion As TipoParticion)


        Me.tipoParticion = tipoParticion

        If tipoParticion = TipoParticion.archivoNumPart OrElse tipoParticion = TipoParticion.archivoPuntoNum Then

            Me.IdPartes = 0
        Else
            Me.IdPartes = 66600
        End If

    End Sub

    Public Event ErrorSplit(ByVal sender As Object, e As FileSplitErrorArgs)
    Public Event ProgresoSplit(ByVal sender As Object, progress As FileSplitProgressArgs)
    Public Event ProgresoCompletado(ByVal sender As Object, e As EventArgs)
    Public ReadOnly Property TamanioBytesSplit As Long
        Get
            Return tamanioBytesParte
        End Get

    End Property

    Public Function EscanearArchivosPesados(path As String, opcionesBsuqeuda As SearchOption) As FileInfo()

        Try
            Dim lstArchivosPesados As New List(Of FileInfo)


            Dim directorio As New DirectoryInfo(path)

            Dim archivos = directorio.EnumerateFiles("*.*", opcionesBsuqeuda)


            For Each archivo In archivos

                If archivo.Length > maximoBytesFAT32 Then
                    lstArchivosPesados.Add(archivo)
                End If
            Next

            Return lstArchivosPesados.ToArray()
        Catch ex As Exception

            RaiseEvent ErrorSplit(Me, New FileSplitErrorArgs() With {.Mensaje = ex.Message})
            Return Nothing

        End Try

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
        Me.bytesTotalArchivos = 0
        Me.contadorBytesArchivos = 0
        Me.archivosAdividir = 0
        Me.archivoActual = 0
        For Each a In archivos
            bytesTotalArchivos += a.Length
        Next
    End Sub
    Private Sub InvocarProgreso(i As Integer, partesTotales As Integer, contadorBytesArchivo As Long, archivo As FileInfo, contadorBytesParte As Long, bytesParte As Long)




        'Dim info As New FileSplitProgressArgs With {
        '                .BytesTotales = archivo.Length,
        '                .ByteActual = (tamanioBytesParte * i) + bytesLeidosContador,
        '                .ParteActual = i + 1,
        '                .TotalPartes = partesTotales,
        '                .ProgresoGeneralArchivo = (.ByteActual / .BytesTotales),
        '                .ProgresosParteActual = (bytesLeidosContador / dividirEntre),
        '                .ArchivoActual = Me.archivoActual,
        '                .ArchivosTotales = Me.archivosAdividir,
        '                .ProgresoGeneral = Me.bytesContadorArchivos / Me.bytesArchivosTotales
        '            }
        Dim info As New FileSplitProgressArgs With
            {
            .ParteAchivo = i + 1,
            .PartesTotales = partesTotales,
            .ArchivosTotales = archivosAdividir,
            .ArchivoActual = archivoActual,
            .Progreso = Me.contadorBytesArchivos / Me.bytesTotalArchivos,
            .ProgresoArchivo = contadorBytesArchivo / archivo.Length,
            .ProgresoParte = contadorBytesParte / bytesParte
            }



        RaiseEvent ProgresoSplit(Me, info)
    End Sub


    Private Function DividirArchivo(fsArchivo As FileStream, partesTotales As Integer, archivoSeleccionado As FileInfo)

        ' Se crea un búfer de bytes para almacenar los datos del archivo mientras se divide
        ' El tamaño del bloque 16 MB (16773120 bytes)
        Dim bytesBuffer(tamanioBloque - 1) As Byte

        'Bytes que no completan los 3.99GB
        Dim restante = fsArchivo.Length Mod tamanioBytesParte

        'Contador para mostrar el rogreso actual del archivo
        Dim contadorArchivoBytes As Long = 0

        For i = 0 To partesTotales - 1

            'Nombre de la parte actual
            Dim nombreParteActual = Me.fileFormat.ObtenerNombreNumeroDeParte(archivoSeleccionado, i, Me.tipoParticion)

            'Contador para mostrar e
            Dim contadorBytesLeidosParte As Long = 0
            Dim bytesTotalesParteActual As Long = tamanioBytesParte


            Using fsParteArchivo As New FileStream(nombreParteActual, FileMode.CreateNew)

                Dim bytesLeidosParte As Long = 0

                If (restante <> 0 And i = partesTotales - 1) Then
                    bytesTotalesParteActual = restante
                End If

                Do While contadorBytesLeidosParte < tamanioBytesParte

                    bytesLeidosParte = fsArchivo.Read(bytesBuffer, 0, tamanioBloque)

                    'Aumentamos el contador de bytes para la parte actual del archivo
                    contadorBytesLeidosParte += bytesLeidosParte
                    'Aumentamos el contador de bytes para la parte archivo actual
                    contadorArchivoBytes += bytesLeidosParte

                    'Aumentamos el contador de bytes general
                    Me.contadorBytesArchivos += bytesLeidosParte


                    'Si ya no leimos mas bytes 
                    'Salimos del bucle
                    If bytesLeidosParte = 0 Then

                        Exit Do
                    End If

                    fsParteArchivo.Write(bytesBuffer, 0, bytesLeidosParte)

                    InvocarProgreso(i, partesTotales, contadorArchivoBytes, archivoSeleccionado, contadorArchivoBytes, bytesTotalesParteActual)
                Loop

            End Using

        Next i

        Return True
    End Function

    Private Function DividirArchivoHelper(archivoSeleccionado As FileInfo) As Boolean

        Try
            Dim totalPartes As Integer = Math.Ceiling(archivoSeleccionado.Length / tamanioBytesParte)


            Using fsArchivo As New FileStream(archivoSeleccionado.FullName, FileMode.Open)
                DividirArchivo(fsArchivo, totalPartes, archivoSeleccionado)
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
        Me.contadorBytesArchivos = 0
        Me.bytesTotalArchivos = SumaBytesArchivos(archivos)


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
