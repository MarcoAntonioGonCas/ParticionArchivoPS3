<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFileMarge
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
        Dim Panel1 As System.Windows.Forms.Panel
        Me.btnSelecCarpeta = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CheckedListBoxDivi = New System.Windows.Forms.CheckedListBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.prgActual = New System.Windows.Forms.ProgressBar()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.prgTotal = New System.Windows.Forms.ProgressBar()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarParticionesAlCompletarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.stlblInfoTotal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.sslblInfoActual = New System.Windows.Forms.ToolStripStatusLabel()
        Panel1 = New System.Windows.Forms.Panel()
        Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.StatusStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Panel1.Controls.Add(Me.btnSelecCarpeta)
        Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Panel1.Location = New System.Drawing.Point(0, 24)
        Panel1.Name = "Panel1"
        Panel1.Size = New System.Drawing.Size(804, 68)
        Panel1.TabIndex = 0
        '
        'btnSelecCarpeta
        '
        Me.btnSelecCarpeta.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnSelecCarpeta.Location = New System.Drawing.Point(0, 0)
        Me.btnSelecCarpeta.Name = "btnSelecCarpeta"
        Me.btnSelecCarpeta.Size = New System.Drawing.Size(181, 68)
        Me.btnSelecCarpeta.TabIndex = 0
        Me.btnSelecCarpeta.Text = "Seleccionar carpeta"
        Me.btnSelecCarpeta.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CheckedListBoxDivi)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 92)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(804, 139)
        Me.Panel2.TabIndex = 1
        '
        'CheckedListBoxDivi
        '
        Me.CheckedListBoxDivi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CheckedListBoxDivi.FormattingEnabled = True
        Me.CheckedListBoxDivi.Location = New System.Drawing.Point(0, 0)
        Me.CheckedListBoxDivi.Name = "CheckedListBoxDivi"
        Me.CheckedListBoxDivi.Size = New System.Drawing.Size(804, 139)
        Me.CheckedListBoxDivi.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 313)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(804, 126)
        Me.Panel3.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.StatusStrip2)
        Me.Panel5.Controls.Add(Me.prgActual)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(0, 58)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(804, 68)
        Me.Panel5.TabIndex = 1
        '
        'prgActual
        '
        Me.prgActual.Dock = System.Windows.Forms.DockStyle.Top
        Me.prgActual.Location = New System.Drawing.Point(0, 0)
        Me.prgActual.Name = "prgActual"
        Me.prgActual.Size = New System.Drawing.Size(804, 23)
        Me.prgActual.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.StatusStrip1)
        Me.Panel4.Controls.Add(Me.prgTotal)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(804, 58)
        Me.Panel4.TabIndex = 0
        '
        'prgTotal
        '
        Me.prgTotal.Dock = System.Windows.Forms.DockStyle.Top
        Me.prgTotal.Location = New System.Drawing.Point(0, 0)
        Me.prgTotal.Name = "prgTotal"
        Me.prgTotal.Size = New System.Drawing.Size(804, 23)
        Me.prgTotal.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.btnCancelar)
        Me.Panel6.Controls.Add(Me.btnAceptar)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 231)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(804, 52)
        Me.Panel6.TabIndex = 3
        '
        'btnCancelar
        '
        Me.btnCancelar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.Gray
        Me.btnCancelar.Location = New System.Drawing.Point(684, 0)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(120, 52)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAceptar.ForeColor = System.Drawing.Color.Gray
        Me.btnAceptar.Location = New System.Drawing.Point(0, 0)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(120, 52)
        Me.btnAceptar.TabIndex = 0
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(804, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarParticionesAlCompletarToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'EliminarParticionesAlCompletarToolStripMenuItem
        '
        Me.EliminarParticionesAlCompletarToolStripMenuItem.Name = "EliminarParticionesAlCompletarToolStripMenuItem"
        Me.EliminarParticionesAlCompletarToolStripMenuItem.Size = New System.Drawing.Size(247, 22)
        Me.EliminarParticionesAlCompletarToolStripMenuItem.Text = "Eliminar particiones al completar"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stlblInfoTotal})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 36)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(804, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'stlblInfoTotal
        '
        Me.stlblInfoTotal.Name = "stlblInfoTotal"
        Me.stlblInfoTotal.Size = New System.Drawing.Size(19, 17)
        Me.stlblInfoTotal.Text = "...."
        '
        'StatusStrip2
        '
        Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sslblInfoActual})
        Me.StatusStrip2.Location = New System.Drawing.Point(0, 46)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.Size = New System.Drawing.Size(804, 22)
        Me.StatusStrip2.TabIndex = 2
        Me.StatusStrip2.Text = "StatusStrip2"
        '
        'sslblInfoActual
        '
        Me.sslblInfoActual.Name = "sslblInfoActual"
        Me.sslblInfoActual.Size = New System.Drawing.Size(16, 17)
        Me.sslblInfoActual.Text = "..."
        '
        'frmFileMarge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 439)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmFileMarge"
        Me.Text = "frmFileMarge"
        Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.StatusStrip2.ResumeLayout(False)
        Me.StatusStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSelecCarpeta As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CheckedListBoxDivi As CheckedListBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents prgActual As ProgressBar
    Friend WithEvents Panel4 As Panel
    Friend WithEvents prgTotal As ProgressBar
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarParticionesAlCompletarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusStrip2 As StatusStrip
    Friend WithEvents sslblInfoActual As ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents stlblInfoTotal As ToolStripStatusLabel
End Class
