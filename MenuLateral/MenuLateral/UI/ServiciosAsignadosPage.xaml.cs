using MenuLateral.Models;
using MenuLateral.ViewModels;
using CommunityToolkit.Maui.Views;
using MenuLateral.UI;

namespace MenuLateral
{
    public partial class ServiciosAsignadosPage : ContentPage
    {
        public ServiciosAsignadosPage()
        {
            InitializeComponent();
            BindingContext = new ServiciosAsignadosViewModel();
        }

        private async void OnServicioClicked(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is Servicio servicioSeleccionado)
            {
                var popup = new DetallesServicioPopup(servicioSeleccionado);
                var resultado = await this.ShowPopupAsync(popup);

                if (resultado is bool servicioRechazado)
                {
                    var viewModel = (ServiciosAsignadosViewModel)BindingContext;
                    viewModel.ServiciosFiltrados.Remove(servicioSeleccionado);
                }
            }
        }
    }
}