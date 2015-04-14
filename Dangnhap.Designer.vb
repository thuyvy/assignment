<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fmdangnhap
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
        Me.lbdangnhap = New System.Windows.Forms.Label()
        Me.lbpass = New System.Windows.Forms.Label()
        Me.txtdangnhap = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.bttdangnhap = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbdangnhap
        '
        Me.lbdangnhap.AutoSize = True
        Me.lbdangnhap.BackColor = System.Drawing.Color.Transparent
        Me.lbdangnhap.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbdangnhap.Location = New System.Drawing.Point(37, 60)
        Me.lbdangnhap.Name = "lbdangnhap"
        Me.lbdangnhap.Size = New System.Drawing.Size(47, 22)
        Me.lbdangnhap.TabIndex = 0
        Me.lbdangnhap.Text = "User"
        '
        'lbpass
        '
        Me.lbpass.AutoSize = True
        Me.lbpass.BackColor = System.Drawing.Color.Transparent
        Me.lbpass.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbpass.Location = New System.Drawing.Point(37, 108)
        Me.lbpass.Name = "lbpass"
        Me.lbpass.Size = New System.Drawing.Size(83, 22)
        Me.lbpass.TabIndex = 1
        Me.lbpass.Text = "Password"
        '
        'txtdangnhap
        '
        Me.txtdangnhap.Location = New System.Drawing.Point(137, 63)
        Me.txtdangnhap.Name = "txtdangnhap"
        Me.txtdangnhap.Size = New System.Drawing.Size(166, 20)
        Me.txtdangnhap.TabIndex = 2
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(137, 111)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(166, 20)
        Me.txtpass.TabIndex = 3
        '
        'bttdangnhap
        '
        Me.bttdangnhap.Location = New System.Drawing.Point(170, 170)
        Me.bttdangnhap.Name = "bttdangnhap"
        Me.bttdangnhap.Size = New System.Drawing.Size(85, 28)
        Me.bttdangnhap.TabIndex = 4
        Me.bttdangnhap.Text = "Đăng nhập"
        Me.bttdangnhap.UseVisualStyleBackColor = True
        '
        'fmdangnhap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.assignment.My.Resources.Resources.nen2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(402, 227)
        Me.Controls.Add(Me.bttdangnhap)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtdangnhap)
        Me.Controls.Add(Me.lbpass)
        Me.Controls.Add(Me.lbdangnhap)
        Me.HelpButton = True
        Me.Name = "fmdangnhap"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Đăng Nhập"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbdangnhap As System.Windows.Forms.Label
    Friend WithEvents lbpass As System.Windows.Forms.Label
    Friend WithEvents txtdangnhap As System.Windows.Forms.TextBox
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents bttdangnhap As System.Windows.Forms.Button

End Class
