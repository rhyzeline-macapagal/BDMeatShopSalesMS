<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.lbluname = New System.Windows.Forms.Label()
        Me.lblpword = New System.Windows.Forms.Label()
        Me.txtuname = New System.Windows.Forms.TextBox()
        Me.txtpword = New System.Windows.Forms.TextBox()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.picblogo = New System.Windows.Forms.PictureBox()
        CType(Me.picblogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbluname
        '
        Me.lbluname.AutoSize = True
        Me.lbluname.Location = New System.Drawing.Point(571, 71)
        Me.lbluname.Name = "lbluname"
        Me.lbluname.Size = New System.Drawing.Size(73, 16)
        Me.lbluname.TabIndex = 1
        Me.lbluname.Text = "Username:"
        '
        'lblpword
        '
        Me.lblpword.AutoSize = True
        Me.lblpword.Location = New System.Drawing.Point(571, 286)
        Me.lblpword.Name = "lblpword"
        Me.lblpword.Size = New System.Drawing.Size(70, 16)
        Me.lblpword.TabIndex = 2
        Me.lblpword.Text = "Password:"
        '
        'txtuname
        '
        Me.txtuname.Location = New System.Drawing.Point(574, 90)
        Me.txtuname.Name = "txtuname"
        Me.txtuname.Size = New System.Drawing.Size(162, 22)
        Me.txtuname.TabIndex = 3
        '
        'txtpword
        '
        Me.txtpword.Location = New System.Drawing.Point(574, 305)
        Me.txtpword.Name = "txtpword"
        Me.txtpword.Size = New System.Drawing.Size(162, 22)
        Me.txtpword.TabIndex = 4
        '
        'btnlogin
        '
        Me.btnlogin.Location = New System.Drawing.Point(677, 404)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(75, 38)
        Me.btnlogin.TabIndex = 5
        Me.btnlogin.Text = "Login"
        Me.btnlogin.UseVisualStyleBackColor = True
        '
        'picblogo
        '
        Me.picblogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picblogo.ErrorImage = Nothing
        Me.picblogo.Image = Global.BDMeatShopSalesMS.My.Resources.Resources.bdmslogo
        Me.picblogo.Location = New System.Drawing.Point(-1, -3)
        Me.picblogo.Name = "picblogo"
        Me.picblogo.Size = New System.Drawing.Size(368, 423)
        Me.picblogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picblogo.TabIndex = 6
        Me.picblogo.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.picblogo)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.txtpword)
        Me.Controls.Add(Me.txtuname)
        Me.Controls.Add(Me.lblpword)
        Me.Controls.Add(Me.lbluname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        CType(Me.picblogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbluname As Label
    Friend WithEvents lblpword As Label
    Friend WithEvents txtuname As TextBox
    Friend WithEvents txtpword As TextBox
    Friend WithEvents btnlogin As Button
    Friend WithEvents picblogo As PictureBox
End Class
