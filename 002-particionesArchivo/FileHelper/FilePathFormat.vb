Imports System.IO
Imports System.Runtime.InteropServices.WindowsRuntime
Imports System.Text.RegularExpressions

Public Class FilePathFormat
    Private regexNumPart As New Regex("[.]\d+[.](part|PART)$")
    Private regex666part As New Regex("[.]6{2,}\d+$")
    Private regexPuntoPart As New Regex("[.]\d+$")

    Private tipoFormato As TipoParticion
    Public Function DevuelveSoloNombreSinParte(archivoPrimeraParte As FileInfo) As String
        Return Path.GetFileName(DevuelvePathSinNumeroParte(archivoPrimeraParte))
    End Function
    Public Function DevuelvePathSinNumeroParte(archivoPrimeraParte As FileInfo) As String

        Dim tipo = ObtenerTipoParticion(archivoPrimeraParte)

        Dim nombre As String = ""

        Select Case tipo
            Case TipoParticion.archivoNumPart

                nombre = regexNumPart.Replace(archivoPrimeraParte.FullName, "")

            Case TipoParticion.archivo666Num

                nombre = regex666part.Replace(archivoPrimeraParte.FullName, "")

            Case TipoParticion.archivoPuntoNum

                nombre = regexPuntoPart.Replace(archivoPrimeraParte.FullName, "")

        End Select


        Return nombre
    End Function
    Private Function ObtenerNumeroParte666(archivo As FileInfo, numeroParte As Integer)

        Return $"{archivo.FullName}.{66600 + numeroParte}"

    End Function
    Public Function ObtenerTipoParticion(archivo As FileInfo) As TipoParticion

        Dim tipo As TipoParticion


        If regexNumPart.IsMatch(archivo.FullName) Then

            tipo = TipoParticion.archivoNumPart

        ElseIf regex666part.IsMatch(archivo.FullName) Then

            tipo = TipoParticion.archivo666Num

        ElseIf regexPuntoPart.IsMatch(archivo.FullName) Then

            tipo = TipoParticion.archivoPuntoNum

        End If

        Return tipo

    End Function

    Public Function ObtenerNumeroDeParte(archivo As FileInfo, numeroParte As Integer, tipoParticion As TipoParticion, Optional padding As Integer = 0) As String
        Dim nombre As String = archivo.FullName

        If tipoParticion = TipoParticion.archivoNumPart Then
            nombre = $"{nombre}.{numeroParte.ToString().PadLeft(padding)}.part"
        ElseIf tipoParticion = TipoParticion.archivoPuntoNum Then
            nombre = $"{nombre}.{numeroParte.ToString().PadLeft(padding)}"
        ElseIf tipoFormato = TipoParticion.archivo666Num Then

            nombre = ObtenerNumeroParte666(archivo, numeroParte)
        End If




        Return nombre

    End Function
    Public Function ObtenerPartesDeArchivo(archivoPrimeraParte As FileInfo) As FileInfo()

        Dim tipo As TipoParticion = ObtenerTipoParticion(archivoPrimeraParte)
        Dim directorio As DirectoryInfo = archivoPrimeraParte.Directory
        Dim nombreSinParte As String = DevuelveSoloNombreSinParte(archivoPrimeraParte)
        Dim partesArchivo() As FileInfo


        Select Case tipo
            Case TipoParticion.archivo666Num
                partesArchivo = directorio.EnumerateFiles($"{nombreSinParte}.666*").ToArray()
            Case TipoParticion.archivoPuntoNum
                partesArchivo = directorio.EnumerateFiles($"{nombreSinParte}.*").ToArray()

            Case TipoParticion.archivoNumPart

                partesArchivo = directorio.EnumerateFiles($"{nombreSinParte}.*.part").ToArray()


        End Select

        Return partesArchivo
    End Function

End Class
