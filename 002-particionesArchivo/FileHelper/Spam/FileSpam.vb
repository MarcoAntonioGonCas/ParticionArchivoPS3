Imports System.IO

Public Class FileSpam

    Public Event Progreso(ByVal sender As Object, ByVal e As FileSpamProgressArgs)
    Public Event ProgresoCompletado(ByVal sender As Object, e As EventArgs)

    Private Function ByteAleatorio() As Byte

        Dim b As Byte
        b = CType(rdn.Next(0, 255), Byte)
        Return b
    End Function

    Public Function CrearArchivoSpan(numBytes As Double, path As String) As Boolean
        Try

            Using fs As New FileStream(path, FileMode.Create)
                For i = 1 To numBytes

                    fs.WriteByte(ByteAleatorio())

                    RaiseEvent Progreso(Me, New FileSpamProgressArgs With {.ByteActual = i, .TotalBytes = numBytes, .Progreso = i / numBytes})
                Next i
            End Using

            RaiseEvent ProgresoCompletado(Me, New EventArgs())
        Catch ex As Exception
            MessageBox.Show(ex.Message + "111")
            MyClass._mensaje = ex.Message
            Return False
        End Try
        Return True
    End Function


#Region "Propiedades"


    Private rdn As New Random()
    Private Property _mensaje As String

    Public ReadOnly Property Mensaje As String
        Get
            Return _mensaje
        End Get
    End Property
#End Region

End Class
