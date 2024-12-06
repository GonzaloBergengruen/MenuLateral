using MenuLateral.Models;
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

		private void OnServicioClicked(object sender, SelectionChangedEventArgs e)
		{
			if (BindingContext is ServiciosAsignadosViewModel viewModel)
			{
				viewModel.MostrarDetallesServicio(e.CurrentSelection.FirstOrDefault() as Servicio);
			}
		}
	}
}