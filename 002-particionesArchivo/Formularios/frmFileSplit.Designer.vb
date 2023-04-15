<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFileSplit
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
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlHeader = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CheckedListBoxDivi = New System.Windows.Forms.CheckedListBox()
        Me.pgr = New System.Windows.Forms.ProgressBar()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.lblRuta = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.lblEncontrados = New System.Windows.Forms.ToolStripLabel()
        Me.SeleccionarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BuscarRecursivamenteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Panel1 = New System.Windows.Forms.Panel()
        Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlHeader.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Panel1.Controls.Add(Me.btnIniciar)
        Panel1.Controls.Add(Me.btnSeleccionaRuta)
        Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Panel1.Location = New System.Drawing.Point(0, 198)
        Panel1.Name = "Panel1"
        Panel1.Size = New System.Drawing.Size(733, 29)
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
        Me.btnSeleccionaRuta.Text = "Seleccionar carpeta"
        Me.btnSeleccionaRuta.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tipo de division:"
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
        Me.pnlHeader.Size = New System.Drawing.Size(733, 246)
        Me.pnlHeader.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CheckedListBoxDivi)
        Me.Panel2.Controls.Add(Me.pgr)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 56)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(733, 142)
        Me.Panel2.TabIndex = 4
        '
        'CheckedListBoxDivi
        '
        Me.CheckedListBoxDivi.CheckOnClick = True
        Me.CheckedListBoxDivi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckedListBoxDivi.FormattingEnabled = True
        Me.CheckedListBoxDivi.Location = New System.Drawing.Point(0, 0)
        Me.CheckedListBoxDivi.Name = "CheckedListBoxDivi"
        Me.CheckedListBoxDivi.Size = New System.Drawing.Size(733, 111)
        Me.CheckedListBoxDivi.TabIndex = 1
        '
        'pgr
        '
        Me.pgr.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pgr.Location = New System.Drawing.Point(0, 111)
        Me.pgr.Name = "pgr"
        Me.pgr.Size = New System.Drawing.Size(733, 31)
        Me.pgr.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.ComboBox1)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 25)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(733, 31)
        Me.Panel3.TabIndex = 2
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"nombre.66***", "nombre.*.part", "nombre.*"})
        Me.ComboBox1.Location = New System.Drawing.Point(102, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.lblRuta, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.lblEncontrados})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(733, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "."
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
        Me.lblRuta.Size = New System.Drawing.Size(0, 22)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(76, 22)
        Me.ToolStripLabel2.Text = "Encontrados:"
        '
        'lblEncontrados
        '
        Me.lblEncontrados.Name = "lblEncontrados"
        Me.lblEncontrados.Size = New System.Drawing.Size(0, 22)
        '
        'SeleccionarToolStripMenuItem
        '
        Me.SeleccionarToolStripMenuItem.Name = "SeleccionarToolStripMenuItem"
        Me.SeleccionarToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.SeleccionarToolStripMenuItem.Text = "Seleccionar carpeta"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SeleccionarToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(733, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BuscarRecursivamenteToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'BuscarRecursivamenteToolStripMenuItem
        '
        Me.BuscarRecursivamenteToolStripMenuItem.CheckOnClick = True
        Me.BuscarRecursivamenteToolStripMenuItem.Name = "BuscarRecursivamenteToolStripMenuItem"
        Me.BuscarRecursivamenteToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.BuscarRecursivamenteToolStripMenuItem.Text = "Buscar recursivamente"
        '
        'BackgroundWorker1
        '
        '
        'frmFileSplit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 286)
        Me.Controls.Add(Me.pnlHeader)
        Me.Controls.Add(Me.MenuStrip1)
        Me.HelpButton = True
        Me.Name = "frmFileSplit"
        Me.Text = "Dividir archivo"
        Panel1.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents pnlHeader As Panel
    Friend WithEvents btnIniciar As Button
    Friend WithEvents btnSeleccionaRuta As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pgr As ProgressBar
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents lblRuta As ToolStripLabel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeleccionarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckedListBoxDivi As CheckedListBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BuscarRecursivamenteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents lblEncontrados As ToolStripLabel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
