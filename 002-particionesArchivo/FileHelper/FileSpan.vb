Imports System.IO

Public Class EstadoOperacionArgs
    Inherits EventArgs

    Public Property TotalBytes As Long
    Public Property ByteActual As Long
End Class
Public Class FileSpan

    Public Event EstadoOperacionSpanFile(ByVal sender As Object, ByVal e As EstadoOperacionArgs)


    Private Function ByteAleatorio() As Byte

        'Dim b As Byte
        'b = CType(rdn.Next(0, 255), Byte)
        Return 255
    End Function

    Public Async Function CrearArchivoSpan(numBytes As Double, path As String) As Task(Of Boolean)
        Try

            Using fs As New FileStream(path, FileMode.CreateNew)
                For i = 1 To numBytes

                    fs.WriteByte(ByteAleatorio())

                    RaiseEvent EstadoOperacionSpanFile(Me, New EstadoOperacionArgs With {.ByteActual = i, .TotalBytes = numBytes})
                Next i
            End Using


        Catch ex As Exception
            MyClass._mensaje = ex.Message
            Return False
        End Try
        Return True
    End Function


#Region "Propiedades"


    Private Property rdn As New Random()
    Private Property _mensaje As String

    Public ReadOnly Property Mensaje As String
        Get
            Return _mensaje
        End Get
    End Property
#End Region

End Class
