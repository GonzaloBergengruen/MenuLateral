using CommunityToolkit.Maui.Views;
using MenuLateral.Models;
using MenuLateral.ViewModels;

namespace MenuLateral.UI
{
    public partial class DetallesServicioPopup : Popup
    {
        public DetallesServicioPopup(Servicio servicio)
        {
            InitializeComponent();
            BindingContext = new DetallesServicioViewModel(servicio);
        }

        private void OnCerrarClicked(object sender, EventArgs e)
        {
            Close();
        }

        private void OnRechazarClicked(object sender, EventArgs e)
        {
            //Logica
            Close();
        }
    }
}