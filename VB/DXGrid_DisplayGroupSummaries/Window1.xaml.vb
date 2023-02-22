Imports System
Imports System.Collections.Generic
Imports System.Windows
Imports System.Windows.Documents
Imports DevExpress.Data
Imports DevExpress.Xpf.Grid

Namespace DXGrid_DisplayGroupSummaries

    Public Partial Class Window1
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.grid.ItemsSource = New AccountList().GetData()
            Me.grid.GroupBy(Me.grid.Columns("Married"), ColumnSortOrder.Ascending)
        End Sub

        Private Sub CreateGroupSummaries()
            Me.grid.GroupSummary.Add(New GridSummaryItem() With {.FieldName = "Age", .SummaryType = SummaryItemType.Min})
            Me.grid.GroupSummary.Add(New GridSummaryItem() With {.FieldName = "Age", .SummaryType = SummaryItemType.Max})
        End Sub

        Private Sub grid_CustomSummaryExists(ByVal sender As Object, ByVal e As CustomSummaryExistEventArgs)
            e.Exists = e.GroupLevel = 0
        End Sub
    End Class

    Public Class AccountList

        Public Function GetData() As List(Of Account)
            Return CreateAccounts()
        End Function

        Private Function CreateAccounts() As List(Of Account)
            Dim list As List(Of Account) = New List(Of Account)()
            list.Add(New Account() With {.UserName = "Nick White", .RegistrationDate = Date.Today, .Married = True, .Age = 42})
            list.Add(New Account() With {.UserName = "Jack Rodman", .RegistrationDate = New DateTime(2009, 5, 10), .Married = False, .Age = 30})
            list.Add(New Account() With {.UserName = "Sandra Sherry", .RegistrationDate = New DateTime(2008, 12, 22), .Married = False, .Age = 18})
            list.Add(New Account() With {.UserName = "Sabrina Vilk", .RegistrationDate = Date.Today, .Married = True, .Age = 24})
            list.Add(New Account() With {.UserName = "Mike Pearson", .RegistrationDate = New DateTime(2008, 10, 18), .Married = True, .Age = 37})
            Return list
        End Function
    End Class

    Public Class Account

        Public Property UserName As String

        Public Property RegistrationDate As Date

        Public Property Married As Boolean

        Public Property Age As Integer
    End Class
End Namespace
