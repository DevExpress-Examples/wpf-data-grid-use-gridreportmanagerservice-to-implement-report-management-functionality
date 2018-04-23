using DevExpress.Mvvm.DataAnnotations;

namespace ReportManagerServiceExample.ViewModels {
    [POCOViewModel]
    public class EmployeeViewModel {
        public virtual int EmployeeID { get; set; }
        public virtual string Name { get; set; }
        public virtual string Department { get; set; }
    }
}
