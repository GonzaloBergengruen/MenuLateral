using CommunityToolkit.Maui.Views;
using MenuLateral.Models;

namespace MenuLateral.UI
{
    public partial class DetallesServicioPopup : Popup
    {
        public DetallesServicioPopup(Servicio servicio, bool tipo)
        {
            InitializeComponent();
            BindingContext = servicio;
        }

        private void CerrarPopup(object sender, EventArgs e)
        {
            Close();
        }

        private void RechazarServicio(object sender, EventArgs e)
        {
            Close();
        }
    }
}