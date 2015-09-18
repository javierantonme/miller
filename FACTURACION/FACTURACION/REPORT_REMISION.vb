Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Public Class REPORT_REMISION
    Public OID As Integer
    Sub crystal_reports()

        ' Dim sqlConn As SqlConnection
        Dim sqlDaPac As SqlDataAdapter
        Dim sqlDaMed As SqlDataAdapter
        Dim sqlDaMedi As SqlDataAdapter
        Dim sqlDaEPS As SqlDataAdapter
      
        Dim dsPc As New DS_REMISIONES

        Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
        ' Dim strCommEPS As String = "Select * From EPS"

        Dim StrCommPac As String = "Select * From CLIENTES"
        Dim strCommMed As String = "Select * From ARTICULOS"
        Dim strCommMedi As String = "Select * From REMISIONESD"
        Dim strCommEps As String = "select * from REMISIONESC where OID = '" & OID & "'"


        Try
            'Crear los DataAdapters
            'sqlDaEPS = New SqlDataAdapter(strCommEPS, conex)

            sqlDaPac = New SqlDataAdapter(StrCommPac, conex)
            sqlDaMed = New SqlDataAdapter(strCommMed, conex)
            sqlDaMedi = New SqlDataAdapter(strCommMedi, conex)
            sqlDaEPS = New SqlDataAdapter(strCommEps, conex)

            'Poblar las tablas del dataset desde los dataAdaperts
            ' sqlDaEPS.Fill(dsPc, "EPS")
            ' 

            sqlDaPac.Fill(dsPc, "CLIENTES")
            sqlDaMed.Fill(dsPc, "ARTICULOS")
            sqlDaMedi.Fill(dsPc, "REMISIONESD")
            sqlDaEPS.Fill(dsPc, "REMISIONESC")

            'Poblar el informe con el dataSet y mostrarlo
            Dim info As New CrREMISION
            info.SetDataSource(dsPc)
            CrystalReportViewer1.ReportSource = info
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub REPORT_REMISION_Load(sender As Object, e As EventArgs) Handles Me.Load
        crystal_reports()
    End Sub
End Class