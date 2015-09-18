<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DEVOLUCION2
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TB_CODIGO = New System.Windows.Forms.TextBox()
        Me.TB_ARTICULO = New System.Windows.Forms.TextBox()
        Me.TB_CANTIDAD = New System.Windows.Forms.TextBox()
        Me.TB_dEVOLUCION = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_NUMERO_REM = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(274, 118)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(446, 242)
        Me.DataGridView1.TabIndex = 0
        '
        'TB_CODIGO
        '
        Me.TB_CODIGO.Location = New System.Drawing.Point(13, 175)
        Me.TB_CODIGO.Name = "TB_CODIGO"
        Me.TB_CODIGO.ReadOnly = True
        Me.TB_CODIGO.Size = New System.Drawing.Size(114, 20)
        Me.TB_CODIGO.TabIndex = 1
        '
        'TB_ARTICULO
        '
        Me.TB_ARTICULO.Location = New System.Drawing.Point(13, 217)
        Me.TB_ARTICULO.Name = "TB_ARTICULO"
        Me.TB_ARTICULO.ReadOnly = True
        Me.TB_ARTICULO.Size = New System.Drawing.Size(236, 20)
        Me.TB_ARTICULO.TabIndex = 2
        '
        'TB_CANTIDAD
        '
        Me.TB_CANTIDAD.Location = New System.Drawing.Point(13, 257)
        Me.TB_CANTIDAD.Name = "TB_CANTIDAD"
        Me.TB_CANTIDAD.ReadOnly = True
        Me.TB_CANTIDAD.Size = New System.Drawing.Size(236, 20)
        Me.TB_CANTIDAD.TabIndex = 3
        '
        'TB_dEVOLUCION
        '
        Me.TB_dEVOLUCION.Location = New System.Drawing.Point(13, 300)
        Me.TB_dEVOLUCION.Name = "TB_dEVOLUCION"
        Me.TB_dEVOLUCION.Size = New System.Drawing.Size(114, 20)
        Me.TB_dEVOLUCION.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(175, 337)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Devolver"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Codigo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Articulo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Cantidad"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 284)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Devolucion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Numero de Remision"
        '
        'TB_NUMERO_REM
        '
        Me.TB_NUMERO_REM.Location = New System.Drawing.Point(12, 104)
        Me.TB_NUMERO_REM.Name = "TB_NUMERO_REM"
        Me.TB_NUMERO_REM.ReadOnly = True
        Me.TB_NUMERO_REM.Size = New System.Drawing.Size(114, 20)
        Me.TB_NUMERO_REM.TabIndex = 10
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator3, Me.ToolStripButton4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(723, 70)
        Me.ToolStrip1.TabIndex = 12
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
        'DEVOLUCION2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(723, 391)
        Me.ControlBox = False
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TB_NUMERO_REM)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TB_dEVOLUCION)
        Me.Controls.Add(Me.TB_CANTIDAD)
        Me.Controls.Add(Me.TB_ARTICULO)
        Me.Controls.Add(Me.TB_CODIGO)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "DEVOLUCION2"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DEVOLUCION"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TB_CODIGO As System.Windows.Forms.TextBox
    Friend WithEvents TB_ARTICULO As System.Windows.Forms.TextBox
    Friend WithEvents TB_CANTIDAD As System.Windows.Forms.TextBox
    Friend WithEvents TB_dEVOLUCION As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TB_NUMERO_REM As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
End Class
