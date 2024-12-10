using MenuLateral.Models;
using System.Windows.Input;

namespace MenuLateral.ViewModels
{
    public class DetallesServicioViewModel : BaseViewModel
    {
        public Servicio ServicioSeleccionado { get; }
        public bool EsServicioAsignado => ServicioSeleccionado?.Estado == 0 || ServicioSeleccionado?.Estado == 1 || ServicioSeleccionado?.Estado == 2;
        public bool EsServicioCompletado => ServicioSeleccionado?.Estado == 3 || ServicioSeleccionado?.Estado == 4 || ServicioSeleccionado?.Estado == 5;

        public DetallesServicioViewModel(Servicio servicio)
        {
            ServicioSeleccionado = servicio;
        }
    }
}
