namespace EmployeeApplication;
using EmployeeApplication.Services;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		DependencyService.Register<EmployeeDataStoreAPI>();
		DependencyService.Register<WebClientService>();

		
	}
}

