Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Data
Imports System.Configuration
Imports Telerik.Reporting
Imports System.Data
Imports System.Data.SqlClient
Public Class REPORT_RECIBOCAJA
    Public OID, CONSECUTIVO As Integer
    Sub HC()
        BUSCAR_MAX_OID()
        Dim Report1 As New Telerik.Reporting.Report
        Dim instanceReportSource = New Telerik.Reporting.InstanceReportSource()
        ReportViewer1.ReportSource = instanceReportSource
        instanceReportSource.ReportDocument = New RP_RC
        instanceReportSource.Parameters.Add(New Telerik.Reporting.Parameter("RCOID", OID))
        ReportViewer1.RefreshReport()
    End Sub

    Private Sub REPORT_RECIBOCAJA_Load(sender As Object, e As EventArgs) Handles Me.Load
        'HC()
    End Sub
    Sub BUSCAR_MAX_OID()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_MAX_OID", conex)
            cmd.CommandType = CommandType.StoredProcedure
            '  cmd.Parameters.Add("@CONCDET", SqlDbType.VarChar).Value = TB_CONCEPTO_DESCRIPCION.Text
            Dim dr As SqlDataReader
            conex.Open()
            dr = cmd.ExecuteReader
            If dr.Read Then
                OID = dr(0)
                conex.Close()
            Else
                '    MsgBox("Este Forma de Pago no se encuentra registrado en el sistema")
                conex.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub BUSCAR_OID_CONSECUTIVO()
        Try
            Dim conex As New SqlConnection(ConfigurationManager.ConnectionStrings("conexion").ConnectionString)
            Dim cmd As New SqlCommand("BUSCAR_OID_RC_REPORT", conex)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.Add("@CONSECUTIVO", SqlDbType.Int).Value = CONSECUTIVO
            Dim dr As SqlDataReader
            conex.Open()
            dr = cmd.ExecuteReader
            If dr.Read Then
                OID = dr(0)
                HC()
                conex.Close()
            Else
                '    MsgBox("Este Forma de Pago no se encuentra registrado en el sistema")
                conex.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
