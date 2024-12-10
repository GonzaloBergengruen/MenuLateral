using MenuLateral.Models;
using MenuLateral.ViewModels;
using CommunityToolkit.Maui.Views;
using MenuLateral.UI;

namespace MenuLateral.UI
{

	public partial class ServiciosCompletadosPage : ContentPage
	{
		public ServiciosCompletadosPage()
		{
			InitializeComponent();
			BindingContext = new ServiciosCompletadosViewModel();
		}

		private async void OnServicioClicked(object sender, SelectionChangedEventArgs e)
		{
			if(e.CurrentSelection.FirstOrDefault() is Servicio servicioSeleccionado)
			{
                var popup = new DetallesServicioPopup(servicioSeleccionado);
                await this.ShowPopupAsync(popup);
            }
		}
	}
}