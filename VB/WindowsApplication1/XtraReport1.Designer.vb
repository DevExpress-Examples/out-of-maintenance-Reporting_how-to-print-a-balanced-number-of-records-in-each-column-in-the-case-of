Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication1
	Partial Public Class XtraReport1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.dataSet11 = New WindowsApplication1.DataSet1()
			Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
			Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
			Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
			Me.calculatedField1 = New DevExpress.XtraReports.UI.CalculatedField()
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
			Me.Detail.HeightF = 23F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0,0,0,0,100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrLabel1
			' 
			Me.xrLabel1.BackColor = System.Drawing.Color.Turquoise
			Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "MasterTable.Name")})
			Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0F,0F)
			Me.xrLabel1.Name = "xrLabel1"
			Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2,2,0,0,100F)
			Me.xrLabel1.SizeF = New System.Drawing.SizeF(650F,23F)
			Me.xrLabel1.StylePriority.UseBackColor = False
			Me.xrLabel1.Text = "xrLabel1"
			' 
			' TopMargin
			' 
			Me.TopMargin.HeightF = 100F
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0,0,0,0,100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' BottomMargin
			' 
			Me.BottomMargin.HeightF = 100F
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0,0,0,0,100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' dataSet11
			' 
			Me.dataSet11.DataSetName = "DataSet1"
			Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' DetailReport
			' 
			Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail1})
			Me.DetailReport.DataMember = "MasterTable.MasterTable_ChildTable"
			Me.DetailReport.DataSource = Me.dataSet11
			Me.DetailReport.Level = 0
			Me.DetailReport.Name = "DetailReport"
			' 
			' Detail1
			' 
			Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel3, Me.xrLabel2})
			Me.Detail1.HeightF = 23F
			Me.Detail1.MultiColumn.ColumnCount = 3
			Me.Detail1.MultiColumn.Direction = DevExpress.XtraReports.UI.ColumnDirection.AcrossThenDown
			Me.Detail1.MultiColumn.Mode = DevExpress.XtraReports.UI.MultiColumnMode.UseColumnCount
			Me.Detail1.Name = "Detail1"
			Me.Detail1.SortFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("calculatedField1", DevExpress.XtraReports.UI.XRColumnSortOrder.Ascending)})
			' 
			' xrLabel3
			' 
			Me.xrLabel3.BackColor = System.Drawing.Color.Gainsboro
			Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "MasterTable.MasterTable_ChildTable.Value")})
			Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(116.6667F,0F)
			Me.xrLabel3.Name = "xrLabel3"
			Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2,2,0,0,100F)
			Me.xrLabel3.SizeF = New System.Drawing.SizeF(100F,23F)
			Me.xrLabel3.StylePriority.UseBackColor = False
			Me.xrLabel3.Text = "xrLabel3"
			' 
			' xrLabel2
			' 
			Me.xrLabel2.BackColor = System.Drawing.Color.Gainsboro
			Me.xrLabel2.Borders = (CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide))
			Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "MasterTable.MasterTable_ChildTable.TimeStamp")})
			Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0F,0F)
			Me.xrLabel2.Name = "xrLabel2"
			Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2,2,0,0,100F)
			Me.xrLabel2.SizeF = New System.Drawing.SizeF(116.6667F,23F)
			Me.xrLabel2.StylePriority.UseBackColor = False
			Me.xrLabel2.StylePriority.UseBorders = False
			Me.xrLabel2.Text = "xrLabel2"
			' 
			' calculatedField1
			' 
			Me.calculatedField1.DataMember = "MasterTable.MasterTable_ChildTable"
			Me.calculatedField1.DataSource = Me.dataSet11
			Me.calculatedField1.FieldType = DevExpress.XtraReports.UI.FieldType.Int32
			Me.calculatedField1.Name = "calculatedField1"
'			Me.calculatedField1.GetValue += New DevExpress.XtraReports.UI.GetValueEventHandler(Me.calculatedField1_GetValue);
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.DetailReport})
			Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() { Me.calculatedField1})
			Me.DataMember = "MasterTable"
			Me.DataSource = Me.dataSet11
			Me.Version = "9.3"
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
		Private dataSet11 As DataSet1
		Private DetailReport As DevExpress.XtraReports.UI.DetailReportBand
		Private Detail1 As DevExpress.XtraReports.UI.DetailBand
		Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
		Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
		Private WithEvents calculatedField1 As DevExpress.XtraReports.UI.CalculatedField
	End Class
End Namespace
