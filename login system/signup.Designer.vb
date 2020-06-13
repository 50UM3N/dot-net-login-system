<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class signup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(signup))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.btnMinimize = New Guna.UI.WinForms.GunaControlBox()
        Me.btnClose = New Guna.UI.WinForms.GunaControlBox()
        Me.btnSignup = New Guna.UI.WinForms.GunaButton()
        Me.textUsername = New Guna.UI.WinForms.GunaTextBox()
        Me.textName = New Guna.UI.WinForms.GunaTextBox()
        Me.textPassword = New Guna.UI.WinForms.GunaTextBox()
        Me.textCPassword = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.linkLogin = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.message = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 10
        Me.GunaElipse1.TargetControl = Me
        '
        'btnMinimize
        '
        Me.btnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimize.AnimationHoverSpeed = 0.07!
        Me.btnMinimize.AnimationSpeed = 0.03!
        Me.btnMinimize.ControlBoxTheme = Guna.UI.WinForms.FormControlBoxTheme.Custom
        Me.btnMinimize.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox
        Me.btnMinimize.IconColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnMinimize.IconSize = 15.0!
        Me.btnMinimize.Location = New System.Drawing.Point(271, 6)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnMinimize.OnHoverIconColor = System.Drawing.Color.White
        Me.btnMinimize.OnPressedColor = System.Drawing.Color.Black
        Me.btnMinimize.Size = New System.Drawing.Size(45, 29)
        Me.btnMinimize.TabIndex = 4
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.AnimationHoverSpeed = 0.07!
        Me.btnClose.AnimationSpeed = 0.03!
        Me.btnClose.ControlBoxTheme = Guna.UI.WinForms.FormControlBoxTheme.Custom
        Me.btnClose.IconColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnClose.IconSize = 15.0!
        Me.btnClose.Location = New System.Drawing.Point(322, 6)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnClose.OnHoverIconColor = System.Drawing.Color.White
        Me.btnClose.OnPressedColor = System.Drawing.Color.Black
        Me.btnClose.Size = New System.Drawing.Size(45, 29)
        Me.btnClose.TabIndex = 3
        '
        'btnSignup
        '
        Me.btnSignup.AnimationHoverSpeed = 0.07!
        Me.btnSignup.AnimationSpeed = 0.03!
        Me.btnSignup.BackColor = System.Drawing.Color.Transparent
        Me.btnSignup.BaseColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnSignup.BorderColor = System.Drawing.Color.Black
        Me.btnSignup.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSignup.FocusedColor = System.Drawing.Color.Empty
        Me.btnSignup.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnSignup.ForeColor = System.Drawing.Color.White
        Me.btnSignup.Image = Nothing
        Me.btnSignup.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSignup.Location = New System.Drawing.Point(92, 400)
        Me.btnSignup.Name = "btnSignup"
        Me.btnSignup.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnSignup.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnSignup.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnSignup.OnHoverImage = Nothing
        Me.btnSignup.OnPressedColor = System.Drawing.Color.Black
        Me.btnSignup.Radius = 16
        Me.btnSignup.Size = New System.Drawing.Size(176, 32)
        Me.btnSignup.TabIndex = 10
        Me.btnSignup.Text = "Sign Up"
        Me.btnSignup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'textUsername
        '
        Me.textUsername.BackColor = System.Drawing.Color.Transparent
        Me.textUsername.BaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.textUsername.BorderColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.textUsername.BorderSize = 1
        Me.textUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textUsername.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.textUsername.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.textUsername.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.textUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.textUsername.ForeColor = System.Drawing.Color.DimGray
        Me.textUsername.Location = New System.Drawing.Point(36, 272)
        Me.textUsername.Name = "textUsername"
        Me.textUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.textUsername.Radius = 5
        Me.textUsername.SelectedText = ""
        Me.textUsername.Size = New System.Drawing.Size(297, 30)
        Me.textUsername.TabIndex = 9
        Me.textUsername.Text = "Username"
        '
        'textName
        '
        Me.textName.BackColor = System.Drawing.Color.Transparent
        Me.textName.BaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.textName.BorderColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.textName.BorderSize = 1
        Me.textName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textName.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.textName.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.textName.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.textName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.textName.ForeColor = System.Drawing.Color.DimGray
        Me.textName.Location = New System.Drawing.Point(36, 232)
        Me.textName.Name = "textName"
        Me.textName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.textName.Radius = 5
        Me.textName.SelectedText = ""
        Me.textName.Size = New System.Drawing.Size(297, 30)
        Me.textName.TabIndex = 8
        Me.textName.Text = "Name"
        '
        'textPassword
        '
        Me.textPassword.BackColor = System.Drawing.Color.Transparent
        Me.textPassword.BaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.textPassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.textPassword.BorderSize = 1
        Me.textPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textPassword.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.textPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.textPassword.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.textPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.textPassword.ForeColor = System.Drawing.Color.DimGray
        Me.textPassword.Location = New System.Drawing.Point(36, 312)
        Me.textPassword.Name = "textPassword"
        Me.textPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.textPassword.Radius = 5
        Me.textPassword.SelectedText = ""
        Me.textPassword.Size = New System.Drawing.Size(297, 30)
        Me.textPassword.TabIndex = 11
        Me.textPassword.Text = "Password"
        '
        'textCPassword
        '
        Me.textCPassword.BackColor = System.Drawing.Color.Transparent
        Me.textCPassword.BaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.textCPassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.textCPassword.BorderSize = 1
        Me.textCPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.textCPassword.FocusedBaseColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.textCPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.textCPassword.FocusedForeColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.textCPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.textCPassword.ForeColor = System.Drawing.Color.DimGray
        Me.textCPassword.Location = New System.Drawing.Point(36, 352)
        Me.textCPassword.Name = "textCPassword"
        Me.textCPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.textCPassword.Radius = 5
        Me.textCPassword.SelectedText = ""
        Me.textCPassword.Size = New System.Drawing.Size(297, 30)
        Me.textCPassword.TabIndex = 12
        Me.textCPassword.Text = "Confirm Password"
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label1.Location = New System.Drawing.Point(30, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 33)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Get on Board"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.database.My.Resources.Resources.small_hacker1
        Me.PictureBox2.Location = New System.Drawing.Point(112, 32)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(144, 112)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.database.My.Resources.Resources.Untitled_1
        Me.PictureBox1.Location = New System.Drawing.Point(-5, 459)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(381, 174)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'linkLogin
        '
        Me.linkLogin.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.linkLogin.AutoSize = True
        Me.linkLogin.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkLogin.LinkColor = System.Drawing.Color.DimGray
        Me.linkLogin.Location = New System.Drawing.Point(203, 441)
        Me.linkLogin.Margin = New System.Windows.Forms.Padding(0)
        Me.linkLogin.Name = "linkLogin"
        Me.linkLogin.Size = New System.Drawing.Size(34, 13)
        Me.linkLogin.TabIndex = 20
        Me.linkLogin.TabStop = True
        Me.linkLogin.Text = "Log In"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(119, 441)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Alredy member?"
        '
        'message
        '
        Me.message.ForeColor = System.Drawing.Color.DarkGray
        Me.message.Location = New System.Drawing.Point(36, 204)
        Me.message.Name = "message"
        Me.message.Size = New System.Drawing.Size(297, 23)
        Me.message.TabIndex = 21
        Me.message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'signup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(371, 611)
        Me.Controls.Add(Me.message)
        Me.Controls.Add(Me.linkLogin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.textCPassword)
        Me.Controls.Add(Me.textPassword)
        Me.Controls.Add(Me.btnSignup)
        Me.Controls.Add(Me.textUsername)
        Me.Controls.Add(Me.textName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.btnClose)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "signup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "signup"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents btnMinimize As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents btnClose As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents textCPassword As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents textPassword As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents btnSignup As Guna.UI.WinForms.GunaButton
    Friend WithEvents textUsername As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents textName As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents Label1 As Label
    Friend WithEvents linkLogin As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents message As Label
End Class
