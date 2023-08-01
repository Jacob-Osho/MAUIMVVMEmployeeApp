using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUISQLLiteApp.Models.VModels
{
    public class EmployeeDetailVM :INotifyPropertyChanged
    {//https://www.youtube.com/watch?v=B-5e0PJtSDs
        public int EmpoyeeId { get; set; }
        public string _employeeName;
        public string Name { get { return _employeeName; } set { _employeeName = value; NotifyPropertyChanged(nameof(Name)); } }
        public string EmailAdress { get; set; }
        public bool IsPartTimer { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
