using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUISQLLiteApp.Models.VModels
{
    public partial class EmployeeVM : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<EmployeeModel> employees = new();
        [ObservableProperty]
        EmployeeModel employee = new();
        [RelayCommand]
        void Add()
        {
            Employees.Add(Employee);
            Employee = new EmployeeModel();
        }
    }
}
