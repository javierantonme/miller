<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOGIN
    Inherits Telerik.WinControls.UI.RadForm

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
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.TB_USUARIO = New Telerik.WinControls.UI.RadTextBox()
        Me.TB_CONTRASEÑA = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TB_USUARIO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TB_CONTRASEÑA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(12, 60)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(44, 18)
        Me.RadLabel1.TabIndex = 0
        Me.RadLabel1.Text = "Usuario"
        '
        'TB_USUARIO
        '
        Me.TB_USUARIO.Location = New System.Drawing.Point(12, 78)
        Me.TB_USUARIO.Name = "TB_USUARIO"
        Me.TB_USUARIO.Size = New System.Drawing.Size(214, 20)
        Me.TB_USUARIO.TabIndex = 1
        '
        'TB_CONTRASEÑA
        '
        Me.TB_CONTRASEÑA.Location = New System.Drawing.Point(12, 122)
        Me.TB_CONTRASEÑA.Name = "TB_CONTRASEÑA"
        Me.TB_CONTRASEÑA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.TB_CONTRASEÑA.Size = New System.Drawing.Size(214, 20)
        Me.TB_CONTRASEÑA.TabIndex = 3
        Me.TB_CONTRASEÑA.UseSystemPasswordChar = True
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(12, 104)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(63, 18)
        Me.RadLabel2.TabIndex = 2
        Me.RadLabel2.Text = "Contraseña"
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(12, 145)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(110, 24)
        Me.RadButton1.TabIndex = 4
        Me.RadButton1.Text = "Inicio de Sesion"
        '
        'RadButton2
        '
        Me.RadButton2.Location = New System.Drawing.Point(128, 145)
        Me.RadButton2.Name = "RadButton2"
        Me.RadButton2.Size = New System.Drawing.Size(110, 24)
        Me.RadButton2.TabIndex = 5
        Me.RadButton2.Text = "Cancelar"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.AFILIAMOS.My.Resources.Resources.afiliamos1
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(226, 42)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'LOGIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(251, 174)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RadButton2)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.TB_CONTRASEÑA)
        Me.Controls.Add(Me.RadLabel2)
        Me.Controls.Add(Me.TB_USUARIO)
        Me.Controls.Add(Me.RadLabel1)
        Me.Name = "LOGIN"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de Sesion"
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TB_USUARIO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TB_CONTRASEÑA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TB_USUARIO As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TB_CONTRASEÑA As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class

