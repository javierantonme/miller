<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_DEPARTAMENTO = New System.Windows.Forms.ComboBox()
        Me.TB_MUNICIPIO = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TB_TIPO_RETENCION = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TB_TIPO_CONTRI = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TB_NOMBRE_COMPLETO = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TB_S_NOMBRE = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TB_P_NOMBRE = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TB_S_APELLIDO = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TB_P_APELLIDO = New System.Windows.Forms.TextBox()
        Me.TB_DV = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_DOCUMENTO = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TB_TIPO_DOCUMENTO = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_TIPO_PERSONA = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btm_nuevo = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BTM_GUARDAR = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BTM_MODIFICAR = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BTM_SALIR = New System.Windows.Forms.ToolStripButton()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tb_telefono = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.tb_direccion = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(423, 91)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(22, 13)
        Me.Label13.TabIndex = 51
        Me.Label13.Text = "DV"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TB_DEPARTAMENTO)
        Me.GroupBox1.Controls.Add(Me.TB_MUNICIPIO)
        Me.GroupBox1.Location = New System.Drawing.Point(451, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(310, 59)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lugar de Expedicion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Departamento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(160, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Municipio"
        '
        'TB_DEPARTAMENTO
        '
        Me.TB_DEPARTAMENTO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TB_DEPARTAMENTO.FormattingEnabled = True
        Me.TB_DEPARTAMENTO.Location = New System.Drawing.Point(9, 32)
        Me.TB_DEPARTAMENTO.Name = "TB_DEPARTAMENTO"
        Me.TB_DEPARTAMENTO.Size = New System.Drawing.Size(148, 21)
        Me.TB_DEPARTAMENTO.TabIndex = 0
        '
        'TB_MUNICIPIO
        '
        Me.TB_MUNICIPIO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TB_MUNICIPIO.FormattingEnabled = True
        Me.TB_MUNICIPIO.Location = New System.Drawing.Point(163, 32)
        Me.TB_MUNICIPIO.Name = "TB_MUNICIPIO"
        Me.TB_MUNICIPIO.Size = New System.Drawing.Size(141, 21)
        Me.TB_MUNICIPIO.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(199, 220)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 13)
        Me.Label12.TabIndex = 50
        Me.Label12.Text = "Tipo Retencion"
        '
        'TB_TIPO_RETENCION
        '
        Me.TB_TIPO_RETENCION.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TB_TIPO_RETENCION.FormattingEnabled = True
        Me.TB_TIPO_RETENCION.Items.AddRange(New Object() {"EXCENTO DE RETENCION", "HACER RETENCION", "AUTORETENEDOR"})
        Me.TB_TIPO_RETENCION.Location = New System.Drawing.Point(202, 236)
        Me.TB_TIPO_RETENCION.Name = "TB_TIPO_RETENCION"
        Me.TB_TIPO_RETENCION.Size = New System.Drawing.Size(174, 21)
        Me.TB_TIPO_RETENCION.TabIndex = 42
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 221)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(96, 13)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Tipo Contribuyente"
        '
        'TB_TIPO_CONTRI
        '
        Me.TB_TIPO_CONTRI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TB_TIPO_CONTRI.FormattingEnabled = True
        Me.TB_TIPO_CONTRI.Items.AddRange(New Object() {"REGIMEN SIMPLIFICADO", "REGIMEN COMUN", "GRAN CONTRIBUYENTE"})
        Me.TB_TIPO_CONTRI.Location = New System.Drawing.Point(12, 236)
        Me.TB_TIPO_CONTRI.Name = "TB_TIPO_CONTRI"
        Me.TB_TIPO_CONTRI.Size = New System.Drawing.Size(174, 21)
        Me.TB_TIPO_CONTRI.TabIndex = 41
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 176)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 13)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Nombre Completo"
        '
        'TB_NOMBRE_COMPLETO
        '
        Me.TB_NOMBRE_COMPLETO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_NOMBRE_COMPLETO.Location = New System.Drawing.Point(12, 192)
        Me.TB_NOMBRE_COMPLETO.Name = "TB_NOMBRE_COMPLETO"
        Me.TB_NOMBRE_COMPLETO.Size = New System.Drawing.Size(369, 20)
        Me.TB_NOMBRE_COMPLETO.TabIndex = 40
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(584, 135)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 13)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Segundo Nombre"
        '
        'TB_S_NOMBRE
        '
        Me.TB_S_NOMBRE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_S_NOMBRE.Location = New System.Drawing.Point(587, 151)
        Me.TB_S_NOMBRE.Name = "TB_S_NOMBRE"
        Me.TB_S_NOMBRE.Size = New System.Drawing.Size(174, 20)
        Me.TB_S_NOMBRE.TabIndex = 37
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(394, 135)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "Primer Nombre"
        '
        'TB_P_NOMBRE
        '
        Me.TB_P_NOMBRE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_P_NOMBRE.Location = New System.Drawing.Point(397, 151)
        Me.TB_P_NOMBRE.Name = "TB_P_NOMBRE"
        Me.TB_P_NOMBRE.Size = New System.Drawing.Size(174, 20)
        Me.TB_P_NOMBRE.TabIndex = 36
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(204, 135)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 13)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Segundo Apellido"
        '
        'TB_S_APELLIDO
        '
        Me.TB_S_APELLIDO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_S_APELLIDO.Location = New System.Drawing.Point(207, 151)
        Me.TB_S_APELLIDO.Name = "TB_S_APELLIDO"
        Me.TB_S_APELLIDO.Size = New System.Drawing.Size(174, 20)
        Me.TB_S_APELLIDO.TabIndex = 35
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Primer Apellido"
        '
        'TB_P_APELLIDO
        '
        Me.TB_P_APELLIDO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_P_APELLIDO.Location = New System.Drawing.Point(12, 151)
        Me.TB_P_APELLIDO.Name = "TB_P_APELLIDO"
        Me.TB_P_APELLIDO.Size = New System.Drawing.Size(174, 20)
        Me.TB_P_APELLIDO.TabIndex = 33
        '
        'TB_DV
        '
        Me.TB_DV.Location = New System.Drawing.Point(422, 107)
        Me.TB_DV.Name = "TB_DV"
        Me.TB_DV.ReadOnly = True
        Me.TB_DV.Size = New System.Drawing.Size(23, 20)
        Me.TB_DV.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(264, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Numero de Documento"
        '
        'TB_DOCUMENTO
        '
        Me.TB_DOCUMENTO.Location = New System.Drawing.Point(267, 107)
        Me.TB_DOCUMENTO.Name = "TB_DOCUMENTO"
        Me.TB_DOCUMENTO.Size = New System.Drawing.Size(152, 20)
        Me.TB_DOCUMENTO.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(140, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Tipo de Documento"
        '
        'TB_TIPO_DOCUMENTO
        '
        Me.TB_TIPO_DOCUMENTO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TB_TIPO_DOCUMENTO.FormattingEnabled = True
        Me.TB_TIPO_DOCUMENTO.Items.AddRange(New Object() {"CC", "TI", "RC", "CUI", "NIT"})
        Me.TB_TIPO_DOCUMENTO.Location = New System.Drawing.Point(140, 107)
        Me.TB_TIPO_DOCUMENTO.Name = "TB_TIPO_DOCUMENTO"
        Me.TB_TIPO_DOCUMENTO.Size = New System.Drawing.Size(121, 21)
        Me.TB_TIPO_DOCUMENTO.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Tipo de Persona"
        '
        'TB_TIPO_PERSONA
        '
        Me.TB_TIPO_PERSONA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TB_TIPO_PERSONA.FormattingEnabled = True
        Me.TB_TIPO_PERSONA.Items.AddRange(New Object() {"NATURAL", "JURIDICA"})
        Me.TB_TIPO_PERSONA.Location = New System.Drawing.Point(12, 107)
        Me.TB_TIPO_PERSONA.Name = "TB_TIPO_PERSONA"
        Me.TB_TIPO_PERSONA.Size = New System.Drawing.Size(121, 21)
        Me.TB_TIPO_PERSONA.TabIndex = 29
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 294)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(780, 268)
        Me.DataGridView1.TabIndex = 52
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btm_nuevo, Me.ToolStripSeparator2, Me.BTM_GUARDAR, Me.ToolStripSeparator1, Me.BTM_MODIFICAR, Me.ToolStripSeparator3, Me.BTM_SALIR})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(780, 70)
        Me.ToolStrip1.TabIndex = 53
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
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(584, 176)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(49, 13)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = "Telefono"
        '
        'tb_telefono
        '
        Me.tb_telefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tb_telefono.Location = New System.Drawing.Point(587, 192)
        Me.tb_telefono.Name = "tb_telefono"
        Me.tb_telefono.Size = New System.Drawing.Size(174, 20)
        Me.tb_telefono.TabIndex = 55
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(394, 176)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 13)
        Me.Label15.TabIndex = 56
        Me.Label15.Text = "Dirección"
        '
        'tb_direccion
        '
        Me.tb_direccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tb_direccion.Location = New System.Drawing.Point(397, 192)
        Me.tb_direccion.Name = "tb_direccion"
        Me.tb_direccion.Size = New System.Drawing.Size(174, 20)
        Me.tb_direccion.TabIndex = 54
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(780, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.tb_telefono)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.tb_direccion)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TB_TIPO_RETENCION)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TB_TIPO_CONTRI)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TB_NOMBRE_COMPLETO)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TB_S_NOMBRE)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TB_P_NOMBRE)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TB_S_APELLIDO)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TB_P_APELLIDO)
        Me.Controls.Add(Me.TB_DV)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TB_DOCUMENTO)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TB_TIPO_DOCUMENTO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TB_TIPO_PERSONA)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CLIENTES"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TB_DEPARTAMENTO As System.Windows.Forms.ComboBox
    Friend WithEvents TB_MUNICIPIO As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TB_TIPO_RETENCION As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TB_TIPO_CONTRI As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TB_NOMBRE_COMPLETO As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TB_S_NOMBRE As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TB_P_NOMBRE As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TB_S_APELLIDO As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TB_P_APELLIDO As System.Windows.Forms.TextBox
    Friend WithEvents TB_DV As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TB_DOCUMENTO As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TB_TIPO_DOCUMENTO As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TB_TIPO_PERSONA As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btm_nuevo As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BTM_GUARDAR As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BTM_MODIFICAR As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BTM_SALIR As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tb_telefono As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tb_direccion As System.Windows.Forms.TextBox

End Class
