<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FACTURACION
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
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.BT_SALIR = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BT_REMISIONES = New System.Windows.Forms.Button()
        Me.TB_TELEFONO = New System.Windows.Forms.TextBox()
        Me.TB_DIRECCION = New System.Windows.Forms.TextBox()
        Me.TB_NOMBRE = New System.Windows.Forms.TextBox()
        Me.TB_ID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TB_PRECIO = New System.Windows.Forms.TextBox()
        Me.TB_CANTIDAD_ACTUAL = New System.Windows.Forms.TextBox()
        Me.TB_ARTICULO = New System.Windows.Forms.TextBox()
        Me.TB_CODIGO = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LB_INFO = New System.Windows.Forms.ListBox()
        Me.TB_INFO = New System.Windows.Forms.TextBox()
        Me.RB_DESCRIPCION = New System.Windows.Forms.RadioButton()
        Me.RB_CODIGO = New System.Windows.Forms.RadioButton()
        Me.TB_BODEGA = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TB_CANTIDAD_VENTA = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Articulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SubTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.BT_SALIR})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(990, 70)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.FACTURACION.My.Resources.Resources.floppy_disk
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(53, 67)
        Me.ToolStripButton1.Text = "Guardar"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BT_SALIR
        '
        Me.BT_SALIR.Image = Global.FACTURACION.My.Resources.Resources.salir_48_48
        Me.BT_SALIR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BT_SALIR.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BT_SALIR.Name = "BT_SALIR"
        Me.BT_SALIR.Size = New System.Drawing.Size(52, 67)
        Me.BT_SALIR.Text = "Salir"
        Me.BT_SALIR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BT_REMISIONES)
        Me.GroupBox1.Controls.Add(Me.TB_TELEFONO)
        Me.GroupBox1.Controls.Add(Me.TB_DIRECCION)
        Me.GroupBox1.Controls.Add(Me.TB_NOMBRE)
        Me.GroupBox1.Controls.Add(Me.TB_ID)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 83)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(915, 102)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos Personales"
        '
        'BT_REMISIONES
        '
        Me.BT_REMISIONES.Enabled = False
        Me.BT_REMISIONES.Location = New System.Drawing.Point(819, 52)
        Me.BT_REMISIONES.Name = "BT_REMISIONES"
        Me.BT_REMISIONES.Size = New System.Drawing.Size(75, 23)
        Me.BT_REMISIONES.TabIndex = 8
        Me.BT_REMISIONES.Text = "Remisiones"
        Me.BT_REMISIONES.UseVisualStyleBackColor = True
        '
        'TB_TELEFONO
        '
        Me.TB_TELEFONO.Enabled = False
        Me.TB_TELEFONO.Location = New System.Drawing.Point(504, 76)
        Me.TB_TELEFONO.Name = "TB_TELEFONO"
        Me.TB_TELEFONO.Size = New System.Drawing.Size(263, 20)
        Me.TB_TELEFONO.TabIndex = 7
        '
        'TB_DIRECCION
        '
        Me.TB_DIRECCION.Enabled = False
        Me.TB_DIRECCION.Location = New System.Drawing.Point(10, 76)
        Me.TB_DIRECCION.Name = "TB_DIRECCION"
        Me.TB_DIRECCION.Size = New System.Drawing.Size(263, 20)
        Me.TB_DIRECCION.TabIndex = 6
        '
        'TB_NOMBRE
        '
        Me.TB_NOMBRE.Enabled = False
        Me.TB_NOMBRE.Location = New System.Drawing.Point(504, 39)
        Me.TB_NOMBRE.Name = "TB_NOMBRE"
        Me.TB_NOMBRE.Size = New System.Drawing.Size(263, 20)
        Me.TB_NOMBRE.TabIndex = 5
        '
        'TB_ID
        '
        Me.TB_ID.Location = New System.Drawing.Point(10, 37)
        Me.TB_ID.Name = "TB_ID"
        Me.TB_ID.Size = New System.Drawing.Size(263, 20)
        Me.TB_ID.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(501, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nombre del cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Dirección"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(501, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Telefono"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Identificacion"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TB_PRECIO)
        Me.GroupBox2.Controls.Add(Me.TB_CANTIDAD_ACTUAL)
        Me.GroupBox2.Controls.Add(Me.TB_ARTICULO)
        Me.GroupBox2.Controls.Add(Me.TB_CODIGO)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.LB_INFO)
        Me.GroupBox2.Controls.Add(Me.TB_INFO)
        Me.GroupBox2.Controls.Add(Me.RB_DESCRIPCION)
        Me.GroupBox2.Controls.Add(Me.RB_CODIGO)
        Me.GroupBox2.Controls.Add(Me.TB_BODEGA)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 201)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(274, 401)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del producto"
        '
        'TB_PRECIO
        '
        Me.TB_PRECIO.Location = New System.Drawing.Point(127, 350)
        Me.TB_PRECIO.Name = "TB_PRECIO"
        Me.TB_PRECIO.Size = New System.Drawing.Size(100, 20)
        Me.TB_PRECIO.TabIndex = 13
        '
        'TB_CANTIDAD_ACTUAL
        '
        Me.TB_CANTIDAD_ACTUAL.Enabled = False
        Me.TB_CANTIDAD_ACTUAL.Location = New System.Drawing.Point(13, 350)
        Me.TB_CANTIDAD_ACTUAL.Name = "TB_CANTIDAD_ACTUAL"
        Me.TB_CANTIDAD_ACTUAL.Size = New System.Drawing.Size(100, 20)
        Me.TB_CANTIDAD_ACTUAL.TabIndex = 12
        '
        'TB_ARTICULO
        '
        Me.TB_ARTICULO.Enabled = False
        Me.TB_ARTICULO.Location = New System.Drawing.Point(13, 306)
        Me.TB_ARTICULO.Name = "TB_ARTICULO"
        Me.TB_ARTICULO.Size = New System.Drawing.Size(100, 20)
        Me.TB_ARTICULO.TabIndex = 11
        '
        'TB_CODIGO
        '
        Me.TB_CODIGO.Enabled = False
        Me.TB_CODIGO.Location = New System.Drawing.Point(13, 260)
        Me.TB_CODIGO.Name = "TB_CODIGO"
        Me.TB_CODIGO.Size = New System.Drawing.Size(100, 20)
        Me.TB_CODIGO.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(124, 333)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Valor"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 289)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Articulo seleccionado"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 333)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Cantidad actual"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 243)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Codigo articulo"
        '
        'LB_INFO
        '
        Me.LB_INFO.FormattingEnabled = True
        Me.LB_INFO.Location = New System.Drawing.Point(10, 115)
        Me.LB_INFO.Name = "LB_INFO"
        Me.LB_INFO.Size = New System.Drawing.Size(226, 121)
        Me.LB_INFO.TabIndex = 5
        '
        'TB_INFO
        '
        Me.TB_INFO.Location = New System.Drawing.Point(10, 88)
        Me.TB_INFO.Name = "TB_INFO"
        Me.TB_INFO.Size = New System.Drawing.Size(226, 20)
        Me.TB_INFO.TabIndex = 4
        '
        'RB_DESCRIPCION
        '
        Me.RB_DESCRIPCION.AutoSize = True
        Me.RB_DESCRIPCION.Location = New System.Drawing.Point(120, 64)
        Me.RB_DESCRIPCION.Name = "RB_DESCRIPCION"
        Me.RB_DESCRIPCION.Size = New System.Drawing.Size(81, 17)
        Me.RB_DESCRIPCION.TabIndex = 3
        Me.RB_DESCRIPCION.Text = "Descripcion"
        Me.RB_DESCRIPCION.UseVisualStyleBackColor = True
        '
        'RB_CODIGO
        '
        Me.RB_CODIGO.AutoSize = True
        Me.RB_CODIGO.Checked = True
        Me.RB_CODIGO.Location = New System.Drawing.Point(10, 64)
        Me.RB_CODIGO.Name = "RB_CODIGO"
        Me.RB_CODIGO.Size = New System.Drawing.Size(58, 17)
        Me.RB_CODIGO.TabIndex = 2
        Me.RB_CODIGO.TabStop = True
        Me.RB_CODIGO.Text = "Codigo"
        Me.RB_CODIGO.UseVisualStyleBackColor = True
        '
        'TB_BODEGA
        '
        Me.TB_BODEGA.FormattingEnabled = True
        Me.TB_BODEGA.Location = New System.Drawing.Point(10, 37)
        Me.TB_BODEGA.Name = "TB_BODEGA"
        Me.TB_BODEGA.Size = New System.Drawing.Size(121, 21)
        Me.TB_BODEGA.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Bodega"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(36, 609)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Cantidad"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(179, 640)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Cargar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TB_CANTIDAD_VENTA
        '
        Me.TB_CANTIDAD_VENTA.Location = New System.Drawing.Point(39, 640)
        Me.TB_CANTIDAD_VENTA.Name = "TB_CANTIDAD_VENTA"
        Me.TB_CANTIDAD_VENTA.Size = New System.Drawing.Size(121, 20)
        Me.TB_CANTIDAD_VENTA.TabIndex = 8
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(323, 184)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(655, 236)
        Me.DataGridView1.TabIndex = 9
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Articulo, Me.Cant, Me.ValorUnit, Me.SubTotal, Me.Eliminar})
        Me.DataGridView2.Location = New System.Drawing.Point(323, 444)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(655, 236)
        Me.DataGridView2.TabIndex = 71
        '
        'Codigo
        '
        Me.Codigo.Frozen = True
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.Width = 75
        '
        'Articulo
        '
        Me.Articulo.Frozen = True
        Me.Articulo.HeaderText = "Articulo"
        Me.Articulo.Name = "Articulo"
        Me.Articulo.Width = 175
        '
        'Cant
        '
        Me.Cant.Frozen = True
        Me.Cant.HeaderText = "Cant"
        Me.Cant.Name = "Cant"
        Me.Cant.Width = 150
        '
        'ValorUnit
        '
        Me.ValorUnit.Frozen = True
        Me.ValorUnit.HeaderText = "Valor Unit"
        Me.ValorUnit.Name = "ValorUnit"
        Me.ValorUnit.Width = 75
        '
        'SubTotal
        '
        Me.SubTotal.Frozen = True
        Me.SubTotal.HeaderText = "Sub Total"
        Me.SubTotal.Name = "SubTotal"
        Me.SubTotal.Width = 75
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Width = 75
        '
        'FACTURACION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(990, 714)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.TB_CANTIDAD_VENTA)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "FACTURACION"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FACTURACION"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents BT_SALIR As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TB_TELEFONO As System.Windows.Forms.TextBox
    Friend WithEvents TB_DIRECCION As System.Windows.Forms.TextBox
    Friend WithEvents TB_NOMBRE As System.Windows.Forms.TextBox
    Friend WithEvents TB_ID As System.Windows.Forms.TextBox
    Friend WithEvents BT_REMISIONES As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents TB_BODEGA As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RB_DESCRIPCION As System.Windows.Forms.RadioButton
    Friend WithEvents RB_CODIGO As System.Windows.Forms.RadioButton
    Friend WithEvents LB_INFO As System.Windows.Forms.ListBox
    Friend WithEvents TB_INFO As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TB_PRECIO As System.Windows.Forms.TextBox
    Friend WithEvents TB_CANTIDAD_ACTUAL As System.Windows.Forms.TextBox
    Friend WithEvents TB_ARTICULO As System.Windows.Forms.TextBox
    Friend WithEvents TB_CODIGO As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TB_CANTIDAD_VENTA As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Articulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cant As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ValorUnit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SubTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Eliminar As System.Windows.Forms.DataGridViewButtonColumn
End Class
