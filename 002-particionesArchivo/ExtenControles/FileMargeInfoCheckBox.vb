
Imports System.IO

Public Class FileMargeInfoCheckBox


    Property NombrePartesCombinadas As String
    Property RutaPrimeraParte As FileInfo


    Public Sub New(nombreUnido As String, archivoPrimerParte As FileInfo)
        Me.NombrePartesCombinadas = nombreUnido
        Me.RutaPrimeraParte = archivoPrimerParte
    End Sub

    Public Overrides Function ToString() As String
        Return NombrePartesCombinadas
    End Function
End Class