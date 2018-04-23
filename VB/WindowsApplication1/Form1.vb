Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim ds As New DataSet1()
			ds.MasterTable.AddMasterTableRow("Row1",1)
			ds.MasterTable.AddMasterTableRow("Row2",2)
			ds.MasterTable.AddMasterTableRow("Row3",3)
			ds.MasterTable.AddMasterTableRow("Row4",4)
			ds.MasterTable.AddMasterTableRow("Row5",5)

			ds.ChildTable.Rows.Add(New Object() {TimeSpan.FromHours(8),10,1 })
			ds.ChildTable.Rows.Add(New Object() { TimeSpan.FromHours(8.5),11,1 })
			ds.ChildTable.Rows.Add(New Object() { TimeSpan.FromHours(9),12,1 })

			ds.ChildTable.Rows.Add(New Object() { TimeSpan.FromHours(8),10,2 })
			ds.ChildTable.Rows.Add(New Object() { TimeSpan.FromHours(8.5),11,2 })
			ds.ChildTable.Rows.Add(New Object() { TimeSpan.FromHours(9),12,2 })
			ds.ChildTable.Rows.Add(New Object() { TimeSpan.FromHours(9.5),13,2 })

			ds.ChildTable.Rows.Add(New Object() { TimeSpan.FromHours(8),10,3 })
			ds.ChildTable.Rows.Add(New Object() { TimeSpan.FromHours(8.5),11,3 })
			ds.ChildTable.Rows.Add(New Object() { TimeSpan.FromHours(9),12,3 })
			ds.ChildTable.Rows.Add(New Object() { TimeSpan.FromHours(9.5),13,3 })
			ds.ChildTable.Rows.Add(New Object() { TimeSpan.FromHours(10),13,3 })

			ds.ChildTable.Rows.Add(New Object() { TimeSpan.FromHours(8),10,4 })
			ds.ChildTable.Rows.Add(New Object() { TimeSpan.FromHours(8.5),11,4 })
			ds.ChildTable.Rows.Add(New Object() { TimeSpan.FromHours(9),12,4 })
			ds.ChildTable.Rows.Add(New Object() { TimeSpan.FromHours(9.5),13,4 })
			ds.ChildTable.Rows.Add(New Object() { TimeSpan.FromHours(10),13,4 })
			ds.ChildTable.Rows.Add(New Object() { TimeSpan.FromHours(10.5),13,4 })

			ds.ChildTable.Rows.Add(New Object() { TimeSpan.FromHours(8),10,5 })
			ds.ChildTable.Rows.Add(New Object() { TimeSpan.FromHours(8.5),11,5 })
			ds.ChildTable.Rows.Add(New Object() { TimeSpan.FromHours(9),12,5 })
			ds.ChildTable.Rows.Add(New Object() { TimeSpan.FromHours(9.5),13,5 })
			ds.ChildTable.Rows.Add(New Object() { TimeSpan.FromHours(10),13,5 })
			ds.ChildTable.Rows.Add(New Object() { TimeSpan.FromHours(10.5),13,5 })
			ds.ChildTable.Rows.Add(New Object() { TimeSpan.FromHours(11),13,5 })

			Dim report As New XtraReport1()
			report.DataSource = ds
			Dim tool As New ReportPrintTool(report)
			tool.ShowPreviewDialog()
		End Sub
	End Class
End Namespace