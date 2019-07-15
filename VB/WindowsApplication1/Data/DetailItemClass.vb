Imports System

Namespace WindowsApplication1
    Public Class DetailItemClass
        Public Sub New(ByVal val1 As TimeSpan, ByVal val2 As Integer, ByVal pID As Integer)
            Me.ParentID = pID
            Me.TimeStamp = val1
            Me.Value = val2
        End Sub

        Public Property ParentID As Integer
        Public Property TimeStamp As TimeSpan
        Public Property Value As Integer
    End Class
End Namespace
