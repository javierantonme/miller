Imports System.Windows.Forms

Public Class MENU1
    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Form1.ShowDialog()
    End Sub

   

    Private Sub InventaroInicialToolStripMenuItem_Click(sender As Object, e As EventArgs)
        INVENTARIO_INICIAL.ShowDialog()
    End Sub

    Private Sub RemisionesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        REMISIONES.ShowDialog()
    End Sub

    Private Sub BodegasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BodegasToolStripMenuItem.Click
        BODEGAS.ShowDialog()
    End Sub

    Private Sub InventariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InventariosToolStripMenuItem.Click
        INVENTARIO1.ShowDialog()
    End Sub

    Private Sub ArticulosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArticulosToolStripMenuItem.Click
        ARTICULOS.ShowDialog()
    End Sub

    Private Sub UnidadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnidadesToolStripMenuItem.Click
        PRESENTACION.ShowDialog()
    End Sub

    Private Sub TercerosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        TERCEROS.ShowDialog()
    End Sub

    Private Sub TodasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TodasToolStripMenuItem.Click
        DEVOLUCION_REM.ShowDialog()
    End Sub

    Private Sub KardexToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KardexToolStripMenuItem.Click
        KARDEX.ShowDialog()
    End Sub

    Private Sub FacturacionToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FacturacionToolStripMenuItem1.Click
        FACTURACION.ShowDialog()
    End Sub
End Class
