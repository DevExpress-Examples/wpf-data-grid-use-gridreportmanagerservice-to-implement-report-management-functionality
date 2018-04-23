Imports System.Collections.ObjectModel
Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Mvvm.POCO

Namespace ReportManagerServiceExample.ViewModels
    <POCOViewModel> _
    Public Class MainViewModel
        Public Overridable Property Employees() As ObservableCollection(Of EmployeeViewModel)
        Public Sub New()
            Employees = New ObservableCollection(Of EmployeeViewModel)()
            Employees.Add(ViewModelSource.Create(Function() New EmployeeViewModel() With {.Name = "Frankie West PhD", .Department = "Music", .EmployeeID = 0}))
            Employees.Add(ViewModelSource.Create(Function() New EmployeeViewModel() With {.Name = "Jett Mitchell", .Department = "Music", .EmployeeID = 1}))
            Employees.Add(ViewModelSource.Create(Function() New EmployeeViewModel() With {.Name = "Garrick Stiedemann DVM", .Department = "Music", .EmployeeID = 2}))
            Employees.Add(ViewModelSource.Create(Function() New EmployeeViewModel() With {.Name = "Hettie Runte", .Department = "Music", .EmployeeID = 3}))
            Employees.Add(ViewModelSource.Create(Function() New EmployeeViewModel() With {.Name = "Gabe Flatley", .Department = "Journalism", .EmployeeID = 4}))
            Employees.Add(ViewModelSource.Create(Function() New EmployeeViewModel() With {.Name = "Zetta Beatty", .Department = "Journalism", .EmployeeID = 5}))
            Employees.Add(ViewModelSource.Create(Function() New EmployeeViewModel() With {.Name = "Ms. Luis Jewess", .Department = "Journalism", .EmployeeID = 6}))
            Employees.Add(ViewModelSource.Create(Function() New EmployeeViewModel() With {.Name = "Jefferey Legros III", .Department = "Management", .EmployeeID = 7}))
            Employees.Add(ViewModelSource.Create(Function() New EmployeeViewModel() With {.Name = "Margaretta Roberts", .Department = "Management", .EmployeeID = 8}))
        End Sub
    End Class
End Namespace