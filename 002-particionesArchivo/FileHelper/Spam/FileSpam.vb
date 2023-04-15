Imports System.IO

Public Class FileSpam


    Private bloque(FileSplit.tamanioBloque - 1) As Byte

    Public Sub New()
        For i = 1 To FileSplit.tamanioBloque
            bloque(i - 1) = &B11111111
        Next
    End Sub

    Public Event Progreso(ByVal sender As Object, ByVal e As FileSpamProgressArgs)
    Public Event ProgresoCompletado(ByVal sender As Object, e As EventArgs)

    Private Function ByteAleatorio() As Byte

        Dim b As Byte
        b = CType(rdn.Next(0, 255), Byte)
        Return b
    End Function

    Public Function CrearArchivoSpan(numBytes As Long, path As String) As Boolean


        Dim bytesEscritos As Long = 0
        Dim bytesRestantes As Long = numBytes Mod FileSplit.tamanioBloque
        Dim bytesAEscribir = FileSplit.tamanioBloque
        Dim vueltas As Long = CType(Math.Ceiling(numBytes / CType(FileSplit.tamanioBloque, Double)), Long)
        Try


            For i As Long = 1 To vueltas
                Using fs As New FileStream(path, IIf(i = 1, FileMode.Create, FileMode.Append))


                    If bytesRestantes <> 0 AndAlso i = vueltas Then
                        bytesAEscribir = bytesRestantes
                    End If

                    bytesEscritos += bytesAEscribir
                    fs.Write(bloque, 0, bytesAEscribir)

                    RaiseEvent Progreso(Me, New FileSpamProgressArgs With {.ByteActual = bytesEscritos, .TotalBytes = numBytes, .Progreso = bytesEscritos / numBytes})
                End Using
            Next

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
