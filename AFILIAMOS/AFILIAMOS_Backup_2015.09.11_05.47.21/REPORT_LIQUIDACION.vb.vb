Imports Telerik.WinControls
Imports Telerik.WinControls.UI
Imports Telerik.WinControls.Data
Imports System.Configuration
Imports Telerik.Reporting
Imports System.Data
Imports System.Data.SqlClient
Public Class REPORT_LIQUIDACION_vb
    Public LIQUIDACIONC As Integer
    Private Sub REPORT_LIQUIDACION_vb_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim Report1 As New Telerik.Reporting.Report
        Dim instanceReportSource = New Telerik.Reporting.InstanceReportSource()
        ReportViewer1.ReportSource = instanceReportSource
        instanceReportSource.ReportDocument = New RP_LIQUIDACION
        instanceReportSource.Parameters.Add(New Telerik.Reporting.Parameter("LIQUIDACIONC", LIQUIDACIONC))
        ReportViewer1.RefreshReport()
    End Sub
End Class
