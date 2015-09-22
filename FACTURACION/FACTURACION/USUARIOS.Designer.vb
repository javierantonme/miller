<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class USUARIOS
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.TB_CEDULA = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_NOMBRE = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_USUARIO = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_CONTRASEÑA = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btm_nuevo = New System.Windows.Forms.ToolStripButton()
        Me.BTM_GUARDAR = New System.Windows.Forms.ToolStripButton()
        Me.BTM_MODIFICAR = New System.Windows.Forms.ToolStripButton()
        Me.BTM_SALIR = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btm_nuevo, Me.ToolStripSeparator2, Me.BTM_GUARDAR, Me.ToolStripSeparator1, Me.BTM_MODIFICAR, Me.ToolStripSeparator3, Me.BTM_SALIR})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(490, 70)
        Me.ToolStrip1.TabIndex = 54
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 70)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 70)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 70)
        '
        'TB_CEDULA
        '
        Me.TB_CEDULA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_CEDULA.Location = New System.Drawing.Point(13, 96)
        Me.TB_CEDULA.Name = "TB_CEDULA"
        Me.TB_CEDULA.Size = New System.Drawing.Size(136, 20)
        Me.TB_CEDULA.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Identificación"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(170, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Nombre"
        '
        'TB_NOMBRE
        '
        Me.TB_NOMBRE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_NOMBRE.Location = New System.Drawing.Point(170, 96)
        Me.TB_NOMBRE.Name = "TB_NOMBRE"
        Me.TB_NOMBRE.Size = New System.Drawing.Size(308, 20)
        Me.TB_NOMBRE.TabIndex = 57
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Usuario"
        '
        'TB_USUARIO
        '
        Me.TB_USUARIO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_USUARIO.Location = New System.Drawing.Point(13, 136)
        Me.TB_USUARIO.Name = "TB_USUARIO"
        Me.TB_USUARIO.Size = New System.Drawing.Size(165, 20)
        Me.TB_USUARIO.TabIndex = 59
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(205, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Contraseña"
        '
        'TB_CONTRASEÑA
        '
        Me.TB_CONTRASEÑA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_CONTRASEÑA.Location = New System.Drawing.Point(205, 136)
        Me.TB_CONTRASEÑA.Name = "TB_CONTRASEÑA"
        Me.TB_CONTRASEÑA.Size = New System.Drawing.Size(165, 20)
        Me.TB_CONTRASEÑA.TabIndex = 61
        Me.TB_CONTRASEÑA.UseSystemPasswordChar = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 177)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(490, 155)
        Me.DataGridView1.TabIndex = 63
        '
        'btm_nuevo
        '
        Me.btm_nuevo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btm_nuevo.Image = Global.FACTURACION.My.Resources.Resources.page_add
        Me.btm_nuevo.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btm_nuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btm_nuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btm_nuevo.Name = "btm_nuevo"
        Me.btm_nuevo.Size = New System.Drawing.Size(52, 67)
        Me.btm_nuevo.Text = "Nuevo"
        Me.btm_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BTM_GUARDAR
        '
        Me.BTM_GUARDAR.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BTM_GUARDAR.Image = Global.FACTURACION.My.Resources.Resources.floppy_disk
        Me.BTM_GUARDAR.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTM_GUARDAR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BTM_GUARDAR.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BTM_GUARDAR.Name = "BTM_GUARDAR"
        Me.BTM_GUARDAR.Size = New System.Drawing.Size(56, 67)
        Me.BTM_GUARDAR.Text = "Guradar"
        Me.BTM_GUARDAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BTM_MODIFICAR
        '
        Me.BTM_MODIFICAR.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BTM_MODIFICAR.Image = Global.FACTURACION.My.Resources.Resources.page_edit
        Me.BTM_MODIFICAR.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTM_MODIFICAR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BTM_MODIFICAR.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BTM_MODIFICAR.Name = "BTM_MODIFICAR"
        Me.BTM_MODIFICAR.Size = New System.Drawing.Size(64, 67)
        Me.BTM_MODIFICAR.Text = "Modificar"
        Me.BTM_MODIFICAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BTM_SALIR
        '
        Me.BTM_SALIR.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BTM_SALIR.Image = Global.FACTURACION.My.Resources.Resources.salir_48_48
        Me.BTM_SALIR.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTM_SALIR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BTM_SALIR.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BTM_SALIR.Name = "BTM_SALIR"
        Me.BTM_SALIR.Size = New System.Drawing.Size(52, 67)
        Me.BTM_SALIR.Text = "Salir"
        Me.BTM_SALIR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'USUARIOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 332)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TB_CONTRASEÑA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TB_USUARIO)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TB_NOMBRE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TB_CEDULA)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "USUARIOS"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "USUARIOS"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btm_nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BTM_GUARDAR As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BTM_MODIFICAR As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BTM_SALIR As System.Windows.Forms.ToolStripButton
    Friend WithEvents TB_CEDULA As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TB_NOMBRE As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TB_USUARIO As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TB_CONTRASEÑA As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
