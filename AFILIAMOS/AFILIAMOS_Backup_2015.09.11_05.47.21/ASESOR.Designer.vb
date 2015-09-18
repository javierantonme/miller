<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ASESOR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ASESOR))
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
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.TB_TELEFONO = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.TB_DIRECCION = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.TB_NOMBRE = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.TB_CODIGO = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.TB_PORCENTAJE = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        CType(Me.RadRibbonBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TB_TELEFONO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TB_DIRECCION, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TB_NOMBRE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TB_CODIGO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TB_PORCENTAJE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.RadRibbonBar1.Size = New System.Drawing.Size(458, 165)
        Me.RadRibbonBar1.StartButtonImage = CType(resources.GetObject("RadRibbonBar1.StartButtonImage"), System.Drawing.Image)
        Me.RadRibbonBar1.TabIndex = 0
        Me.RadRibbonBar1.Text = "ASESOR"
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
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 446)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Size = New System.Drawing.Size(458, 24)
        Me.RadStatusStrip1.SizingGrip = False
        Me.RadStatusStrip1.TabIndex = 1
        Me.RadStatusStrip1.Text = "RadStatusStrip1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TB_PORCENTAJE)
        Me.Panel1.Controls.Add(Me.RadLabel6)
        Me.Panel1.Controls.Add(Me.RadLabel5)
        Me.Panel1.Controls.Add(Me.RadGridView1)
        Me.Panel1.Controls.Add(Me.RadLabel4)
        Me.Panel1.Controls.Add(Me.TB_TELEFONO)
        Me.Panel1.Controls.Add(Me.RadLabel3)
        Me.Panel1.Controls.Add(Me.TB_DIRECCION)
        Me.Panel1.Controls.Add(Me.RadLabel2)
        Me.Panel1.Controls.Add(Me.TB_NOMBRE)
        Me.Panel1.Controls.Add(Me.RadLabel1)
        Me.Panel1.Controls.Add(Me.TB_CODIGO)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 165)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(458, 281)
        Me.Panel1.TabIndex = 2
        '
        'RadGridView1
        '
        Me.RadGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RadGridView1.Location = New System.Drawing.Point(0, 108)
        '
        'RadGridView1
        '
        Me.RadGridView1.MasterTemplate.AllowAddNewRow = False
        Me.RadGridView1.MasterTemplate.AllowColumnReorder = False
        Me.RadGridView1.Name = "RadGridView1"
        Me.RadGridView1.ReadOnly = True
        Me.RadGridView1.Size = New System.Drawing.Size(458, 173)
        Me.RadGridView1.TabIndex = 8
        Me.RadGridView1.Text = "RadGridView1"
        '
        'RadLabel4
        '
        Me.RadLabel4.Location = New System.Drawing.Point(178, 49)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(50, 18)
        Me.RadLabel4.TabIndex = 7
        Me.RadLabel4.Text = "Telefono"
        '
        'TB_TELEFONO
        '
        Me.TB_TELEFONO.Location = New System.Drawing.Point(177, 69)
        Me.TB_TELEFONO.Name = "TB_TELEFONO"
        Me.TB_TELEFONO.Size = New System.Drawing.Size(155, 20)
        Me.TB_TELEFONO.TabIndex = 6
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(13, 49)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(53, 18)
        Me.RadLabel3.TabIndex = 5
        Me.RadLabel3.Text = "Dirección"
        '
        'TB_DIRECCION
        '
        Me.TB_DIRECCION.Location = New System.Drawing.Point(12, 69)
        Me.TB_DIRECCION.Name = "TB_DIRECCION"
        Me.TB_DIRECCION.Size = New System.Drawing.Size(155, 20)
        Me.TB_DIRECCION.TabIndex = 4
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(137, 7)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(48, 18)
        Me.RadLabel2.TabIndex = 3
        Me.RadLabel2.Text = "Nombre"
        '
        'TB_NOMBRE
        '
        Me.TB_NOMBRE.Location = New System.Drawing.Point(136, 27)
        Me.TB_NOMBRE.Name = "TB_NOMBRE"
        Me.TB_NOMBRE.Size = New System.Drawing.Size(296, 20)
        Me.TB_NOMBRE.TabIndex = 2
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(13, 7)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(73, 18)
        Me.RadLabel1.TabIndex = 1
        Me.RadLabel1.Text = "Identificación"
        '
        'TB_CODIGO
        '
        Me.TB_CODIGO.Location = New System.Drawing.Point(12, 27)
        Me.TB_CODIGO.Name = "TB_CODIGO"
        Me.TB_CODIGO.Size = New System.Drawing.Size(100, 20)
        Me.TB_CODIGO.TabIndex = 0
        '
        'RadLabel5
        '
        Me.RadLabel5.Location = New System.Drawing.Point(346, 49)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(59, 18)
        Me.RadLabel5.TabIndex = 10
        Me.RadLabel5.Text = "Porcentaje"
        '
        'TB_PORCENTAJE
        '
        Me.TB_PORCENTAJE.Location = New System.Drawing.Point(345, 69)
        Me.TB_PORCENTAJE.Name = "TB_PORCENTAJE"
        Me.TB_PORCENTAJE.Size = New System.Drawing.Size(27, 20)
        Me.TB_PORCENTAJE.TabIndex = 9
        Me.TB_PORCENTAJE.Text = "0"
        '
        'RadLabel6
        '
        Me.RadLabel6.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel6.Location = New System.Drawing.Point(369, 69)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(19, 21)
        Me.RadLabel6.TabIndex = 11
        Me.RadLabel6.Text = "%"
        '
        'ASESOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 470)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Controls.Add(Me.RadRibbonBar1)
        Me.MaximumSize = New System.Drawing.Size(466, 475)
        Me.MinimumSize = New System.Drawing.Size(466, 475)
        Me.Name = "ASESOR"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.RootElement.MaxSize = New System.Drawing.Size(466, 475)
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ASESOR"
        CType(Me.RadRibbonBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TB_TELEFONO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TB_DIRECCION, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TB_NOMBRE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TB_CODIGO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TB_PORCENTAJE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TB_TELEFONO As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TB_DIRECCION As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TB_NOMBRE As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TB_CODIGO As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TB_PORCENTAJE As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel

End Class
