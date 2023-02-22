Imports DevExpress.Data
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows
Imports System.Windows.Controls

Namespace DisplayGroupSummaries_CodeBehind

    Public Class Account

        Public Property UserName As String

        Public Property RegistrationDate As Date

        Public Property Married As Boolean

        Public Property Age As Integer
    End Class

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
            Me.grid.ItemsSource = GetAccountList().ToList()
        End Sub

        Private Iterator Function GetAccountList() As IEnumerable(Of Account)
            Yield New Account() With {.UserName = "Nick White", .RegistrationDate = Date.Today, .Married = True, .Age = 42}
            Yield New Account() With {.UserName = "Jack Rodman", .RegistrationDate = New DateTime(2009, 5, 10), .Married = False, .Age = 30}
            Yield New Account() With {.UserName = "Sandra Sherry", .RegistrationDate = New DateTime(2008, 12, 22), .Married = False, .Age = 18}
            Yield New Account() With {.UserName = "Sabrina Vilk", .RegistrationDate = Date.Today, .Married = True, .Age = 24}
            Yield New Account() With {.UserName = "Mike Pearson", .RegistrationDate = New DateTime(2008, 10, 18), .Married = True, .Age = 37}
        End Function

        Private Sub OnCustomSummaryExists(ByVal sender As Object, ByVal e As CustomSummaryExistEventArgs)
            e.Exists = e.GroupLevel = 0
        End Sub
    End Class
End Namespace
