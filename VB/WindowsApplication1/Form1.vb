Imports DevExpress.XtraReports.UI
Imports System
Imports System.Windows.Forms

Namespace WindowsApplication1
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub ShowReport()
            Dim report As XtraReport1 = New XtraReport1()
            report.DataSource = FillReportDataSource()
            Dim tool As ReportPrintTool = New ReportPrintTool(report)
            tool.ShowPreviewDialog()
        End Sub

        Private Function FillReportDataSource() As Object
            Return New DemoDataSource().GetData()
        End Function

        Private Sub button1_Click_1(sender As Object, e As EventArgs) Handles button1.Click
            ShowReport()
        End Sub
    End Class
End Namespace
