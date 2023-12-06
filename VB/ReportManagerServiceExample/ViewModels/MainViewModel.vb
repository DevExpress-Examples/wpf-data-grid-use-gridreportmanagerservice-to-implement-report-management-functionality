Imports System.Collections.ObjectModel
Imports DevExpress.Mvvm

Namespace ReportManagerServiceExample.ViewModels

    Public Class MainViewModel
        Inherits ViewModelBase

        Public Property Employees As ObservableCollection(Of EmployeeViewModel)

        Public Sub New()
            Employees = New ObservableCollection(Of EmployeeViewModel) From {New EmployeeViewModel() With {.Name = "Frankie West PhD", .Department = "Music", .EmployeeID = 0}, New EmployeeViewModel() With {.Name = "Jett Mitchell", .Department = "Music", .EmployeeID = 1}, New EmployeeViewModel() With {.Name = "Garrick Stiedemann DVM", .Department = "Music", .EmployeeID = 2}, New EmployeeViewModel() With {.Name = "Hettie Runte", .Department = "Music", .EmployeeID = 3}, New EmployeeViewModel() With {.Name = "Gabe Flatley", .Department = "Journalism", .EmployeeID = 4}, New EmployeeViewModel() With {.Name = "Zetta Beatty", .Department = "Journalism", .EmployeeID = 5}, New EmployeeViewModel() With {.Name = "Ms. Luis Jewess", .Department = "Journalism", .EmployeeID = 6}, New EmployeeViewModel() With {.Name = "Jefferey Legros III", .Department = "Management", .EmployeeID = 7}, New EmployeeViewModel() With {.Name = "Margaretta Roberts", .Department = "Management", .EmployeeID = 8}}
        End Sub
    End Class
End Namespace
