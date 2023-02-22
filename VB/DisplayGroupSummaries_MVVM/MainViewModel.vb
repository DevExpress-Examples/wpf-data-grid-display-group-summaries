Imports DevExpress.Mvvm
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.Xpf
Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel

Namespace DisplayGroupSummaries_MVVM

    Public Class Account

        Public Property UserName As String

        Public Property RegistrationDate As Date

        Public Property Married As Boolean

        Public Property Age As Integer
    End Class

    Public Class MainViewModel
        Inherits ViewModelBase

        Public ReadOnly Property AccountList As ObservableCollection(Of Account)

        Public Sub New()
            AccountList = New ObservableCollection(Of Account)(GetAccountList())
        End Sub

        Private Iterator Function GetAccountList() As IEnumerable(Of Account)
            Yield New Account() With {.UserName = "Nick White", .RegistrationDate = Date.Today, .Married = True, .Age = 42}
            Yield New Account() With {.UserName = "Jack Rodman", .RegistrationDate = New DateTime(2009, 5, 10), .Married = False, .Age = 30}
            Yield New Account() With {.UserName = "Sandra Sherry", .RegistrationDate = New DateTime(2008, 12, 22), .Married = False, .Age = 18}
            Yield New Account() With {.UserName = "Sabrina Vilk", .RegistrationDate = Date.Today, .Married = True, .Age = 24}
            Yield New Account() With {.UserName = "Mike Pearson", .RegistrationDate = New DateTime(2008, 10, 18), .Married = True, .Age = 37}
        End Function

        <Command>
        Public Sub CustomSummaryExistsCommand(ByVal args As RowSummaryExistsArgs)
            args.Exists = args.GroupPath(0).GroupLevel = 0
        End Sub
    End Class
End Namespace
