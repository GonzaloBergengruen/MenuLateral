using MenuLateral.ViewModels;

namespace MenuLateral
{
	public partial class ServiciosAsignadosPage : ContentPage
	{
		public ServiciosAsignadosPage()
		{
			InitializeComponent();
			BindingContext = new ServiciosAsignadosViewModel();
		}
	}
}