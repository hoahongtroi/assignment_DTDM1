<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fmenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SinhVienToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SinhvienToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SinhVienToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(386, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SinhVienToolStripMenuItem
        '
        Me.SinhVienToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SinhvienToolStripMenuItem1})
        Me.SinhVienToolStripMenuItem.Name = "SinhVienToolStripMenuItem"
        Me.SinhVienToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.SinhVienToolStripMenuItem.Text = "sinh vien"
        '
        'SinhvienToolStripMenuItem1
        '
        Me.SinhvienToolStripMenuItem1.Name = "SinhvienToolStripMenuItem1"
        Me.SinhvienToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.SinhvienToolStripMenuItem1.Text = "sinhvien"
        '
        'Fmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 262)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Fmenu"
        Me.Text = "Fmenu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SinhVienToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SinhvienToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
