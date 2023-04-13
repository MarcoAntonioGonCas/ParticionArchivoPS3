Public Class FileMargeProgressArgs
    Inherits EventArgs
    Public Property ArchivosEncontrados As Integer
    Public Property ArchivoActual As Integer
    Public Property ParteDeArchivo As Integer
    Public Property PartesDeArchivo As Integer

    Public Property ProgresoArchivo As Decimal
    Public Property ProgresoArchivos As Decimal
    Public Property ProgresoParteActual As Decimal
End Class
