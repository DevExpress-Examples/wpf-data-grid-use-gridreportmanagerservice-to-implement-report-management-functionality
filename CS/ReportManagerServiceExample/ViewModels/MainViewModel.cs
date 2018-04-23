using System.Collections.ObjectModel;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.POCO;

namespace ReportManagerServiceExample.ViewModels {
    [POCOViewModel]
    public class MainViewModel {
        public virtual ObservableCollection<EmployeeViewModel> Employees { get; set; }
        public MainViewModel() {
            Employees = new ObservableCollection<EmployeeViewModel>();
            Employees.Add(ViewModelSource.Create(() => new EmployeeViewModel() { Name = "Frankie West PhD", Department = "Music", EmployeeID = 0 }));
            Employees.Add(ViewModelSource.Create(() => new EmployeeViewModel() { Name = "Jett Mitchell", Department = "Music", EmployeeID = 1 }));
            Employees.Add(ViewModelSource.Create(() => new EmployeeViewModel() { Name = "Garrick Stiedemann DVM", Department = "Music", EmployeeID = 2 }));
            Employees.Add(ViewModelSource.Create(() => new EmployeeViewModel() { Name = "Hettie Runte", Department = "Music", EmployeeID = 3 }));
            Employees.Add(ViewModelSource.Create(() => new EmployeeViewModel() { Name = "Gabe Flatley", Department = "Journalism", EmployeeID = 4 }));
            Employees.Add(ViewModelSource.Create(() => new EmployeeViewModel() { Name = "Zetta Beatty", Department = "Journalism", EmployeeID = 5 }));
            Employees.Add(ViewModelSource.Create(() => new EmployeeViewModel() { Name = "Ms. Luis Jewess", Department = "Journalism", EmployeeID = 6 }));
            Employees.Add(ViewModelSource.Create(() => new EmployeeViewModel() { Name = "Jefferey Legros III", Department = "Management", EmployeeID = 7 }));
            Employees.Add(ViewModelSource.Create(() => new EmployeeViewModel() { Name = "Margaretta Roberts", Department = "Management", EmployeeID = 8 }));
        }
    }
}