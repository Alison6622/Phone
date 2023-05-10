using PhoneApp.ViewModel;

namespace PhoneApp;

public partial class MainPage : ContentPage
{

	private MainClass _vm; 
	
	public MainPage()
	{
		InitializeComponent();

		BindingContext = new MainViewModel();
	}
}

