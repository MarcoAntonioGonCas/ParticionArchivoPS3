Imports System.IO

Public Module FileAux
    Private fileFormat As New FilePathFormat()

    Public Function ExisteArchivoOriginal(primeraParte As FileInfo) As Boolean
        Return File.Exists(fileFormat.DevuelvePathSinNumeroParte(primeraParte))

    End Function


    Public Function SumaBytesArchivos(ParamArray archivos As FileInfo()) As Long
        Dim tamanio As Long = 0L

        For Each a In archivos
            tamanio += a.Length
        Next

        Return tamanio
    End Function


End Module
