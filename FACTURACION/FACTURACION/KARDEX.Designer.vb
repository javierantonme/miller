<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KARDEX
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
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TB_COMBO_FOLTRO = New System.Windows.Forms.ComboBox()
        Me.TB_INFO_FILTRO = New System.Windows.Forms.TextBox()
        Me.RB_TIPO = New System.Windows.Forms.RadioButton()
        Me.RB_NOMBRE = New System.Windows.Forms.RadioButton()
        Me.RB_CODIGO = New System.Windows.Forms.RadioButton()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator3, Me.ToolStripButton4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(761, 70)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 70)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = Global.FACTURACION.My.Resources.Resources.salir_48_48
        Me.ToolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(52, 67)
        Me.ToolStripButton4.Text = "Salir"
        Me.ToolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 189)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(761, 291)
        Me.DataGridView1.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.TB_COMBO_FOLTRO)
        Me.GroupBox1.Controls.Add(Me.TB_INFO_FILTRO)
        Me.GroupBox1.Controls.Add(Me.RB_TIPO)
        Me.GroupBox1.Controls.Add(Me.RB_NOMBRE)
        Me.GroupBox1.Controls.Add(Me.RB_CODIGO)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(475, 100)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro de Busqueda"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(347, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TB_COMBO_FOLTRO
        '
        Me.TB_COMBO_FOLTRO.FormattingEnabled = True
        Me.TB_COMBO_FOLTRO.Items.AddRange(New Object() {"INGRESO A INVENTARIO", "SALIDA POR REMISION", "ENTRADA POR DEVOLUCION"})
        Me.TB_COMBO_FOLTRO.Location = New System.Drawing.Point(113, 20)
        Me.TB_COMBO_FOLTRO.Name = "TB_COMBO_FOLTRO"
        Me.TB_COMBO_FOLTRO.Size = New System.Drawing.Size(207, 21)
        Me.TB_COMBO_FOLTRO.TabIndex = 4
        Me.TB_COMBO_FOLTRO.Visible = False
        '
        'TB_INFO_FILTRO
        '
        Me.TB_INFO_FILTRO.Location = New System.Drawing.Point(113, 20)
        Me.TB_INFO_FILTRO.Name = "TB_INFO_FILTRO"
        Me.TB_INFO_FILTRO.Size = New System.Drawing.Size(207, 20)
        Me.TB_INFO_FILTRO.TabIndex = 3
        '
        'RB_TIPO
        '
        Me.RB_TIPO.AutoSize = True
        Me.RB_TIPO.Location = New System.Drawing.Point(22, 66)
        Me.RB_TIPO.Name = "RB_TIPO"
        Me.RB_TIPO.Size = New System.Drawing.Size(46, 17)
        Me.RB_TIPO.TabIndex = 2
        Me.RB_TIPO.TabStop = True
        Me.RB_TIPO.Text = "Tipo"
        Me.RB_TIPO.UseVisualStyleBackColor = True
        '
        'RB_NOMBRE
        '
        Me.RB_NOMBRE.AutoSize = True
        Me.RB_NOMBRE.Location = New System.Drawing.Point(22, 43)
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
        Me.RB_CODIGO.Checked = True
        Me.RB_CODIGO.Location = New System.Drawing.Point(22, 20)
        Me.RB_CODIGO.Name = "RB_CODIGO"
        Me.RB_CODIGO.Size = New System.Drawing.Size(58, 17)
        Me.RB_CODIGO.TabIndex = 0
        Me.RB_CODIGO.TabStop = True
        Me.RB_CODIGO.Text = "Codigo"
        Me.RB_CODIGO.UseVisualStyleBackColor = True
        '
        'KARDEX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(761, 478)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "KARDEX"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KARDEX"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TB_COMBO_FOLTRO As System.Windows.Forms.ComboBox
    Friend WithEvents TB_INFO_FILTRO As System.Windows.Forms.TextBox
    Friend WithEvents RB_TIPO As System.Windows.Forms.RadioButton
    Friend WithEvents RB_NOMBRE As System.Windows.Forms.RadioButton
    Friend WithEvents RB_CODIGO As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
