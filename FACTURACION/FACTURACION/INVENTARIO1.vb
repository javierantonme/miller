Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class INVENTARIO1

    Private Sub INVENTARIO1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BUSCAR_INVENTARIOS()
    End Sub

    Sub BUSCAR_INVENTARIOS()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_INVENTARIOSC", conex)
            cmd.CommandType = CommandType.StoredProcedure
            'cmd.Parameters.Add("@cedula_pac", SqlDbType.VarChar).Value = tb_cedula.Text
            Dim ada As New SqlDataAdapter(cmd)
            Dim tabla As New DataTable
            conex.Open()
            ada.Fill(tabla)
            DataGridView1.DataSource = tabla
            conex.Close()
            DataGridView1.Columns(0).Width = 100
            DataGridView1.Columns(1).Width = 200
            DataGridView1.Columns(2).Width = 150
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BTM_SALIR_Click(sender As Object, e As EventArgs) Handles BTM_SALIR.Click
        Dispose()
    End Sub

    Private Sub btm_nuevo_Click(sender As Object, e As EventArgs) Handles btm_nuevo.Click
        INVENTARIO_INICIAL.X = 1
        INVENTARIO_INICIAL.BUSCAR_CONSECUTIVO_SIGUIENTE()
        INVENTARIO_INICIAL.ShowDialog()
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        If i <> -1 Then
            If DataGridView1.Rows(i).Selected = True Then
                INVENTARIO_INICIAL.CONSEC = DataGridView1.Rows(i).Cells(0).Value.ToString()
                INVENTARIO_INICIAL.BUSCAR_INVENTARIO_CODIGO_ANTERIOR()

                If DataGridView1.Rows(i).Cells(3).Value.ToString() = "REGISTRADO" Then
                    INVENTARIO_INICIAL.X = 2
                    INVENTARIO_INICIAL.TB_CONSECUTIVO.Text = DataGridView1.Rows(i).Cells(0).Value.ToString()
                    INVENTARIO_INICIAL.BTM_GUARDAR.Enabled = True
                    INVENTARIO_INICIAL.Button1.Enabled = True
                    INVENTARIO_INICIAL.GroupBox1.Enabled = True
                Else
                    INVENTARIO_INICIAL.BTM_GUARDAR.Enabled = False
                    INVENTARIO_INICIAL.Button1.Enabled = False
                    INVENTARIO_INICIAL.GroupBox1.Enabled = False
                End If

                INVENTARIO_INICIAL.ShowDialog()
            End If
        End If
    End Sub
End Class