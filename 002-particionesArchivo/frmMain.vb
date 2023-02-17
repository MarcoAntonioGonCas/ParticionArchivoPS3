Imports System.Globalization
Imports System.Text.RegularExpressions
Imports ControlStatus

Public Class frmMain


    Private borderButtons As BorderControlStatusClick

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        borderButtons = New BorderControlStatusClick(Panel1, 3)
        borderButtons.BordeAutomatico = False
        borderButtons.ColorBorde = ControlPaint.Dark(Color.Green)
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
        Dim frm As New frmFileSplit()
        Me.Visible = False
        frm.ShowDialog()
        Me.Visible = True
    End Sub

    Private Sub btnunir_Click(sender As Object, e As EventArgs) Handles btnunir.Click, UnirArchivoToolStripMenuItem.Click
        Dim frm As New frmFileMarge()
        Me.Visible = False
        frm.ShowDialog()
        Me.Visible = True
    End Sub
#End Region
End Class
