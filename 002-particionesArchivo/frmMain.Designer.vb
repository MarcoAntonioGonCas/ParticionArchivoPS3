<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DividirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnirArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnunir = New System.Windows.Forms.Button()
        Me.btndividir = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(646, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.DividirToolStripMenuItem, Me.UnirArchivoToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(135, 6)
        '
        'DividirToolStripMenuItem
        '
        Me.DividirToolStripMenuItem.Name = "DividirToolStripMenuItem"
        Me.DividirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DividirToolStripMenuItem.Text = "Dividir"
        '
        'UnirArchivoToolStripMenuItem
        '
        Me.UnirArchivoToolStripMenuItem.Name = "UnirArchivoToolStripMenuItem"
        Me.UnirArchivoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UnirArchivoToolStripMenuItem.Text = "Unir archivo"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnunir)
        Me.Panel1.Controls.Add(Me.btndividir)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(646, 55)
        Me.Panel1.TabIndex = 2
        '
        'btnunir
        '
        Me.btnunir.AutoSize = True
        Me.btnunir.BackColor = System.Drawing.Color.White
        Me.btnunir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnunir.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnunir.FlatAppearance.BorderSize = 0
        Me.btnunir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnunir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnunir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnunir.Location = New System.Drawing.Point(320, 0)
        Me.btnunir.Name = "btnunir"
        Me.btnunir.Size = New System.Drawing.Size(326, 55)
        Me.btnunir.TabIndex = 1
        Me.btnunir.Text = "Unir partes de archivo"
        Me.btnunir.UseVisualStyleBackColor = False
        '
        'btndividir
        '
        Me.btndividir.BackColor = System.Drawing.Color.White
        Me.btndividir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndividir.Dock = System.Windows.Forms.DockStyle.Left
        Me.btndividir.FlatAppearance.BorderSize = 0
        Me.btndividir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndividir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndividir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btndividir.Location = New System.Drawing.Point(0, 0)
        Me.btndividir.Name = "btndividir"
        Me.btndividir.Size = New System.Drawing.Size(320, 55)
        Me.btndividir.TabIndex = 0
        Me.btndividir.Text = "Dividir archivo"
        Me.btndividir.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(646, 254)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Archivos"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents DividirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnirArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnunir As Button
    Friend WithEvents btndividir As Button
End Class
