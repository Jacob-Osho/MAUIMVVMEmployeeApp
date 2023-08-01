using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUISQLLiteApp.Models.VModels
{
    public partial class EmployeeDetailVMTwo:ObservableObject
    {
        [ObservableProperty]
        EmployeeModel employee;
    }
}
