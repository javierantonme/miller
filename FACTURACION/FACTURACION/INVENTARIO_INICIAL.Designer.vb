<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class INVENTARIO_INICIAL
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
        Me.BTM_GUARDAR = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BTM_SALIR = New System.Windows.Forms.ToolStripButton()
        Me.TB_INFO = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LB_INFO = New System.Windows.Forms.ListBox()
        Me.RB_DESCRIPCION = New System.Windows.Forms.RadioButton()
        Me.RB_CODIGO = New System.Windows.Forms.RadioButton()
        Me.TB_CANTIDAD = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LB_UNIDADES = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TB_ARTICULO = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_CODIGO = New System.Windows.Forms.TextBox()
        Me.TB_BODEGA = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TB_CONSECUTIVO = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TB_FECHA = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BTM_GUARDAR, Me.ToolStripSeparator1, Me.BTM_SALIR})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1362, 70)
        Me.ToolStrip1.TabIndex = 55
        Me.ToolStrip1.Text = "ToolStrip1"
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
        'TB_INFO
        '
        Me.TB_INFO.Location = New System.Drawing.Point(7, 67)
        Me.TB_INFO.Name = "TB_INFO"
        Me.TB_INFO.Size = New System.Drawing.Size(220, 20)
        Me.TB_INFO.TabIndex = 56
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LB_INFO)
        Me.GroupBox1.Controls.Add(Me.RB_DESCRIPCION)
        Me.GroupBox1.Controls.Add(Me.TB_INFO)
        Me.GroupBox1.Controls.Add(Me.RB_CODIGO)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 138)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(233, 259)
        Me.GroupBox1.TabIndex = 58
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro"
        '
        'LB_INFO
        '
        Me.LB_INFO.FormattingEnabled = True
        Me.LB_INFO.Location = New System.Drawing.Point(7, 94)
        Me.LB_INFO.Name = "LB_INFO"
        Me.LB_INFO.Size = New System.Drawing.Size(207, 160)
        Me.LB_INFO.TabIndex = 57
        '
        'RB_DESCRIPCION
        '
        Me.RB_DESCRIPCION.AutoSize = True
        Me.RB_DESCRIPCION.Checked = True
        Me.RB_DESCRIPCION.Location = New System.Drawing.Point(7, 44)
        Me.RB_DESCRIPCION.Name = "RB_DESCRIPCION"
        Me.RB_DESCRIPCION.Size = New System.Drawing.Size(81, 17)
        Me.RB_DESCRIPCION.TabIndex = 1
        Me.RB_DESCRIPCION.TabStop = True
        Me.RB_DESCRIPCION.Text = "Descripción"
        Me.RB_DESCRIPCION.UseVisualStyleBackColor = True
        '
        'RB_CODIGO
        '
        Me.RB_CODIGO.AutoSize = True
        Me.RB_CODIGO.Location = New System.Drawing.Point(7, 20)
        Me.RB_CODIGO.Name = "RB_CODIGO"
        Me.RB_CODIGO.Size = New System.Drawing.Size(58, 17)
        Me.RB_CODIGO.TabIndex = 0
        Me.RB_CODIGO.Text = "Codigo"
        Me.RB_CODIGO.UseVisualStyleBackColor = True
        '
        'TB_CANTIDAD
        '
        Me.TB_CANTIDAD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TB_CANTIDAD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CANTIDAD.Location = New System.Drawing.Point(13, 506)
        Me.TB_CANTIDAD.Name = "TB_CANTIDAD"
        Me.TB_CANTIDAD.Size = New System.Drawing.Size(100, 26)
        Me.TB_CANTIDAD.TabIndex = 59
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 489)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Cantidad Inicial"
        '
        'LB_UNIDADES
        '
        Me.LB_UNIDADES.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LB_UNIDADES.AutoSize = True
        Me.LB_UNIDADES.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_UNIDADES.Location = New System.Drawing.Point(118, 506)
        Me.LB_UNIDADES.Name = "LB_UNIDADES"
        Me.LB_UNIDADES.Size = New System.Drawing.Size(102, 20)
        Me.LB_UNIDADES.TabIndex = 61
        Me.LB_UNIDADES.Text = "UNIDADES"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Descripcion, Me.Cantidad})
        Me.DataGridView1.Location = New System.Drawing.Point(271, 123)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(546, 457)
        Me.DataGridView1.TabIndex = 62
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 300
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'TB_ARTICULO
        '
        Me.TB_ARTICULO.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TB_ARTICULO.Location = New System.Drawing.Point(13, 459)
        Me.TB_ARTICULO.Name = "TB_ARTICULO"
        Me.TB_ARTICULO.ReadOnly = True
        Me.TB_ARTICULO.Size = New System.Drawing.Size(233, 20)
        Me.TB_ARTICULO.TabIndex = 63
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 441)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 13)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Articulo Seleccionado"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 400)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "Codigo Articulo"
        '
        'TB_CODIGO
        '
        Me.TB_CODIGO.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TB_CODIGO.Location = New System.Drawing.Point(13, 418)
        Me.TB_CODIGO.Name = "TB_CODIGO"
        Me.TB_CODIGO.ReadOnly = True
        Me.TB_CODIGO.Size = New System.Drawing.Size(233, 20)
        Me.TB_CODIGO.TabIndex = 65
        '
        'TB_BODEGA
        '
        Me.TB_BODEGA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TB_BODEGA.FormattingEnabled = True
        Me.TB_BODEGA.Location = New System.Drawing.Point(12, 100)
        Me.TB_BODEGA.Name = "TB_BODEGA"
        Me.TB_BODEGA.Size = New System.Drawing.Size(233, 21)
        Me.TB_BODEGA.TabIndex = 67
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Bodega"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(190, 539)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 39)
        Me.Button1.TabIndex = 69
        Me.Button1.Text = "CARGAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TB_CONSECUTIVO
        '
        Me.TB_CONSECUTIVO.Location = New System.Drawing.Point(271, 100)
        Me.TB_CONSECUTIVO.Name = "TB_CONSECUTIVO"
        Me.TB_CONSECUTIVO.ReadOnly = True
        Me.TB_CONSECUTIVO.Size = New System.Drawing.Size(138, 20)
        Me.TB_CONSECUTIVO.TabIndex = 70
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(268, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Consecutivo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(425, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Fecha"
        '
        'TB_FECHA
        '
        Me.TB_FECHA.Location = New System.Drawing.Point(428, 101)
        Me.TB_FECHA.Name = "TB_FECHA"
        Me.TB_FECHA.ReadOnly = True
        Me.TB_FECHA.Size = New System.Drawing.Size(138, 20)
        Me.TB_FECHA.TabIndex = 72
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(835, 123)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(527, 455)
        Me.DataGridView2.TabIndex = 74
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(832, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 13)
        Me.Label7.TabIndex = 75
        Me.Label7.Text = "Articulos en Bodega"
        '
        'INVENTARIO_INICIAL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1362, 580)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TB_FECHA)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TB_CONSECUTIVO)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TB_BODEGA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TB_CODIGO)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TB_ARTICULO)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.LB_UNIDADES)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TB_CANTIDAD)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "INVENTARIO_INICIAL"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "INVENTARIO INICIAL"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BTM_GUARDAR As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BTM_SALIR As System.Windows.Forms.ToolStripButton
    Friend WithEvents TB_INFO As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LB_INFO As System.Windows.Forms.ListBox
    Friend WithEvents RB_DESCRIPCION As System.Windows.Forms.RadioButton
    Friend WithEvents RB_CODIGO As System.Windows.Forms.RadioButton
    Friend WithEvents TB_CANTIDAD As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LB_UNIDADES As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TB_ARTICULO As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TB_CODIGO As System.Windows.Forms.TextBox
    Friend WithEvents TB_BODEGA As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TB_CONSECUTIVO As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TB_FECHA As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
