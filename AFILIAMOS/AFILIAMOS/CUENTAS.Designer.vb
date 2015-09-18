<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CUENTAS
    Inherits Telerik.WinControls.UI.RadRibbonForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CUENTAS))
        Dim RadListDataItem1 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem2 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.RadRibbonBar1 = New Telerik.WinControls.UI.RadRibbonBar()
        Me.RibbonTab1 = New Telerik.WinControls.UI.RibbonTab()
        Me.RadRibbonBarGroup1 = New Telerik.WinControls.UI.RadRibbonBarGroup()
        Me.BTM_NUEVO = New Telerik.WinControls.UI.RadButtonElement()
        Me.BTM_GUARDAR = New Telerik.WinControls.UI.RadButtonElement()
        Me.RadRibbonBarGroup2 = New Telerik.WinControls.UI.RadRibbonBarGroup()
        Me.BTM_SALIR = New Telerik.WinControls.UI.RadButtonElement()
        Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadGridView1 = New Telerik.WinControls.UI.RadGridView()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.TB_VALOR_SOBREGIRO = New Telerik.WinControls.UI.RadTextBox()
        Me.CH_SOBREGURO = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.TB_SALDO_INICIAL = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.TB_NUMERO_CUENTA = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.TB_TIPO_CUENTA = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.TB_BANCO = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.TB_CODIGO = New Telerik.WinControls.UI.RadTextBox()
        CType(Me.RadRibbonBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TB_VALOR_SOBREGIRO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CH_SOBREGURO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TB_SALDO_INICIAL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TB_NUMERO_CUENTA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TB_TIPO_CUENTA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TB_BANCO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TB_BANCO.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TB_BANCO.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TB_CODIGO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadRibbonBar1
        '
        Me.RadRibbonBar1.CloseButton = False
        Me.RadRibbonBar1.CommandTabs.AddRange(New Telerik.WinControls.RadItem() {Me.RibbonTab1})
        Me.RadRibbonBar1.Location = New System.Drawing.Point(0, 0)
        Me.RadRibbonBar1.MaximizeButton = False
        Me.RadRibbonBar1.Name = "RadRibbonBar1"
        '
        '
        '
        Me.RadRibbonBar1.RootElement.AutoSizeMode = Telerik.WinControls.RadAutoSizeMode.WrapAroundChildren
        Me.RadRibbonBar1.Size = New System.Drawing.Size(592, 165)
        Me.RadRibbonBar1.StartButtonImage = CType(resources.GetObject("RadRibbonBar1.StartButtonImage"), System.Drawing.Image)
        Me.RadRibbonBar1.TabIndex = 0
        Me.RadRibbonBar1.Text = "CUENTAS BANCARIAS"
        '
        'RibbonTab1
        '
        Me.RibbonTab1.AccessibleDescription = "Archivo"
        Me.RibbonTab1.AccessibleName = "Archivo"
        Me.RibbonTab1.IsSelected = True
        Me.RibbonTab1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.RadRibbonBarGroup1, Me.RadRibbonBarGroup2})
        Me.RibbonTab1.Name = "RibbonTab1"
        Me.RibbonTab1.Text = "Archivo"
        Me.RibbonTab1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadRibbonBarGroup1
        '
        Me.RadRibbonBarGroup1.AccessibleDescription = "Edicion"
        Me.RadRibbonBarGroup1.AccessibleName = "Edicion"
        Me.RadRibbonBarGroup1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.BTM_NUEVO, Me.BTM_GUARDAR})
        Me.RadRibbonBarGroup1.Name = "RadRibbonBarGroup1"
        Me.RadRibbonBarGroup1.Text = "Edicion"
        Me.RadRibbonBarGroup1.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'BTM_NUEVO
        '
        Me.BTM_NUEVO.AccessibleDescription = "Nuevo"
        Me.BTM_NUEVO.AccessibleName = "Nuevo"
        Me.BTM_NUEVO.Image = Global.AFILIAMOS.My.Resources.Resources.page_add
        Me.BTM_NUEVO.Name = "BTM_NUEVO"
        Me.BTM_NUEVO.Text = "Nuevo"
        Me.BTM_NUEVO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTM_NUEVO.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'BTM_GUARDAR
        '
        Me.BTM_GUARDAR.AccessibleDescription = "Guardar"
        Me.BTM_GUARDAR.AccessibleName = "Guardar"
        Me.BTM_GUARDAR.Image = Global.AFILIAMOS.My.Resources.Resources.floppy_disk
        Me.BTM_GUARDAR.Name = "BTM_GUARDAR"
        Me.BTM_GUARDAR.Text = "Guardar"
        Me.BTM_GUARDAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTM_GUARDAR.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadRibbonBarGroup2
        '
        Me.RadRibbonBarGroup2.AccessibleDescription = "Salir"
        Me.RadRibbonBarGroup2.AccessibleName = "Salir"
        Me.RadRibbonBarGroup2.Items.AddRange(New Telerik.WinControls.RadItem() {Me.BTM_SALIR})
        Me.RadRibbonBarGroup2.Name = "RadRibbonBarGroup2"
        Me.RadRibbonBarGroup2.Text = "Salir"
        Me.RadRibbonBarGroup2.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'BTM_SALIR
        '
        Me.BTM_SALIR.AccessibleDescription = "Salir"
        Me.BTM_SALIR.AccessibleName = "Salir"
        Me.BTM_SALIR.Image = Global.AFILIAMOS.My.Resources.Resources.salir_48_48
        Me.BTM_SALIR.Name = "BTM_SALIR"
        Me.BTM_SALIR.Text = "Salir"
        Me.BTM_SALIR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTM_SALIR.Visibility = Telerik.WinControls.ElementVisibility.Visible
        '
        'RadStatusStrip1
        '
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 525)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Size = New System.Drawing.Size(592, 24)
        Me.RadStatusStrip1.SizingGrip = False
        Me.RadStatusStrip1.TabIndex = 1
        Me.RadStatusStrip1.Text = "RadStatusStrip1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RadGridView1)
        Me.Panel1.Controls.Add(Me.RadLabel6)
        Me.Panel1.Controls.Add(Me.TB_VALOR_SOBREGIRO)
        Me.Panel1.Controls.Add(Me.CH_SOBREGURO)
        Me.Panel1.Controls.Add(Me.RadLabel5)
        Me.Panel1.Controls.Add(Me.TB_SALDO_INICIAL)
        Me.Panel1.Controls.Add(Me.RadLabel4)
        Me.Panel1.Controls.Add(Me.TB_NUMERO_CUENTA)
        Me.Panel1.Controls.Add(Me.RadLabel3)
        Me.Panel1.Controls.Add(Me.TB_TIPO_CUENTA)
        Me.Panel1.Controls.Add(Me.RadLabel2)
        Me.Panel1.Controls.Add(Me.TB_BANCO)
        Me.Panel1.Controls.Add(Me.RadLabel1)
        Me.Panel1.Controls.Add(Me.TB_CODIGO)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 165)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(592, 360)
        Me.Panel1.TabIndex = 2
        '
        'RadGridView1
        '
        Me.RadGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RadGridView1.Location = New System.Drawing.Point(0, 149)
        '
        'RadGridView1
        '
        Me.RadGridView1.MasterTemplate.AllowAddNewRow = False
        Me.RadGridView1.MasterTemplate.AllowColumnReorder = False
        Me.RadGridView1.Name = "RadGridView1"
        Me.RadGridView1.ReadOnly = True
        Me.RadGridView1.Size = New System.Drawing.Size(592, 211)
        Me.RadGridView1.TabIndex = 12
        Me.RadGridView1.Text = "RadGridView1"
        '
        'RadLabel6
        '
        Me.RadLabel6.Location = New System.Drawing.Point(102, 86)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(85, 18)
        Me.RadLabel6.TabIndex = 11
        Me.RadLabel6.Text = "Valor Sobregiro"
        '
        'TB_VALOR_SOBREGIRO
        '
        Me.TB_VALOR_SOBREGIRO.Location = New System.Drawing.Point(102, 106)
        Me.TB_VALOR_SOBREGIRO.Name = "TB_VALOR_SOBREGIRO"
        Me.TB_VALOR_SOBREGIRO.Size = New System.Drawing.Size(132, 20)
        Me.TB_VALOR_SOBREGIRO.TabIndex = 10
        Me.TB_VALOR_SOBREGIRO.Text = "0"
        '
        'CH_SOBREGURO
        '
        Me.CH_SOBREGURO.Location = New System.Drawing.Point(12, 106)
        Me.CH_SOBREGURO.Name = "CH_SOBREGURO"
        Me.CH_SOBREGURO.Size = New System.Drawing.Size(69, 18)
        Me.CH_SOBREGURO.TabIndex = 9
        Me.CH_SOBREGURO.Text = "Sobregiro"
        '
        'RadLabel5
        '
        Me.RadLabel5.Location = New System.Drawing.Point(431, 44)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(66, 18)
        Me.RadLabel5.TabIndex = 8
        Me.RadLabel5.Text = "Saldo Inicial"
        '
        'TB_SALDO_INICIAL
        '
        Me.TB_SALDO_INICIAL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_SALDO_INICIAL.Location = New System.Drawing.Point(431, 64)
        Me.TB_SALDO_INICIAL.Name = "TB_SALDO_INICIAL"
        Me.TB_SALDO_INICIAL.Size = New System.Drawing.Size(158, 20)
        Me.TB_SALDO_INICIAL.TabIndex = 7
        '
        'RadLabel4
        '
        Me.RadLabel4.Location = New System.Drawing.Point(13, 44)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(101, 18)
        Me.RadLabel4.TabIndex = 6
        Me.RadLabel4.Text = "Numero de Cuenta"
        '
        'TB_NUMERO_CUENTA
        '
        Me.TB_NUMERO_CUENTA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_NUMERO_CUENTA.Location = New System.Drawing.Point(13, 64)
        Me.TB_NUMERO_CUENTA.Name = "TB_NUMERO_CUENTA"
        Me.TB_NUMERO_CUENTA.Size = New System.Drawing.Size(397, 20)
        Me.TB_NUMERO_CUENTA.TabIndex = 5
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(431, 2)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(82, 18)
        Me.RadLabel3.TabIndex = 4
        Me.RadLabel3.Text = "Tipo de Cuenta"
        '
        'TB_TIPO_CUENTA
        '
        Me.TB_TIPO_CUENTA.AllowShowFocusCues = False
        Me.TB_TIPO_CUENTA.AutoCompleteDisplayMember = Nothing
        Me.TB_TIPO_CUENTA.AutoCompleteValueMember = Nothing
        RadListDataItem1.Text = "CUENTA DE AHORROS"
        RadListDataItem1.TextWrap = True
        RadListDataItem2.Text = "CUENTA CORRIENTE"
        RadListDataItem2.TextWrap = True
        Me.TB_TIPO_CUENTA.Items.Add(RadListDataItem1)
        Me.TB_TIPO_CUENTA.Items.Add(RadListDataItem2)
        Me.TB_TIPO_CUENTA.Location = New System.Drawing.Point(431, 21)
        Me.TB_TIPO_CUENTA.Name = "TB_TIPO_CUENTA"
        Me.TB_TIPO_CUENTA.Size = New System.Drawing.Size(158, 20)
        Me.TB_TIPO_CUENTA.TabIndex = 3
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(167, 1)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(37, 18)
        Me.RadLabel2.TabIndex = 2
        Me.RadLabel2.Text = "Banco"
        '
        'TB_BANCO
        '
        '
        'TB_BANCO.NestedRadGridView
        '
        Me.TB_BANCO.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.TB_BANCO.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_BANCO.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TB_BANCO.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        'TB_BANCO.NestedRadGridView
        '
        Me.TB_BANCO.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.TB_BANCO.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.TB_BANCO.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.TB_BANCO.EditorControl.MasterTemplate.EnableGrouping = False
        Me.TB_BANCO.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.TB_BANCO.EditorControl.Name = "NestedRadGridView"
        Me.TB_BANCO.EditorControl.ReadOnly = True
        Me.TB_BANCO.EditorControl.ShowGroupPanel = False
        Me.TB_BANCO.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.TB_BANCO.EditorControl.TabIndex = 0
        Me.TB_BANCO.Location = New System.Drawing.Point(163, 21)
        Me.TB_BANCO.Name = "TB_BANCO"
        Me.TB_BANCO.Size = New System.Drawing.Size(247, 20)
        Me.TB_BANCO.TabIndex = 2
        Me.TB_BANCO.TabStop = False
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(13, 2)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(43, 18)
        Me.RadLabel1.TabIndex = 1
        Me.RadLabel1.Text = "Codigo"
        '
        'TB_CODIGO
        '
        Me.TB_CODIGO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_CODIGO.Location = New System.Drawing.Point(13, 22)
        Me.TB_CODIGO.Name = "TB_CODIGO"
        Me.TB_CODIGO.Size = New System.Drawing.Size(132, 20)
        Me.TB_CODIGO.TabIndex = 0
        '
        'CUENTAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 549)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Controls.Add(Me.RadRibbonBar1)
        Me.MaximumSize = New System.Drawing.Size(600, 554)
        Me.MinimumSize = New System.Drawing.Size(600, 554)
        Me.Name = "CUENTAS"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.RootElement.MaxSize = New System.Drawing.Size(600, 554)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CUENTAS BANCARIAS"
        CType(Me.RadRibbonBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TB_VALOR_SOBREGIRO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CH_SOBREGURO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TB_SALDO_INICIAL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TB_NUMERO_CUENTA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TB_TIPO_CUENTA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TB_BANCO.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TB_BANCO.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TB_BANCO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TB_CODIGO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadRibbonBar1 As Telerik.WinControls.UI.RadRibbonBar
    Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RibbonTab1 As Telerik.WinControls.UI.RibbonTab
    Friend WithEvents RadRibbonBarGroup1 As Telerik.WinControls.UI.RadRibbonBarGroup
    Friend WithEvents BTM_NUEVO As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents BTM_GUARDAR As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RadRibbonBarGroup2 As Telerik.WinControls.UI.RadRibbonBarGroup
    Friend WithEvents BTM_SALIR As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RadGridView1 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TB_VALOR_SOBREGIRO As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents CH_SOBREGURO As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TB_SALDO_INICIAL As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TB_NUMERO_CUENTA As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TB_TIPO_CUENTA As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TB_BANCO As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TB_CODIGO As Telerik.WinControls.UI.RadTextBox

End Class
