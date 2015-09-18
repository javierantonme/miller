<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CONCEPTOS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CONCEPTOS))
        Dim RadListDataItem3 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Dim RadListDataItem4 As Telerik.WinControls.UI.RadListDataItem = New Telerik.WinControls.UI.RadListDataItem()
        Me.RadRibbonBar1 = New Telerik.WinControls.UI.RadRibbonBar()
        Me.RibbonTab1 = New Telerik.WinControls.UI.RibbonTab()
        Me.RadRibbonBarGroup1 = New Telerik.WinControls.UI.RadRibbonBarGroup()
        Me.BTM_NUEVO = New Telerik.WinControls.UI.RadButtonElement()
        Me.BTM_GUARDAR = New Telerik.WinControls.UI.RadButtonElement()
        Me.BTM_MODIFICAR = New Telerik.WinControls.UI.RadButtonElement()
        Me.RadRibbonBarGroup2 = New Telerik.WinControls.UI.RadRibbonBarGroup()
        Me.BTM_SALIR = New Telerik.WinControls.UI.RadButtonElement()
        Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RadGridView1 = New Telerik.WinControls.UI.RadGridView()
        Me.TB_TIPO = New Telerik.WinControls.UI.RadDropDownList()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.TB_NOMBRE = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.TB_CODIGO = New Telerik.WinControls.UI.RadTextBox()
        Me.RB_EPS = New Telerik.WinControls.UI.RadRadioButton()
        Me.RB_PENSIONES = New Telerik.WinControls.UI.RadRadioButton()
        Me.RB_ARL = New Telerik.WinControls.UI.RadRadioButton()
        Me.RB_CAJA = New Telerik.WinControls.UI.RadRadioButton()
        Me.RB_ADMINISTRACION = New Telerik.WinControls.UI.RadRadioButton()
        Me.RB_FILIACION = New Telerik.WinControls.UI.RadRadioButton()
        Me.RB_NINGUNO = New Telerik.WinControls.UI.RadRadioButton()
        CType(Me.RadRibbonBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TB_TIPO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TB_NOMBRE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TB_CODIGO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RB_EPS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RB_PENSIONES, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RB_ARL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RB_CAJA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RB_ADMINISTRACION, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RB_FILIACION, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RB_NINGUNO, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.RadRibbonBar1.Size = New System.Drawing.Size(557, 165)
        Me.RadRibbonBar1.StartButtonImage = CType(resources.GetObject("RadRibbonBar1.StartButtonImage"), System.Drawing.Image)
        Me.RadRibbonBar1.TabIndex = 0
        Me.RadRibbonBar1.Text = "CONCEPTOS"
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
        Me.RadRibbonBarGroup1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.BTM_NUEVO, Me.BTM_GUARDAR, Me.BTM_MODIFICAR})
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
        'BTM_MODIFICAR
        '
        Me.BTM_MODIFICAR.AccessibleDescription = "Modificar"
        Me.BTM_MODIFICAR.AccessibleName = "Modificar"
        Me.BTM_MODIFICAR.Image = Global.AFILIAMOS.My.Resources.Resources.page_edit
        Me.BTM_MODIFICAR.Name = "BTM_MODIFICAR"
        Me.BTM_MODIFICAR.Text = "Modificar"
        Me.BTM_MODIFICAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTM_MODIFICAR.Visibility = Telerik.WinControls.ElementVisibility.Visible
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
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 594)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Size = New System.Drawing.Size(557, 24)
        Me.RadStatusStrip1.SizingGrip = False
        Me.RadStatusStrip1.TabIndex = 1
        Me.RadStatusStrip1.Text = "RadStatusStrip1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RB_NINGUNO)
        Me.Panel1.Controls.Add(Me.RB_FILIACION)
        Me.Panel1.Controls.Add(Me.RB_ADMINISTRACION)
        Me.Panel1.Controls.Add(Me.RB_CAJA)
        Me.Panel1.Controls.Add(Me.RB_ARL)
        Me.Panel1.Controls.Add(Me.RB_PENSIONES)
        Me.Panel1.Controls.Add(Me.RB_EPS)
        Me.Panel1.Controls.Add(Me.RadGridView1)
        Me.Panel1.Controls.Add(Me.TB_TIPO)
        Me.Panel1.Controls.Add(Me.RadLabel2)
        Me.Panel1.Controls.Add(Me.TB_NOMBRE)
        Me.Panel1.Controls.Add(Me.RadLabel1)
        Me.Panel1.Controls.Add(Me.TB_CODIGO)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 165)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(557, 429)
        Me.Panel1.TabIndex = 2
        '
        'RadGridView1
        '
        Me.RadGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RadGridView1.Location = New System.Drawing.Point(0, 151)
        '
        'RadGridView1
        '
        Me.RadGridView1.MasterTemplate.AllowAddNewRow = False
        Me.RadGridView1.MasterTemplate.AllowColumnReorder = False
        Me.RadGridView1.Name = "RadGridView1"
        Me.RadGridView1.ReadOnly = True
        Me.RadGridView1.Size = New System.Drawing.Size(557, 278)
        Me.RadGridView1.TabIndex = 5
        Me.RadGridView1.Text = "RadGridView1"
        '
        'TB_TIPO
        '
        Me.TB_TIPO.AllowShowFocusCues = False
        Me.TB_TIPO.AutoCompleteDisplayMember = Nothing
        Me.TB_TIPO.AutoCompleteValueMember = Nothing
        RadListDataItem3.Text = "RECIBO DE CAJA"
        RadListDataItem3.TextWrap = True
        RadListDataItem4.Text = "COMPROBANTE DE EGRESO"
        RadListDataItem4.TextWrap = True
        Me.TB_TIPO.Items.Add(RadListDataItem3)
        Me.TB_TIPO.Items.Add(RadListDataItem4)
        Me.TB_TIPO.Location = New System.Drawing.Point(383, 71)
        Me.TB_TIPO.Name = "TB_TIPO"
        Me.TB_TIPO.Size = New System.Drawing.Size(162, 20)
        Me.TB_TIPO.TabIndex = 4
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(13, 51)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(64, 18)
        Me.RadLabel2.TabIndex = 3
        Me.RadLabel2.Text = "Descripción"
        '
        'TB_NOMBRE
        '
        Me.TB_NOMBRE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_NOMBRE.Location = New System.Drawing.Point(13, 71)
        Me.TB_NOMBRE.Name = "TB_NOMBRE"
        Me.TB_NOMBRE.Size = New System.Drawing.Size(360, 20)
        Me.TB_NOMBRE.TabIndex = 2
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(13, 5)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(43, 18)
        Me.RadLabel1.TabIndex = 1
        Me.RadLabel1.Text = "Codigo"
        '
        'TB_CODIGO
        '
        Me.TB_CODIGO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TB_CODIGO.Location = New System.Drawing.Point(13, 25)
        Me.TB_CODIGO.Name = "TB_CODIGO"
        Me.TB_CODIGO.Size = New System.Drawing.Size(131, 20)
        Me.TB_CODIGO.TabIndex = 0
        '
        'RB_EPS
        '
        Me.RB_EPS.Location = New System.Drawing.Point(13, 98)
        Me.RB_EPS.Name = "RB_EPS"
        Me.RB_EPS.Size = New System.Drawing.Size(38, 18)
        Me.RB_EPS.TabIndex = 6
        Me.RB_EPS.Text = "EPS"
        '
        'RB_PENSIONES
        '
        Me.RB_PENSIONES.Location = New System.Drawing.Point(57, 98)
        Me.RB_PENSIONES.Name = "RB_PENSIONES"
        Me.RB_PENSIONES.Size = New System.Drawing.Size(79, 18)
        Me.RB_PENSIONES.TabIndex = 7
        Me.RB_PENSIONES.Text = "PENSIONES"
        '
        'RB_ARL
        '
        Me.RB_ARL.Location = New System.Drawing.Point(142, 98)
        Me.RB_ARL.Name = "RB_ARL"
        Me.RB_ARL.Size = New System.Drawing.Size(40, 18)
        Me.RB_ARL.TabIndex = 8
        Me.RB_ARL.Text = "ARL"
        '
        'RB_CAJA
        '
        Me.RB_CAJA.Location = New System.Drawing.Point(188, 98)
        Me.RB_CAJA.Name = "RB_CAJA"
        Me.RB_CAJA.Size = New System.Drawing.Size(136, 18)
        Me.RB_CAJA.TabIndex = 9
        Me.RB_CAJA.Text = "CAJA COMPENSACION"
        '
        'RB_ADMINISTRACION
        '
        Me.RB_ADMINISTRACION.Location = New System.Drawing.Point(330, 98)
        Me.RB_ADMINISTRACION.Name = "RB_ADMINISTRACION"
        Me.RB_ADMINISTRACION.Size = New System.Drawing.Size(113, 18)
        Me.RB_ADMINISTRACION.TabIndex = 10
        Me.RB_ADMINISTRACION.Text = "ADMINISTRACION"
        '
        'RB_FILIACION
        '
        Me.RB_FILIACION.Location = New System.Drawing.Point(449, 98)
        Me.RB_FILIACION.Name = "RB_FILIACION"
        Me.RB_FILIACION.Size = New System.Drawing.Size(79, 18)
        Me.RB_FILIACION.TabIndex = 11
        Me.RB_FILIACION.Text = "AFILIACION"
        '
        'RB_NINGUNO
        '
        Me.RB_NINGUNO.Location = New System.Drawing.Point(13, 127)
        Me.RB_NINGUNO.Name = "RB_NINGUNO"
        Me.RB_NINGUNO.Size = New System.Drawing.Size(73, 18)
        Me.RB_NINGUNO.TabIndex = 12
        Me.RB_NINGUNO.Text = "NINGUNO"
        '
        'CONCEPTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 618)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Controls.Add(Me.RadRibbonBar1)
        Me.Name = "CONCEPTOS"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.RootElement.MaxSize = New System.Drawing.Size(565, 549)
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONCEPTOS"
        CType(Me.RadRibbonBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TB_TIPO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TB_NOMBRE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TB_CODIGO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RB_EPS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RB_PENSIONES, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RB_ARL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RB_CAJA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RB_ADMINISTRACION, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RB_FILIACION, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RB_NINGUNO, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents BTM_MODIFICAR As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RadRibbonBarGroup2 As Telerik.WinControls.UI.RadRibbonBarGroup
    Friend WithEvents BTM_SALIR As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RadGridView1 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents TB_TIPO As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TB_NOMBRE As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TB_CODIGO As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RB_FILIACION As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RB_ADMINISTRACION As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RB_CAJA As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RB_ARL As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RB_PENSIONES As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RB_EPS As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RB_NINGUNO As Telerik.WinControls.UI.RadRadioButton

End Class
