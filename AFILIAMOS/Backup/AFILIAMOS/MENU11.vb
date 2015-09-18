Public Class MENU11

    Private Sub RadTileElement1_Click(sender As Object, e As EventArgs) Handles RadTileElement1.Click
        CLIENTES.ShowDialog()
    End Sub

    Private Sub RadTileElement2_Click(sender As Object, e As EventArgs) Handles RadTileElement2.Click
        LOGIN.Dispose()
    End Sub

    Private Sub RadTileElement3_Click(sender As Object, e As EventArgs) Handles RadTileElement3.Click
        CONCEPTOS.ShowDialog()
    End Sub

    Private Sub RadTileElement4_Click(sender As Object, e As EventArgs) Handles RadTileElement4.Click
        CAJAS1.ShowDialog()
    End Sub

    Private Sub RadTileElement5_Click(sender As Object, e As EventArgs) Handles RadTileElement5.Click
        USUARIOS.ShowDialog()
    End Sub

    Private Sub RadTileElement6_Click(sender As Object, e As EventArgs) Handles RadTileElement6.Click
        EMPRESA.ShowDialog()
    End Sub

    Private Sub RadTileElement7_Click(sender As Object, e As EventArgs) Handles RadTileElement7.Click
        BANCOS.ShowDialog()
    End Sub

    Private Sub RadTileElement8_Click(sender As Object, e As EventArgs) Handles RadTileElement8.Click
        CUENTAS.ShowDialog()
    End Sub

    Private Sub btm_tema_Click(sender As Object, e As EventArgs) Handles btm_tema.Click
        TEMA.ShowDialog()
    End Sub

    Private Sub CommandBarLabel1_Click(sender As Object, e As EventArgs)
        TEMA.ShowDialog()
    End Sub

    Private Sub RadTileElement9_Click(sender As Object, e As EventArgs) Handles RadTileElement9.Click
        RECIBOS_DE_CABA.ShowDialog()
    End Sub

    Private Sub RadTileElement10_Click(sender As Object, e As EventArgs) Handles RadTileElement10.Click
        IMPRIMIR.ShowDialog()
    End Sub

    Private Sub RadTileElement11_Click(sender As Object, e As EventArgs) Handles RadTileElement11.Click
        AFILIACIONES.ShowDialog()
    End Sub

    Private Sub RadTileElement12_Click(sender As Object, e As EventArgs) Handles RadTileElement12.Click
        SALARIO_MINIMO.ShowDialog()
    End Sub

    Private Sub RadTileElement13_Click(sender As Object, e As EventArgs) Handles RadTileElement13.Click
        TERCEROS.ShowDialog()
    End Sub

    Private Sub RadTileElement14_Click(sender As Object, e As EventArgs) Handles RadTileElement14.Click
        IMPRIMIR_LIQUIDACION_2.ShowDialog()
    End Sub

    Private Sub RadTileElement15_Click(sender As Object, e As EventArgs) Handles RadTileElement15.Click
        ASESOR.ShowDialog()
    End Sub

    Private Sub RadTileElement16_Click(sender As Object, e As EventArgs) Handles RadTileElement16.Click
        LIQUIDACION_ASESORES.ShowDialog()
    End Sub
End Class
