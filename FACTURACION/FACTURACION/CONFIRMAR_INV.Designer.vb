<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CONFIRMAR_INV
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CH_GUARDAR = New System.Windows.Forms.RadioButton()
        Me.CH_CONFIRMAR = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(115, 78)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Aceptar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CH_GUARDAR
        '
        Me.CH_GUARDAR.AutoSize = True
        Me.CH_GUARDAR.Location = New System.Drawing.Point(26, 21)
        Me.CH_GUARDAR.Name = "CH_GUARDAR"
        Me.CH_GUARDAR.Size = New System.Drawing.Size(128, 17)
        Me.CH_GUARDAR.TabIndex = 3
        Me.CH_GUARDAR.TabStop = True
        Me.CH_GUARDAR.Text = "Guardar Sin Confirmar"
        Me.CH_GUARDAR.UseVisualStyleBackColor = True
        '
        'CH_CONFIRMAR
        '
        Me.CH_CONFIRMAR.AutoSize = True
        Me.CH_CONFIRMAR.Location = New System.Drawing.Point(26, 44)
        Me.CH_CONFIRMAR.Name = "CH_CONFIRMAR"
        Me.CH_CONFIRMAR.Size = New System.Drawing.Size(69, 17)
        Me.CH_CONFIRMAR.TabIndex = 4
        Me.CH_CONFIRMAR.TabStop = True
        Me.CH_CONFIRMAR.Text = "Confirmar"
        Me.CH_CONFIRMAR.UseVisualStyleBackColor = True
        '
        'CONFIRMAR_INV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(202, 108)
        Me.Controls.Add(Me.CH_CONFIRMAR)
        Me.Controls.Add(Me.CH_GUARDAR)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "CONFIRMAR_INV"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONFIRMAR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CH_GUARDAR As System.Windows.Forms.RadioButton
    Friend WithEvents CH_CONFIRMAR As System.Windows.Forms.RadioButton
End Class
