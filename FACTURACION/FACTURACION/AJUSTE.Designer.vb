<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AJUSTE
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TB_BODEGA = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TB_PRECIO = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LB_INFO = New System.Windows.Forms.ListBox()
        Me.TB_CANTIDAD_ACTUAL = New System.Windows.Forms.TextBox()
        Me.TB_INFO = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.RB_DESCRIPCION = New System.Windows.Forms.RadioButton()
        Me.RB_CODIGO = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TB_CODIGO = New System.Windows.Forms.TextBox()
        Me.TB_ARTICULO = New System.Windows.Forms.TextBox()
        Me.LB_PRESENTACION = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TB_CANTIDAD_VENTA = New System.Windows.Forms.TextBox()
        Me.RB_SALIDA = New System.Windows.Forms.RadioButton()
        Me.RB_ENTRADA = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Articulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BTM_GUARDAR, Me.ToolStripSeparator1, Me.BTM_SALIR})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(855, 70)
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.TB_BODEGA)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TB_PRECIO)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.LB_INFO)
        Me.GroupBox2.Controls.Add(Me.TB_CANTIDAD_ACTUAL)
        Me.GroupBox2.Controls.Add(Me.TB_INFO)
        Me.GroupBox2.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TB_CODIGO)
        Me.GroupBox2.Controls.Add(Me.TB_ARTICULO)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 129)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(247, 402)
        Me.GroupBox2.TabIndex = 56
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Producto"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 74
        Me.Label10.Text = "Bodega"
        '
        'TB_BODEGA
        '
        Me.TB_BODEGA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TB_BODEGA.FormattingEnabled = True
        Me.TB_BODEGA.Location = New System.Drawing.Point(6, 32)
        Me.TB_BODEGA.Name = "TB_BODEGA"
        Me.TB_BODEGA.Size = New System.Drawing.Size(233, 21)
        Me.TB_BODEGA.TabIndex = 73
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(119, 360)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 72
        Me.Label9.Text = "Valor"
        '
        'TB_PRECIO
        '
        Me.TB_PRECIO.Location = New System.Drawing.Point(119, 375)
        Me.TB_PRECIO.Name = "TB_PRECIO"
        Me.TB_PRECIO.Size = New System.Drawing.Size(122, 20)
        Me.TB_PRECIO.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 360)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "Cantidad Actual"
        '
        'LB_INFO
        '
        Me.LB_INFO.FormattingEnabled = True
        Me.LB_INFO.Location = New System.Drawing.Point(6, 115)
        Me.LB_INFO.Name = "LB_INFO"
        Me.LB_INFO.Size = New System.Drawing.Size(223, 160)
        Me.LB_INFO.TabIndex = 69
        '
        'TB_CANTIDAD_ACTUAL
        '
        Me.TB_CANTIDAD_ACTUAL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TB_CANTIDAD_ACTUAL.Location = New System.Drawing.Point(6, 375)
        Me.TB_CANTIDAD_ACTUAL.Name = "TB_CANTIDAD_ACTUAL"
        Me.TB_CANTIDAD_ACTUAL.ReadOnly = True
        Me.TB_CANTIDAD_ACTUAL.Size = New System.Drawing.Size(107, 20)
        Me.TB_CANTIDAD_ACTUAL.TabIndex = 69
        '
        'TB_INFO
        '
        Me.TB_INFO.Location = New System.Drawing.Point(6, 89)
        Me.TB_INFO.Name = "TB_INFO"
        Me.TB_INFO.Size = New System.Drawing.Size(220, 20)
        Me.TB_INFO.TabIndex = 2
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.RB_DESCRIPCION, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.RB_CODIGO, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(9, 56)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(200, 27)
        Me.TableLayoutPanel1.TabIndex = 67
        '
        'RB_DESCRIPCION
        '
        Me.RB_DESCRIPCION.AutoSize = True
        Me.RB_DESCRIPCION.Checked = True
        Me.RB_DESCRIPCION.Location = New System.Drawing.Point(103, 3)
        Me.RB_DESCRIPCION.Name = "RB_DESCRIPCION"
        Me.RB_DESCRIPCION.Size = New System.Drawing.Size(81, 17)
        Me.RB_DESCRIPCION.TabIndex = 68
        Me.RB_DESCRIPCION.TabStop = True
        Me.RB_DESCRIPCION.Text = "Descripción"
        Me.RB_DESCRIPCION.UseVisualStyleBackColor = True
        '
        'RB_CODIGO
        '
        Me.RB_CODIGO.AutoSize = True
        Me.RB_CODIGO.Location = New System.Drawing.Point(3, 3)
        Me.RB_CODIGO.Name = "RB_CODIGO"
        Me.RB_CODIGO.Size = New System.Drawing.Size(58, 17)
        Me.RB_CODIGO.TabIndex = 67
        Me.RB_CODIGO.Text = "Codigo"
        Me.RB_CODIGO.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 278)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Codigo Articulo"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 319)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 13)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Articulo Seleccionado"
        '
        'TB_CODIGO
        '
        Me.TB_CODIGO.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TB_CODIGO.Location = New System.Drawing.Point(6, 293)
        Me.TB_CODIGO.Name = "TB_CODIGO"
        Me.TB_CODIGO.ReadOnly = True
        Me.TB_CODIGO.Size = New System.Drawing.Size(233, 20)
        Me.TB_CODIGO.TabIndex = 69
        '
        'TB_ARTICULO
        '
        Me.TB_ARTICULO.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TB_ARTICULO.Location = New System.Drawing.Point(6, 334)
        Me.TB_ARTICULO.Name = "TB_ARTICULO"
        Me.TB_ARTICULO.ReadOnly = True
        Me.TB_ARTICULO.Size = New System.Drawing.Size(233, 20)
        Me.TB_ARTICULO.TabIndex = 67
        '
        'LB_PRESENTACION
        '
        Me.LB_PRESENTACION.AutoSize = True
        Me.LB_PRESENTACION.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_PRESENTACION.Location = New System.Drawing.Point(270, 565)
        Me.LB_PRESENTACION.Name = "LB_PRESENTACION"
        Me.LB_PRESENTACION.Size = New System.Drawing.Size(102, 20)
        Me.LB_PRESENTACION.TabIndex = 75
        Me.LB_PRESENTACION.Text = "UNIDADES"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(167, 557)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 38)
        Me.Button1.TabIndex = 74
        Me.Button1.Text = "CARGAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(44, 534)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 20)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "Cantidad"
        '
        'TB_CANTIDAD_VENTA
        '
        Me.TB_CANTIDAD_VENTA.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_CANTIDAD_VENTA.Location = New System.Drawing.Point(12, 557)
        Me.TB_CANTIDAD_VENTA.Name = "TB_CANTIDAD_VENTA"
        Me.TB_CANTIDAD_VENTA.Size = New System.Drawing.Size(137, 38)
        Me.TB_CANTIDAD_VENTA.TabIndex = 72
        '
        'RB_SALIDA
        '
        Me.RB_SALIDA.AutoSize = True
        Me.RB_SALIDA.Location = New System.Drawing.Point(18, 105)
        Me.RB_SALIDA.Name = "RB_SALIDA"
        Me.RB_SALIDA.Size = New System.Drawing.Size(54, 17)
        Me.RB_SALIDA.TabIndex = 77
        Me.RB_SALIDA.Text = "Salida"
        Me.RB_SALIDA.UseVisualStyleBackColor = True
        '
        'RB_ENTRADA
        '
        Me.RB_ENTRADA.AutoSize = True
        Me.RB_ENTRADA.Location = New System.Drawing.Point(18, 82)
        Me.RB_ENTRADA.Name = "RB_ENTRADA"
        Me.RB_ENTRADA.Size = New System.Drawing.Size(62, 17)
        Me.RB_ENTRADA.TabIndex = 76
        Me.RB_ENTRADA.Text = "Entrada"
        Me.RB_ENTRADA.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Articulo, Me.Cantidad, Me.Eliminar})
        Me.DataGridView1.Location = New System.Drawing.Point(274, 88)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(569, 395)
        Me.DataGridView1.TabIndex = 78
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        '
        'Articulo
        '
        Me.Articulo.HeaderText = "Articulo"
        Me.Articulo.Name = "Articulo"
        Me.Articulo.ReadOnly = True
        Me.Articulo.Width = 200
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'AJUSTE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 629)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.RB_SALIDA)
        Me.Controls.Add(Me.RB_ENTRADA)
        Me.Controls.Add(Me.LB_PRESENTACION)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TB_CANTIDAD_VENTA)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "AJUSTE"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AJUSTE"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BTM_GUARDAR As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BTM_SALIR As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TB_BODEGA As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TB_PRECIO As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LB_INFO As System.Windows.Forms.ListBox
    Friend WithEvents TB_CANTIDAD_ACTUAL As System.Windows.Forms.TextBox
    Friend WithEvents TB_INFO As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents RB_DESCRIPCION As System.Windows.Forms.RadioButton
    Friend WithEvents RB_CODIGO As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TB_CODIGO As System.Windows.Forms.TextBox
    Friend WithEvents TB_ARTICULO As System.Windows.Forms.TextBox
    Friend WithEvents LB_PRESENTACION As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TB_CANTIDAD_VENTA As System.Windows.Forms.TextBox
    Friend WithEvents RB_SALIDA As System.Windows.Forms.RadioButton
    Friend WithEvents RB_ENTRADA As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Articulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewButtonColumn
End Class
