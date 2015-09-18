<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DEVOLUCION_REM
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lb2 = New System.Windows.Forms.Label()
        Me.lb1 = New System.Windows.Forms.Label()
        Me.TB_fECHA2 = New System.Windows.Forms.DateTimePicker()
        Me.TB_fECHA1 = New System.Windows.Forms.DateTimePicker()
        Me.BTM_BUSCAR = New System.Windows.Forms.Button()
        Me.TB_FILTRO_INFO = New System.Windows.Forms.TextBox()
        Me.RB_FECHA = New System.Windows.Forms.RadioButton()
        Me.RB_CIENTE = New System.Windows.Forms.RadioButton()
        Me.RB_IDENTIFICACION = New System.Windows.Forms.RadioButton()
        Me.RB_CONSECUTIVO = New System.Windows.Forms.RadioButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 476)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(704, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 239)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(704, 237)
        Me.DataGridView1.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton3, Me.ToolStripSeparator2, Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripButton2, Me.ToolStripSeparator3, Me.ToolStripButton4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(704, 70)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 70)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lb2)
        Me.GroupBox1.Controls.Add(Me.lb1)
        Me.GroupBox1.Controls.Add(Me.TB_fECHA2)
        Me.GroupBox1.Controls.Add(Me.TB_fECHA1)
        Me.GroupBox1.Controls.Add(Me.BTM_BUSCAR)
        Me.GroupBox1.Controls.Add(Me.TB_FILTRO_INFO)
        Me.GroupBox1.Controls.Add(Me.RB_FECHA)
        Me.GroupBox1.Controls.Add(Me.RB_CIENTE)
        Me.GroupBox1.Controls.Add(Me.RB_IDENTIFICACION)
        Me.GroupBox1.Controls.Add(Me.RB_CONSECUTIVO)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(442, 125)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro de Busqueda"
        '
        'lb2
        '
        Me.lb2.AutoSize = True
        Me.lb2.Location = New System.Drawing.Point(111, 59)
        Me.lb2.Name = "lb2"
        Me.lb2.Size = New System.Drawing.Size(35, 13)
        Me.lb2.TabIndex = 9
        Me.lb2.Text = "Hasta"
        Me.lb2.Visible = False
        '
        'lb1
        '
        Me.lb1.AutoSize = True
        Me.lb1.Location = New System.Drawing.Point(114, 11)
        Me.lb1.Name = "lb1"
        Me.lb1.Size = New System.Drawing.Size(38, 13)
        Me.lb1.TabIndex = 8
        Me.lb1.Text = "Desde"
        Me.lb1.Visible = False
        '
        'TB_fECHA2
        '
        Me.TB_fECHA2.Location = New System.Drawing.Point(114, 75)
        Me.TB_fECHA2.Name = "TB_fECHA2"
        Me.TB_fECHA2.Size = New System.Drawing.Size(200, 20)
        Me.TB_fECHA2.TabIndex = 7
        Me.TB_fECHA2.Visible = False
        '
        'TB_fECHA1
        '
        Me.TB_fECHA1.Location = New System.Drawing.Point(114, 28)
        Me.TB_fECHA1.Name = "TB_fECHA1"
        Me.TB_fECHA1.Size = New System.Drawing.Size(200, 20)
        Me.TB_fECHA1.TabIndex = 6
        Me.TB_fECHA1.Visible = False
        '
        'BTM_BUSCAR
        '
        Me.BTM_BUSCAR.Location = New System.Drawing.Point(348, 25)
        Me.BTM_BUSCAR.Name = "BTM_BUSCAR"
        Me.BTM_BUSCAR.Size = New System.Drawing.Size(75, 23)
        Me.BTM_BUSCAR.TabIndex = 5
        Me.BTM_BUSCAR.Text = "Buscar"
        Me.BTM_BUSCAR.UseVisualStyleBackColor = True
        '
        'TB_FILTRO_INFO
        '
        Me.TB_FILTRO_INFO.Location = New System.Drawing.Point(114, 27)
        Me.TB_FILTRO_INFO.Name = "TB_FILTRO_INFO"
        Me.TB_FILTRO_INFO.Size = New System.Drawing.Size(228, 20)
        Me.TB_FILTRO_INFO.TabIndex = 4
        '
        'RB_FECHA
        '
        Me.RB_FECHA.AutoSize = True
        Me.RB_FECHA.Location = New System.Drawing.Point(7, 89)
        Me.RB_FECHA.Name = "RB_FECHA"
        Me.RB_FECHA.Size = New System.Drawing.Size(55, 17)
        Me.RB_FECHA.TabIndex = 3
        Me.RB_FECHA.Text = "Fecha"
        Me.RB_FECHA.UseVisualStyleBackColor = True
        '
        'RB_CIENTE
        '
        Me.RB_CIENTE.AutoSize = True
        Me.RB_CIENTE.Location = New System.Drawing.Point(7, 66)
        Me.RB_CIENTE.Name = "RB_CIENTE"
        Me.RB_CIENTE.Size = New System.Drawing.Size(57, 17)
        Me.RB_CIENTE.TabIndex = 2
        Me.RB_CIENTE.Text = "Cliente"
        Me.RB_CIENTE.UseVisualStyleBackColor = True
        '
        'RB_IDENTIFICACION
        '
        Me.RB_IDENTIFICACION.AutoSize = True
        Me.RB_IDENTIFICACION.Location = New System.Drawing.Point(7, 43)
        Me.RB_IDENTIFICACION.Name = "RB_IDENTIFICACION"
        Me.RB_IDENTIFICACION.Size = New System.Drawing.Size(88, 17)
        Me.RB_IDENTIFICACION.TabIndex = 1
        Me.RB_IDENTIFICACION.Text = "Identificacion"
        Me.RB_IDENTIFICACION.UseVisualStyleBackColor = True
        '
        'RB_CONSECUTIVO
        '
        Me.RB_CONSECUTIVO.AutoSize = True
        Me.RB_CONSECUTIVO.Checked = True
        Me.RB_CONSECUTIVO.Location = New System.Drawing.Point(7, 20)
        Me.RB_CONSECUTIVO.Name = "RB_CONSECUTIVO"
        Me.RB_CONSECUTIVO.Size = New System.Drawing.Size(85, 17)
        Me.RB_CONSECUTIVO.TabIndex = 0
        Me.RB_CONSECUTIVO.TabStop = True
        Me.RB_CONSECUTIVO.Text = "Concecutivo"
        Me.RB_CONSECUTIVO.UseVisualStyleBackColor = True
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 70)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 70)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = Global.FACTURACION.My.Resources.Resources.page_add
        Me.ToolStripButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(52, 67)
        Me.ToolStripButton3.Text = "Nuevo"
        Me.ToolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.FACTURACION.My.Resources.Resources.printer1
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(57, 67)
        Me.ToolStripButton1.Text = "Imprimir"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.FACTURACION.My.Resources.Resources.repeat1
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(71, 67)
        Me.ToolStripButton2.Text = "Devolución"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'DEVOLUCION_REM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 498)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Name = "DEVOLUCION_REM"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DEVOLUCION"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TB_fECHA1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents BTM_BUSCAR As System.Windows.Forms.Button
    Friend WithEvents TB_FILTRO_INFO As System.Windows.Forms.TextBox
    Friend WithEvents RB_FECHA As System.Windows.Forms.RadioButton
    Friend WithEvents RB_CIENTE As System.Windows.Forms.RadioButton
    Friend WithEvents RB_IDENTIFICACION As System.Windows.Forms.RadioButton
    Friend WithEvents RB_CONSECUTIVO As System.Windows.Forms.RadioButton
    Friend WithEvents TB_fECHA2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lb2 As System.Windows.Forms.Label
    Friend WithEvents lb1 As System.Windows.Forms.Label
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
End Class
