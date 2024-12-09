using System.Collections.ObjectModel;
using MenuLateral.Models;
using System.Windows.Input;

namespace MenuLateral.ViewModels
{
    public class ServiciosAsignadosViewModel : BindableObject
    {
        public ObservableCollection<Servicio> ServiciosFiltrados { get; set; }
        public Servicio ServicioSeleccionado { get; set; }
        private bool _detallesVisibles;
        public bool DetalleVisible
        {
            get => _detallesVisibles;
            set
            {
                _detallesVisibles = value;
                OnPropertyChanged();
            }
        }
        public ICommand MostrarDetalleCommand { get; }

        public ServiciosAsignadosViewModel()
        {
            ServiciosFiltrados = new ObservableCollection<Servicio>();
            DetalleVisible = false;
            MostrarDetalleCommand = new Command<Servicio>(MostrarDetallesServicio);
            Task.Run(async () => await CargarServiciosAsync());
        }

        public void MostrarDetallesServicio(Servicio servicio)
        {
            ServicioSeleccionado = servicio;
            DetalleVisible = true;
            OnPropertyChanged(nameof(ServicioSeleccionado));
        }

        private async Task CargarServiciosAsync()
        {
            try
            {
                // Simulación de datos locales en lugar de consumir una API
                var servicios = new List<Servicio>
                {
                    new Servicio { Id = 1, Estado = 0, HoraComienzo = DateTime.Now.AddHours(1), Detalle = "Revisión técnica", Precio = 100 },
                    new Servicio { Id = 2, Estado = 1, HoraComienzo = DateTime.Now.AddHours(3), Detalle = "Cambio de aceite", Precio = 50 },
                    new Servicio { Id = 3, Estado = 2, HoraComienzo = DateTime.Now.AddHours(5), Detalle = "Lavado completo", Precio = 30 },
                    new Servicio { Id = 4, Estado = 5, HoraComienzo = DateTime.Now.AddHours(2), Detalle = "Algo", Precio = 100}
                };

                // Filtramos los servicios por estado permitido
                var filtrados = servicios.Where(s => s.Estado == 0 || s.Estado == 1 || s.Estado == 2);

                // Agregamos los servicios filtrados a la colección observable
                foreach (var servicio in filtrados)
                {
                    servicio.EstadoTexto = EstadoToString(servicio.Estado);
                    ServiciosFiltrados.Add(servicio);
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores
                await Application.Current.MainPage.DisplayAlert("Error", $"Ocurrió un error al cargar los servicios: {ex.Message}", "OK");
            }

            //using var client = new HttpClient();
            //try
            //{
            //    var response = await client.GetStringAsync("");
            //    var servicios = JsonSerializer.Deserialize<List<Servicio>>(response);
            //
            //    if (servicios != null)
            //    {
            //        var filtrados = servicios.Where(s => s.Estado == 0 || s.Estado == 1 || s.Estado == 2);
            //        foreach (var servicio in filtrados)
            //        {
            //            servicio.EstadoTexto = EstadoToString(servicio.Estado);
            //            ServiciosFiltrados.Add(servicio);
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    await Application.Current.MainPage.DisplayAlert("Error", $"No se pudieron cargar los servicios: {ex.Message}", "OK");
            //}
        }

        private string EstadoToString(int estado)
        {
            return estado switch
            {
                0 => "Solicitado",
                1 => "Agendado",
                2 => "En ejecucion",
                _ => ""
            };
        }
    }
}
