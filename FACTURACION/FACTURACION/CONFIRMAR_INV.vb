Public Class CONFIRMAR_INV

    Private Sub CONFIRMAR_INV_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Sub PREGUNTA()
        If CH_GUARDAR.Checked = True Then
            INVENTARIO_INICIAL.ESTADO = 1
            CH_CONFIRMAR.Checked = False
        ElseIf CH_CONFIRMAR.Checked = True Then
            INVENTARIO_INICIAL.ESTADO = 0
            CH_GUARDAR.Checked = False
        End If
    End Sub
    'GUARDAR_INVENTARIO()
    'GUARDAR_ARTICULOS()

    Private Sub CH_GUARDAR_CheckedChanged(sender As Object, e As EventArgs)
        PREGUNTA()
    End Sub

    Private Sub CH_CONFIRMAR_CheckedChanged(sender As Object, e As EventArgs)
        PREGUNTA()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If INVENTARIO_INICIAL.X = 1 Then
            INVENTARIO_INICIAL.GUARDAR_INVENTARIO()
            INVENTARIO_INICIAL.GUARDAR_ARTICULOS()
            INVENTARIO_INICIAL.GUARDAR_KARDEK()
        ElseIf INVENTARIO_INICIAL.X = 2 Then
            INVENTARIO_INICIAL.GUARDAR_ARTICULOS2()
            INVENTARIO_INICIAL.GUARDAR_KARDEK()
        End If

        Me.Dispose()
        INVENTARIO_INICIAL.Dispose()
        INVENTARIO1.BUSCAR_INVENTARIOS()
    End Sub
End Class