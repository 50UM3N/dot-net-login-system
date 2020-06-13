<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.btnClose = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.btnMinimize = New Guna.UI.WinForms.GunaControlBox()
        Me.textUsername = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaDragControl2 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.textPassword = New Guna.UI.WinForms.GunaTextBox()
        Me.btnLogin = New Guna.UI.WinForms.GunaButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.message = New System.Windows.Forms.Label()
        Me.linkSignup = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GunaElipse2 = New Guna.UI.WinForms.GunaElipse(Me.components)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 10
        Me.GunaElipse1.TargetControl = Me
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
        Me.btnClose.TabIndex = 1
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Nothing
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
        Me.btnMinimize.TabIndex = 2
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
        Me.textUsername.Location = New System.Drawing.Point(36, 268)
        Me.textUsername.Name = "textUsername"
        Me.textUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.textUsername.Radius = 5
        Me.textUsername.SelectedText = ""
        Me.textUsername.Size = New System.Drawing.Size(297, 30)
        Me.textUsername.TabIndex = 4
        Me.textUsername.Text = "Username/E-mail"
        '
        'GunaDragControl2
        '
        Me.GunaDragControl2.TargetControl = Me
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
        Me.textPassword.Location = New System.Drawing.Point(36, 308)
        Me.textPassword.Name = "textPassword"
        Me.textPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.textPassword.Radius = 5
        Me.textPassword.SelectedText = ""
        Me.textPassword.Size = New System.Drawing.Size(297, 30)
        Me.textPassword.TabIndex = 5
        Me.textPassword.Text = "Password"
        '
        'btnLogin
        '
        Me.btnLogin.AnimationHoverSpeed = 0.07!
        Me.btnLogin.AnimationSpeed = 0.03!
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.BaseColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(19, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnLogin.BorderColor = System.Drawing.Color.Black
        Me.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnLogin.FocusedColor = System.Drawing.Color.Empty
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Image = Nothing
        Me.btnLogin.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnLogin.Location = New System.Drawing.Point(92, 357)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnLogin.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnLogin.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.btnLogin.OnHoverImage = Nothing
        Me.btnLogin.OnPressedColor = System.Drawing.Color.Black
        Me.btnLogin.Radius = 16
        Me.btnLogin.Size = New System.Drawing.Size(176, 32)
        Me.btnLogin.TabIndex = 7
        Me.btnLogin.Text = "Login"
        Me.btnLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(134, 566)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Soumen Khara"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gainsboro
        Me.Label3.Location = New System.Drawing.Point(30, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 66)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Hello there," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "welcome back"
        '
        'message
        '
        Me.message.ForeColor = System.Drawing.Color.DarkGray
        Me.message.Location = New System.Drawing.Point(36, 238)
        Me.message.Name = "message"
        Me.message.Size = New System.Drawing.Size(297, 23)
        Me.message.TabIndex = 17
        Me.message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'linkSignup
        '
        Me.linkSignup.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.linkSignup.AutoSize = True
        Me.linkSignup.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.linkSignup.LinkColor = System.Drawing.Color.DimGray
        Me.linkSignup.Location = New System.Drawing.Point(188, 406)
        Me.linkSignup.Margin = New System.Windows.Forms.Padding(0)
        Me.linkSignup.Name = "linkSignup"
        Me.linkSignup.Size = New System.Drawing.Size(41, 13)
        Me.linkSignup.TabIndex = 18
        Me.linkSignup.TabStop = True
        Me.linkSignup.Text = "Sign Up"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(131, 406)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "New here?"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.database.My.Resources.Resources.small_hacker1
        Me.PictureBox2.Location = New System.Drawing.Point(112, 32)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(144, 112)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.database.My.Resources.Resources.Untitled_1
        Me.PictureBox1.Location = New System.Drawing.Point(-5, 459)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(381, 174)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'GunaElipse2
        '
        Me.GunaElipse2.TargetControl = Me
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(23, Byte), Integer), CType(CType(4, Byte), Integer), CType(CType(32, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(371, 611)
        Me.Controls.Add(Me.linkSignup)
        Me.Controls.Add(Me.message)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.textPassword)
        Me.Controls.Add(Me.textUsername)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnMinimize)
        Me.Controls.Add(Me.btnClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "login"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnMinimize As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents btnClose As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents textUsername As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaDragControl2 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents textPassword As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnLogin As Guna.UI.WinForms.GunaButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents message As Label
    Friend WithEvents linkSignup As LinkLabel
    Friend WithEvents Label2 As Label
    Friend WithEvents GunaElipse2 As Guna.UI.WinForms.GunaElipse
End Class
