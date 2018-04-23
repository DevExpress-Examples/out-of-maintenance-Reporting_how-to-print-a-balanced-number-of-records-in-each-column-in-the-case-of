Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports System.Data

Namespace WindowsApplication1
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub calculatedField1_GetValue(ByVal sender As Object, ByVal e As GetValueEventArgs) Handles calculatedField1.GetValue
			Dim row As WindowsApplication1.DataSet1.ChildTableRow = TryCast((CType(e.Row, DataRowView)).Row, WindowsApplication1.DataSet1.ChildTableRow)
			Dim rows() As DataRow = row.MasterTableRow.GetChildRows("MasterTable_ChildTable")
			e.Value = GetCurrentRowIndex(row,rows)
		End Sub

		Private Function GetCurrentRowIndex(ByVal row As DataSet1.ChildTableRow, ByVal rows() As DataRow) As Integer
			Dim currentTimeStampIndex As Integer = 1
			Dim numberOfFullRows As Integer= rows.Length/3
			Dim numberofAdditionalCells As Integer =rows.Length Mod 3
			For i As Integer = 0 To rows.Length - 1
				If (CType(rows(i)("TimeStamp"), TimeSpan)) < row.TimeStamp Then
					currentTimeStampIndex += 1
				End If
			Next i
			Dim columnIndex As Integer = 1
			Dim cellsCount As Integer=0
			For columnIndex = 1 To 3
				Dim currentColumnCellsCount As Integer = 0
				If columnIndex > numberofAdditionalCells Then
					cellsCount += numberOfFullRows
					currentColumnCellsCount = numberOfFullRows
				Else
					cellsCount += numberOfFullRows + 1
					currentColumnCellsCount = numberOfFullRows+1
				End If
				If currentTimeStampIndex <= cellsCount Then
					Dim rowindex As Integer = currentTimeStampIndex -(cellsCount - currentColumnCellsCount)
					Return (rowindex - 1) * 3 + columnIndex
				End If
			Next columnIndex
			Return -1
		End Function

	End Class
End Namespace
