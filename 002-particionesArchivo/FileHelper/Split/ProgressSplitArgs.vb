Public Class FileSplitProgressArgs
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