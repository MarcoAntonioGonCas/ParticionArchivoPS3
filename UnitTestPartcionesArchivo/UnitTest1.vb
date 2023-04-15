Imports System.IO
Imports System.Text
Imports _002_particionesArchivo
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class UnitTest1

    <TestMethod()> Public Sub TestMethod1()

        Dim format As New FilePathFormat()


        Dim info As New FileInfo("D:\\archivo.txt")

        Assert.AreEqual(info.FullName + ".0.part", format.ObtenerNombreNumeroDeParte(info, 0, TipoParticion.archivoNumPart))
    End Sub
End Class