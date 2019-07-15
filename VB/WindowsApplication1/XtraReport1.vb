Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports System.Data
Imports System.Collections.Generic
Imports System.Linq

Namespace WindowsApplication1
    Partial Public Class XtraReport1
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub calculatedField1_GetValue(ByVal sender As Object, ByVal e As GetValueEventArgs)
            Dim currentRow As DetailItemClass = TryCast(e.Row, DetailItemClass)
            Dim ds As List(Of ParentItemClass) = CType(e.Report.DataSource, List(Of ParentItemClass))
            Dim childRows As List(Of DetailItemClass) = ds.Single(Function(x) x.ItemID = currentRow.ParentID).DetailItems
            e.Value = GetCurrentRowIndex(currentRow, childRows)
        End Sub

        Private Function GetCurrentRowIndex(ByVal row As DetailItemClass, ByVal rows As List(Of DetailItemClass)) As Integer
            Dim currentTimeStampIndex As Integer = 1
            Dim numberOfFullRows As Integer = rows.Count / 3
            Dim numberofAdditionalCells As Integer = rows.Count Mod 3

            For i As Integer = 0 To rows.Count - 1

                If (CType(rows(i).TimeStamp, TimeSpan)) < row.TimeStamp Then
                    currentTimeStampIndex += 1
                End If
            Next

            Dim columnIndex As Integer = 1
            Dim cellsCount As Integer = 0

            For columnIndex = 1 To 4 - 1
                Dim currentColumnCellsCount As Integer = 0

                If columnIndex > numberofAdditionalCells Then
                    cellsCount += numberOfFullRows
                    currentColumnCellsCount = numberOfFullRows
                Else
                    cellsCount += numberOfFullRows + 1
                    currentColumnCellsCount = numberOfFullRows + 1
                End If

                If currentTimeStampIndex <= cellsCount Then
                    Dim rowindex As Integer = currentTimeStampIndex - (cellsCount - currentColumnCellsCount)
                    Return (rowindex - 1) * 3 + columnIndex
                End If
            Next

            Return -1
        End Function
    End Class
End Namespace
