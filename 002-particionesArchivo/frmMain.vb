Imports System.Globalization
Imports System.Text.RegularExpressions
Imports ControlStatus

Public Class frmMain


    Private borderButtons As BorderControlStatusClick

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        borderButtons = New BorderControlStatusClick(Panel1, 3)
        borderButtons.BordeAutomatico = False
        borderButtons.ColorBorde = Color.DarkCyan

        ToolStripLabel1.Text = $"{Now.ToString("yyyy")} Ma"

    End Sub


    Private Sub OpenForm(Of T As {Form, New})()

        Dim frm As New T()
        frm.StartPosition = FormStartPosition.CenterScreen

        Me.Visible = False
        frm.ShowDialog()
        Me.Visible = True

    End Sub
#Region "Helpers"
    Private Sub ConvertirAColor(hex As String)

        Dim regex As New Regex("^#?[0-9A-Fa-f]{6}$")
        Dim colores = Convert.ToInt64(hex, 16)
        Dim r, g, b

        r = colores >> 0 And &HFF
        g = colores >> 8 And &HFF
        b = colores >> 16 And &HFF


        b = colores And &HFF
        g = colores And &HFFFF >> 8
        r = colores And &HFFFFFF >> 16


        Dim unido = b Or g << 8 Or r << 16

    End Sub

    Private Sub btndividir_Click(sender As Object, e As EventArgs) Handles btndividir.Click, DividirToolStripMenuItem.Click
        OpenForm(Of frmFileSplit)()
    End Sub

    Private Sub btnunir_Click(sender As Object, e As EventArgs) Handles btnunir.Click, UnirArchivoToolStripMenuItem.Click
        OpenForm(Of frmFileMarge)()
    End Sub

    Private Sub CrearArchivoAleatorioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearArchivoAleatorioToolStripMenuItem.Click
        OpenForm(Of frmFileSpam)()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
#End Region
End Class
