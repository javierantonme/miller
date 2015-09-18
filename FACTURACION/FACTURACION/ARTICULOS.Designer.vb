<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ARTICULOS
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
        Me.btm_nuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BTM_GUARDAR = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BTM_MODIFICAR = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BTM_SALIR = New System.Windows.Forms.ToolStripButton()
        Me.TB_CODIGO = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_DESCRIPCION = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_VALOR = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_IVA = New System.Windows.Forms.TextBox()
        Me.TB_PRESENTACION = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TB_INFO = New System.Windows.Forms.TextBox()
        Me.RB_NOMBRE = New System.Windows.Forms.RadioButton()
        Me.RB_CODIGO = New System.Windows.Forms.RadioButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.LB_CANTIDAD = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btm_nuevo, Me.ToolStripSeparator2, Me.BTM_GUARDAR, Me.ToolStripSeparator1, Me.BTM_MODIFICAR, Me.ToolStripSeparator3, Me.BTM_SALIR})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(780, 70)
        Me.ToolStrip1.TabIndex = 54
        Me.ToolStrip1.Text = "ToolStrip1"
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
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 70)
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 70)
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
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 70)
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
        'TB_CODIGO
        '
        Me.TB_CODIGO.Location = New System.Drawing.Point(9, 94)
        Me.TB_CODIGO.Name = "TB_CODIGO"
        Me.TB_CODIGO.Size = New System.Drawing.Size(196, 20)
        Me.TB_CODIGO.TabIndex = 56
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Codigo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(118, 13)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Descripcion del Articulo"
        '
        'TB_DESCRIPCION
        '
        Me.TB_DESCRIPCION.Location = New System.Drawing.Point(9, 132)
        Me.TB_DESCRIPCION.Name = "TB_DESCRIPCION"
        Me.TB_DESCRIPCION.Size = New System.Drawing.Size(521, 20)
        Me.TB_DESCRIPCION.TabIndex = 58
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Valor"
        '
        'TB_VALOR
        '
        Me.TB_VALOR.Location = New System.Drawing.Point(12, 175)
        Me.TB_VALOR.Name = "TB_VALOR"
        Me.TB_VALOR.Size = New System.Drawing.Size(193, 20)
        Me.TB_VALOR.TabIndex = 60
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(219, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "I.V.A"
        '
        'TB_IVA
        '
        Me.TB_IVA.Location = New System.Drawing.Point(219, 175)
        Me.TB_IVA.Name = "TB_IVA"
        Me.TB_IVA.Size = New System.Drawing.Size(62, 20)
        Me.TB_IVA.TabIndex = 62
        Me.TB_IVA.Text = "16"
        '
        'TB_PRESENTACION
        '
        Me.TB_PRESENTACION.FormattingEnabled = True
        Me.TB_PRESENTACION.Location = New System.Drawing.Point(557, 132)
        Me.TB_PRESENTACION.Name = "TB_PRESENTACION"
        Me.TB_PRESENTACION.Size = New System.Drawing.Size(211, 21)
        Me.TB_PRESENTACION.TabIndex = 64
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(554, 117)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Presentacion"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(280, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 20)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "%"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TB_INFO)
        Me.GroupBox1.Controls.Add(Me.RB_NOMBRE)
        Me.GroupBox1.Controls.Add(Me.RB_CODIGO)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 211)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(349, 67)
        Me.GroupBox1.TabIndex = 67
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro de Busqueda"
        '
        'TB_INFO
        '
        Me.TB_INFO.Location = New System.Drawing.Point(84, 28)
        Me.TB_INFO.Name = "TB_INFO"
        Me.TB_INFO.Size = New System.Drawing.Size(246, 20)
        Me.TB_INFO.TabIndex = 2
        '
        'RB_NOMBRE
        '
        Me.RB_NOMBRE.AutoSize = True
        Me.RB_NOMBRE.Checked = True
        Me.RB_NOMBRE.Location = New System.Drawing.Point(16, 42)
        Me.RB_NOMBRE.Name = "RB_NOMBRE"
        Me.RB_NOMBRE.Size = New System.Drawing.Size(62, 17)
        Me.RB_NOMBRE.TabIndex = 1
        Me.RB_NOMBRE.TabStop = True
        Me.RB_NOMBRE.Text = "Nombre"
        Me.RB_NOMBRE.UseVisualStyleBackColor = True
        '
        'RB_CODIGO
        '
        Me.RB_CODIGO.AutoSize = True
        Me.RB_CODIGO.Location = New System.Drawing.Point(16, 19)
        Me.RB_CODIGO.Name = "RB_CODIGO"
        Me.RB_CODIGO.Size = New System.Drawing.Size(58, 17)
        Me.RB_CODIGO.TabIndex = 0
        Me.RB_CODIGO.Text = "Codigo"
        Me.RB_CODIGO.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LB_CANTIDAD})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 540)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(780, 22)
        Me.StatusStrip1.TabIndex = 68
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'LB_CANTIDAD
        '
        Me.LB_CANTIDAD.Name = "LB_CANTIDAD"
        Me.LB_CANTIDAD.Size = New System.Drawing.Size(13, 17)
        Me.LB_CANTIDAD.Text = "0"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 284)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(780, 256)
        Me.DataGridView1.TabIndex = 69
        '
        'ARTICULOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TB_IVA)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TB_PRESENTACION)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TB_VALOR)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TB_DESCRIPCION)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TB_CODIGO)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "ARTICULOS"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ARTICULOS"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
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
    Friend WithEvents TB_CODIGO As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TB_DESCRIPCION As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TB_VALOR As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TB_IVA As System.Windows.Forms.TextBox
    Friend WithEvents TB_PRESENTACION As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TB_INFO As System.Windows.Forms.TextBox
    Friend WithEvents RB_NOMBRE As System.Windows.Forms.RadioButton
    Friend WithEvents RB_CODIGO As System.Windows.Forms.RadioButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents LB_CANTIDAD As System.Windows.Forms.ToolStripStatusLabel
End Class
