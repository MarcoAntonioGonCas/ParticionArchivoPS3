<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFileSpam
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Panel1 As System.Windows.Forms.Panel
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.btnSeleccionaRuta = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeleccionarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.pgr = New System.Windows.Forms.ProgressBar()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.lblRuta = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.lblNombre = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtNumBytes = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Process1 = New System.Diagnostics.Process()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Panel1 = New System.Windows.Forms.Panel()
        Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Panel1.Controls.Add(Me.btnIniciar)
        Panel1.Controls.Add(Me.btnSeleccionaRuta)
        Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Panel1.Location = New System.Drawing.Point(0, 198)
        Panel1.Name = "Panel1"
        Panel1.Size = New System.Drawing.Size(724, 29)
        Panel1.TabIndex = 2
        '
        'btnIniciar
        '
        Me.btnIniciar.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnIniciar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnIniciar.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIniciar.Location = New System.Drawing.Point(156, 0)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(128, 29)
        Me.btnIniciar.TabIndex = 1
        Me.btnIniciar.Text = "Iniciar"
        Me.btnIniciar.UseVisualStyleBackColor = False
        '
        'btnSeleccionaRuta
        '
        Me.btnSeleccionaRuta.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSeleccionaRuta.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSeleccionaRuta.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnSeleccionaRuta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnSeleccionaRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSeleccionaRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionaRuta.Location = New System.Drawing.Point(0, 0)
        Me.btnSeleccionaRuta.Name = "btnSeleccionaRuta"
        Me.btnSeleccionaRuta.Size = New System.Drawing.Size(156, 29)
        Me.btnSeleccionaRuta.TabIndex = 0
        Me.btnSeleccionaRuta.Text = "Seleccionar ruta"
        Me.btnSeleccionaRuta.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(724, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SeleccionarToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'SeleccionarToolStripMenuItem
        '
        Me.SeleccionarToolStripMenuItem.Name = "SeleccionarToolStripMenuItem"
        Me.SeleccionarToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.SeleccionarToolStripMenuItem.Text = "Seleccionar"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.CheckFileExists = False
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RichTextBox1)
        Me.Panel2.Controls.Add(Me.pgr)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 56)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(724, 142)
        Me.Panel2.TabIndex = 4
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 0)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(724, 111)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'pgr
        '
        Me.pgr.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pgr.Location = New System.Drawing.Point(0, 111)
        Me.pgr.Name = "pgr"
        Me.pgr.Size = New System.Drawing.Size(724, 31)
        Me.pgr.TabIndex = 0
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(34, 22)
        Me.ToolStripLabel1.Text = "Ruta:"
        '
        'lblRuta
        '
        Me.lblRuta.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblRuta.Name = "lblRuta"
        Me.lblRuta.Size = New System.Drawing.Size(10, 22)
        Me.lblRuta.Text = "."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(54, 22)
        Me.ToolStripLabel2.Text = "Nombre:"
        '
        'lblNombre
        '
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(10, 22)
        Me.lblNombre.Text = "."
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.lblRuta, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.lblNombre})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(724, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "."
        '
        'pnlHeader
        '
        Me.pnlHeader.Controls.Add(Panel1)
        Me.pnlHeader.Controls.Add(Me.Panel2)
        Me.pnlHeader.Controls.Add(Me.Panel3)
        Me.pnlHeader.Controls.Add(Me.ToolStrip1)
        Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHeader.Location = New System.Drawing.Point(0, 24)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(724, 246)
        Me.pnlHeader.TabIndex = 2
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.txtNumBytes)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 25)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(724, 31)
        Me.Panel3.TabIndex = 2
        '
        'txtNumBytes
        '
        Me.txtNumBytes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNumBytes.Location = New System.Drawing.Point(111, 5)
        Me.txtNumBytes.Name = "txtNumBytes"
        Me.txtNumBytes.Size = New System.Drawing.Size(100, 20)
        Me.txtNumBytes.TabIndex = 2
        Me.txtNumBytes.Text = "0"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tamaño en Bytes:"
        '
        'Process1
        '
        Me.Process1.StartInfo.Domain = ""
        Me.Process1.StartInfo.LoadUserProfile = False
        Me.Process1.StartInfo.Password = Nothing
        Me.Process1.StartInfo.StandardErrorEncoding = Nothing
        Me.Process1.StartInfo.StandardOutputEncoding = Nothing
        Me.Process1.StartInfo.UserName = ""
        Me.Process1.SynchronizingObject = Me
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmFileSpam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(724, 308)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmFileSpam"
        Panel1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeleccionarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pgr As ProgressBar
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents lblRuta As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents lblNombre As ToolStripLabel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents btnIniciar As Button
    Friend WithEvents btnSeleccionaRuta As Button
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNumBytes As TextBox
    Friend WithEvents Process1 As Process
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
