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

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        USUARIOS.ShowDialog()
    End Sub

    Private Sub MENU1_Load(sender As Object, e As EventArgs) Handles Me.Load
        LB_USUARIO.Text = "Usuario: " & LOGIN.USUARIO & "-" & LOGIN.NOMBRE
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        LOGIN.Dispose()
    End Sub

    Private Sub AjustesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjustesToolStripMenuItem.Click
        AJUSTE.ShowDialog()
    End Sub

    Private Sub FacturacionToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FacturacionToolStripMenuItem1.Click
        FACTURACION.ShowDialog()
    End Sub

    Private Sub ConceptosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConceptosToolStripMenuItem.Click
        CONCEPTOS.ShowDialog()
    End Sub
End Class
