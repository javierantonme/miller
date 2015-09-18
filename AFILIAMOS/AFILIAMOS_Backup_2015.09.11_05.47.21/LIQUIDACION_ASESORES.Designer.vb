<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LIQUIDACION_ASESORES
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LIQUIDACION_ASESORES))
        Me.RadRibbonBar1 = New Telerik.WinControls.UI.RadRibbonBar()
        Me.RibbonTab1 = New Telerik.WinControls.UI.RibbonTab()
        Me.RadRibbonBarGroup1 = New Telerik.WinControls.UI.RadRibbonBarGroup()
        Me.BTM_GUARDAR = New Telerik.WinControls.UI.RadButtonElement()
        Me.RadRibbonBarGroup2 = New Telerik.WinControls.UI.RadRibbonBarGroup()
        Me.BTM_SALIR = New Telerik.WinControls.UI.RadButtonElement()
        Me.RadStatusStrip1 = New Telerik.WinControls.UI.RadStatusStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LB_LIQUIDACION = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.TB_fECHA_FINAL = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.TB_TOTAL = New Telerik.WinControls.UI.RadTextBox()
        Me.RadGridView1 = New Telerik.WinControls.UI.RadGridView()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.TB_ASESOR_NOMBRE = New Telerik.WinControls.UI.RadTextBox()
        Me.TB_ASESOR = New Telerik.WinControls.UI.RadMultiColumnComboBox()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.TB_FECHA_INICIAL = New Telerik.WinControls.UI.RadDateTimePicker()
        CType(Me.RadRibbonBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.LB_LIQUIDACION, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TB_fECHA_FINAL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TB_TOTAL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TB_ASESOR_NOMBRE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TB_ASESOR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TB_ASESOR.EditorControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TB_ASESOR.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TB_FECHA_INICIAL, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.RadRibbonBar1.Size = New System.Drawing.Size(444, 165)
        Me.RadRibbonBar1.StartButtonImage = CType(resources.GetObject("RadRibbonBar1.StartButtonImage"), System.Drawing.Image)
        Me.RadRibbonBar1.TabIndex = 0
        Me.RadRibbonBar1.Text = "LIQUIDACION_ASESORES"
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
        Me.RadRibbonBarGroup1.Items.AddRange(New Telerik.WinControls.RadItem() {Me.BTM_GUARDAR})
        Me.RadRibbonBarGroup1.Name = "RadRibbonBarGroup1"
        Me.RadRibbonBarGroup1.Text = "Edicion"
        Me.RadRibbonBarGroup1.Visibility = Telerik.WinControls.ElementVisibility.Visible
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
        Me.RadStatusStrip1.Location = New System.Drawing.Point(0, 506)
        Me.RadStatusStrip1.Name = "RadStatusStrip1"
        Me.RadStatusStrip1.Size = New System.Drawing.Size(444, 24)
        Me.RadStatusStrip1.SizingGrip = False
        Me.RadStatusStrip1.TabIndex = 1
        Me.RadStatusStrip1.Text = "RadStatusStrip1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LB_LIQUIDACION)
        Me.Panel1.Controls.Add(Me.RadLabel5)
        Me.Panel1.Controls.Add(Me.RadButton1)
        Me.Panel1.Controls.Add(Me.TB_fECHA_FINAL)
        Me.Panel1.Controls.Add(Me.RadLabel4)
        Me.Panel1.Controls.Add(Me.TB_TOTAL)
        Me.Panel1.Controls.Add(Me.RadGridView1)
        Me.Panel1.Controls.Add(Me.RadLabel3)
        Me.Panel1.Controls.Add(Me.TB_ASESOR_NOMBRE)
        Me.Panel1.Controls.Add(Me.TB_ASESOR)
        Me.Panel1.Controls.Add(Me.RadLabel2)
        Me.Panel1.Controls.Add(Me.RadLabel1)
        Me.Panel1.Controls.Add(Me.TB_FECHA_INICIAL)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 165)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(444, 341)
        Me.Panel1.TabIndex = 2
        '
        'LB_LIQUIDACION
        '
        Me.LB_LIQUIDACION.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.LB_LIQUIDACION.ForeColor = System.Drawing.Color.Red
        Me.LB_LIQUIDACION.Location = New System.Drawing.Point(322, 295)
        Me.LB_LIQUIDACION.Name = "LB_LIQUIDACION"
        Me.LB_LIQUIDACION.Size = New System.Drawing.Size(21, 31)
        Me.LB_LIQUIDACION.TabIndex = 14
        Me.LB_LIQUIDACION.Text = "0"
        Me.LB_LIQUIDACION.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        '
        'RadLabel5
        '
        Me.RadLabel5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel5.Location = New System.Drawing.Point(188, 308)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(119, 18)
        Me.RadLabel5.TabIndex = 13
        Me.RadLabel5.Text = "TOTAL LIQUIDACION"
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(379, 77)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(44, 24)
        Me.RadButton1.TabIndex = 11
        Me.RadButton1.Text = "Buscar"
        '
        'TB_fECHA_FINAL
        '
        Me.TB_fECHA_FINAL.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TB_fECHA_FINAL.Location = New System.Drawing.Point(222, 23)
        Me.TB_fECHA_FINAL.Name = "TB_fECHA_FINAL"
        Me.TB_fECHA_FINAL.Size = New System.Drawing.Size(188, 20)
        Me.TB_fECHA_FINAL.TabIndex = 1
        Me.TB_fECHA_FINAL.TabStop = False
        Me.TB_fECHA_FINAL.Text = "28/08/2015 16:17"
        Me.TB_fECHA_FINAL.Value = New Date(2015, 8, 28, 16, 17, 12, 939)
        '
        'RadLabel4
        '
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel4.Location = New System.Drawing.Point(13, 284)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(155, 18)
        Me.RadLabel4.TabIndex = 9
        Me.RadLabel4.Text = "TOTAL BASE FACTURACIÓN"
        '
        'TB_TOTAL
        '
        Me.TB_TOTAL.Location = New System.Drawing.Point(169, 282)
        Me.TB_TOTAL.Name = "TB_TOTAL"
        Me.TB_TOTAL.ReadOnly = True
        Me.TB_TOTAL.Size = New System.Drawing.Size(70, 20)
        Me.TB_TOTAL.TabIndex = 8
        '
        'RadGridView1
        '
        Me.RadGridView1.Location = New System.Drawing.Point(13, 124)
        '
        'RadGridView1
        '
        Me.RadGridView1.MasterTemplate.AllowAddNewRow = False
        Me.RadGridView1.MasterTemplate.AllowColumnReorder = False
        Me.RadGridView1.Name = "RadGridView1"
        Me.RadGridView1.ReadOnly = True
        Me.RadGridView1.Size = New System.Drawing.Size(397, 150)
        Me.RadGridView1.TabIndex = 7
        Me.RadGridView1.Text = "RadGridView1"
        '
        'RadLabel3
        '
        Me.RadLabel3.Location = New System.Drawing.Point(13, 60)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(40, 18)
        Me.RadLabel3.TabIndex = 6
        Me.RadLabel3.Text = "Asesor"
        '
        'TB_ASESOR_NOMBRE
        '
        Me.TB_ASESOR_NOMBRE.Location = New System.Drawing.Point(148, 79)
        Me.TB_ASESOR_NOMBRE.Name = "TB_ASESOR_NOMBRE"
        Me.TB_ASESOR_NOMBRE.Size = New System.Drawing.Size(225, 20)
        Me.TB_ASESOR_NOMBRE.TabIndex = 5
        '
        'TB_ASESOR
        '
        '
        'TB_ASESOR.NestedRadGridView
        '
        Me.TB_ASESOR.EditorControl.BackColor = System.Drawing.SystemColors.Window
        Me.TB_ASESOR.EditorControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_ASESOR.EditorControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TB_ASESOR.EditorControl.Location = New System.Drawing.Point(0, 0)
        '
        '
        '
        Me.TB_ASESOR.EditorControl.MasterTemplate.AllowAddNewRow = False
        Me.TB_ASESOR.EditorControl.MasterTemplate.AllowCellContextMenu = False
        Me.TB_ASESOR.EditorControl.MasterTemplate.AllowColumnChooser = False
        Me.TB_ASESOR.EditorControl.MasterTemplate.EnableGrouping = False
        Me.TB_ASESOR.EditorControl.MasterTemplate.ShowFilteringRow = False
        Me.TB_ASESOR.EditorControl.Name = "NestedRadGridView"
        Me.TB_ASESOR.EditorControl.ReadOnly = True
        Me.TB_ASESOR.EditorControl.ShowGroupPanel = False
        Me.TB_ASESOR.EditorControl.Size = New System.Drawing.Size(240, 150)
        Me.TB_ASESOR.EditorControl.TabIndex = 0
        Me.TB_ASESOR.Location = New System.Drawing.Point(13, 79)
        Me.TB_ASESOR.Name = "TB_ASESOR"
        Me.TB_ASESOR.Size = New System.Drawing.Size(129, 20)
        Me.TB_ASESOR.TabIndex = 4
        Me.TB_ASESOR.TabStop = False
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(222, 6)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(61, 18)
        Me.RadLabel2.TabIndex = 3
        Me.RadLabel2.Text = "Fecha Final"
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(13, 4)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(67, 18)
        Me.RadLabel1.TabIndex = 2
        Me.RadLabel1.Text = "Fecha Inicial"
        '
        'TB_FECHA_INICIAL
        '
        Me.TB_FECHA_INICIAL.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TB_FECHA_INICIAL.Location = New System.Drawing.Point(13, 23)
        Me.TB_FECHA_INICIAL.Name = "TB_FECHA_INICIAL"
        Me.TB_FECHA_INICIAL.Size = New System.Drawing.Size(188, 20)
        Me.TB_FECHA_INICIAL.TabIndex = 0
        Me.TB_FECHA_INICIAL.TabStop = False
        Me.TB_FECHA_INICIAL.Text = "28/08/2015 16:17"
        Me.TB_FECHA_INICIAL.Value = New Date(2015, 8, 28, 16, 17, 12, 939)
        '
        'LIQUIDACION_ASESORES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(444, 530)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RadStatusStrip1)
        Me.Controls.Add(Me.RadRibbonBar1)
        Me.MaximumSize = New System.Drawing.Size(452, 535)
        Me.MinimumSize = New System.Drawing.Size(452, 535)
        Me.Name = "LIQUIDACION_ASESORES"
        '
        '
        '
        Me.RootElement.ApplyShapeToControl = True
        Me.RootElement.MaxSize = New System.Drawing.Size(452, 535)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LIQUIDACION_ASESORES"
        CType(Me.RadRibbonBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadStatusStrip1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.LB_LIQUIDACION, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TB_fECHA_FINAL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TB_TOTAL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TB_ASESOR_NOMBRE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TB_ASESOR.EditorControl.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TB_ASESOR.EditorControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TB_ASESOR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TB_FECHA_INICIAL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadRibbonBar1 As Telerik.WinControls.UI.RadRibbonBar
    Friend WithEvents RadStatusStrip1 As Telerik.WinControls.UI.RadStatusStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents RibbonTab1 As Telerik.WinControls.UI.RibbonTab
    Friend WithEvents RadRibbonBarGroup1 As Telerik.WinControls.UI.RadRibbonBarGroup
    Friend WithEvents BTM_GUARDAR As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RadRibbonBarGroup2 As Telerik.WinControls.UI.RadRibbonBarGroup
    Friend WithEvents BTM_SALIR As Telerik.WinControls.UI.RadButtonElement
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TB_ASESOR_NOMBRE As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TB_ASESOR As Telerik.WinControls.UI.RadMultiColumnComboBox
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TB_fECHA_FINAL As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents TB_FECHA_INICIAL As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TB_TOTAL As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadGridView1 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents LB_LIQUIDACION As Telerik.WinControls.UI.RadLabel

End Class
