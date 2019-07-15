Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace WindowsApplication1
    Public Class DemoDataSource
        Public Function GetData() As List(Of ParentItemClass)
            Dim masterItems As List(Of ParentItemClass) = New List(Of ParentItemClass)()
            masterItems.Add(New ParentItemClass("Row1", 1))
            masterItems.Add(New ParentItemClass("Row2", 2))
            masterItems.Add(New ParentItemClass("Row3", 3))
            masterItems.Add(New ParentItemClass("Row4", 4))
            masterItems.Add(New ParentItemClass("Row5", 5))
            masterItems(0).DetailItems.Add(New DetailItemClass(TimeSpan.FromHours(8), 10, 1))
            masterItems(0).DetailItems.Add(New DetailItemClass(TimeSpan.FromHours(8.5), 11, 1))
            masterItems(0).DetailItems.Add(New DetailItemClass(TimeSpan.FromHours(9), 12, 1))
            masterItems(1).DetailItems.Add(New DetailItemClass(TimeSpan.FromHours(8), 10, 2))
            masterItems(1).DetailItems.Add(New DetailItemClass(TimeSpan.FromHours(8.5), 11, 2))
            masterItems(1).DetailItems.Add(New DetailItemClass(TimeSpan.FromHours(9), 12, 2))
            masterItems(1).DetailItems.Add(New DetailItemClass(TimeSpan.FromHours(9.5), 13, 2))
            masterItems(2).DetailItems.Add(New DetailItemClass(TimeSpan.FromHours(8), 10, 3))
            masterItems(2).DetailItems.Add(New DetailItemClass(TimeSpan.FromHours(8.5), 11, 3))
            masterItems(2).DetailItems.Add(New DetailItemClass(TimeSpan.FromHours(9), 12, 3))
            masterItems(2).DetailItems.Add(New DetailItemClass(TimeSpan.FromHours(9.5), 13, 3))
            masterItems(2).DetailItems.Add(New DetailItemClass(TimeSpan.FromHours(10), 13, 3))
            masterItems(3).DetailItems.Add(New DetailItemClass(TimeSpan.FromHours(8), 10, 4))
            masterItems(3).DetailItems.Add(New DetailItemClass(TimeSpan.FromHours(8.5), 11, 4))
            masterItems(3).DetailItems.Add(New DetailItemClass(TimeSpan.FromHours(9), 12, 4))
            masterItems(3).DetailItems.Add(New DetailItemClass(TimeSpan.FromHours(9.5), 13, 4))
            masterItems(3).DetailItems.Add(New DetailItemClass(TimeSpan.FromHours(10), 13, 4))
            masterItems(3).DetailItems.Add(New DetailItemClass(TimeSpan.FromHours(10.5), 13, 4))
            masterItems(4).DetailItems.Add(New DetailItemClass(TimeSpan.FromHours(8), 10, 5))
            masterItems(4).DetailItems.Add(New DetailItemClass(TimeSpan.FromHours(8.5), 11, 5))
            masterItems(4).DetailItems.Add(New DetailItemClass(TimeSpan.FromHours(9), 12, 5))
            masterItems(4).DetailItems.Add(New DetailItemClass(TimeSpan.FromHours(9.5), 13, 5))
            masterItems(4).DetailItems.Add(New DetailItemClass(TimeSpan.FromHours(10), 13, 5))
            masterItems(4).DetailItems.Add(New DetailItemClass(TimeSpan.FromHours(10.5), 13, 5))
            masterItems(4).DetailItems.Add(New DetailItemClass(TimeSpan.FromHours(11), 13, 5))
            Return masterItems
        End Function
    End Class
End Namespace
