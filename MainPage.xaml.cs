using PhoneApp.ViewModel;

namespace PhoneApp;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void SaveClick(object sender, EventArgs e)
	{
		MainClass.name = NameText.Text;
		MainClass.surname = SurnameText.Text;
		MainClass.date = DatePic.Date;
	}
    private void RecoveryClick(object sender, EventArgs e)
    {
		NameText.Text = MainClass.name;
		SurnameText.Text = MainClass.surname;
		DatePic.Date = MainClass.date;
    }
}

