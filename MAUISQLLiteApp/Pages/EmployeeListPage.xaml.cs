using MAUISQLLiteApp.Models;
using MAUISQLLiteApp.Models.VModels;

namespace MAUISQLLiteApp.Pages;

public partial class EmployeeListPage : ContentPage
{
	public EmployeeListPage()
	{
		InitializeComponent();
		BindingContext = new EmployeeVM();
	}

    private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
		var employee =(EmployeeModel)e.Item;
		var  emplDetailVM = new EmployeeDetailVMTwo { Employee = employee };
		var  emplDetailPage = new EmployeeDetailPage ();
        emplDetailPage.BindingContext = emplDetailVM;	
		Navigation.PushAsync(emplDetailPage);
    }
}