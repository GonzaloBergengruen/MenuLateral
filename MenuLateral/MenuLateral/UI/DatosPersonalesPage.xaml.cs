using MenuLateral.ViewModels;

namespace MenuLateral;

public partial class DatosPersonalesPage : ContentPage
{
	public DatosPersonalesPage()
	{
		InitializeComponent();
		BindingContext = new DatosPersonalesViewModel();
	}
}