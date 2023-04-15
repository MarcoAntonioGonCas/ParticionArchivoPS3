Imports System.IO

Public Class FileSplitInfoCheckBox
    Property Ruta As FileInfo


    Public Sub New(ruta As FileInfo)
        Me.Ruta = ruta
    End Sub

    Public Function ToGb(bytes As Long) As Single

        Dim gb As Single = ((bytes / 1024) / 1024) / 1024


        Return gb
    End Function
    Public Overrides Function ToString() As String
        Return $"{ToGb(Ruta.Length)}GB -> {Ruta.FullName}"
    End Function

End Class
