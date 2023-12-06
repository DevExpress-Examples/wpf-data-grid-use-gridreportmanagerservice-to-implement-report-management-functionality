using System.Collections.ObjectModel;
using DevExpress.Mvvm;

namespace ReportManagerServiceExample.ViewModels {
    public class MainViewModel : ViewModelBase {
        public ObservableCollection<EmployeeViewModel> Employees { get; set; }
        public MainViewModel() {
            Employees = new ObservableCollection<EmployeeViewModel> {
                new EmployeeViewModel() { Name = "Frankie West PhD", Department = "Music", EmployeeID = 0 },
                new EmployeeViewModel() { Name = "Jett Mitchell", Department = "Music", EmployeeID = 1 },
                new EmployeeViewModel() { Name = "Garrick Stiedemann DVM", Department = "Music", EmployeeID = 2 },
                new EmployeeViewModel() { Name = "Hettie Runte", Department = "Music", EmployeeID = 3 },
                new EmployeeViewModel() { Name = "Gabe Flatley", Department = "Journalism", EmployeeID = 4 },
                new EmployeeViewModel() { Name = "Zetta Beatty", Department = "Journalism", EmployeeID = 5 },
                new EmployeeViewModel() { Name = "Ms. Luis Jewess", Department = "Journalism", EmployeeID = 6 },
                new EmployeeViewModel() { Name = "Jefferey Legros III", Department = "Management", EmployeeID = 7 },
                new EmployeeViewModel() { Name = "Margaretta Roberts", Department = "Management", EmployeeID = 8 }
            };
        }
    }
}
