using MyWordle.ViewModel;

namespace MyWordle;

public partial class MainPage : ContentPage
{
	public MainPage(JogoViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}

