Imports System
Imports System.Collections.Generic
Imports System.Linq

Namespace WindowsApplication1
    Public Class ParentItemClass
        Public Sub New(ByVal name As String, ByVal id As Integer)
            ItemName = name
            ItemID = id
        End Sub

        Public Property ItemName As String
        Public Property ItemID As Integer
        Public Property DetailItems As List(Of DetailItemClass) = New List(Of DetailItemClass)()
    End Class
End Namespace
