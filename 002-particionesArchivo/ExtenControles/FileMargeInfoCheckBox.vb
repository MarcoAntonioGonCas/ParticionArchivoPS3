
Imports System.IO

Public Class FileMargeInfoCheckBox


    Property NombrePartesUnidas As String
    Property RutaPrimeraParte As FileInfo


    Public Sub New(nombreUnido As String, archivoPrimerParte As FileInfo)
        Me.NombrePartesUnidas = nombreUnido
        Me.RutaPrimeraParte = archivoPrimerParte
    End Sub

    Public Overrides Function ToString() As String
        Return NombrePartesUnidas
    End Function
End Class