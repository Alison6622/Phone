using PhoneApp.ViewModel;

namespace PhoneApp;

public partial class MainPage : ContentPage
{

	private MainClass _vm; 
	
	public MainPage()
	{
		InitializeComponent();

		BindingContext = _vm = new MainClass();
	}
	
	private void SaveClick(object sender, EventArgs e)
	{
		_vm.SaveClick();
	}
    private void RecoveryClick(object sender, EventArgs e)
    {
	    _vm.RecoveryClick();
    }
}

