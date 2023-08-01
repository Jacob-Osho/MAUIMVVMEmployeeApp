using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUISQLLiteApp.Models
{
    public class EmployeeModel
    {
        public int EmpoyeeId { get; set; }
        //public string _employeeName;
      //  public string Name { get { return _employeeName; } set { _employeeName = value; NotifyPropertyChanged(nameof(Name)); } }
        public string Name { get; set; }
        public string EmailAdress { get; set; }
        public bool IsPartTimer { get; set; }
    }
}
