using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Linq;

namespace MenuLateral.ViewModels
{
    public class ServiciosAsignadosViewModel
    {
        public ObservableCollection<Servicio> ServiciosFiltrados { get; set; }

        public ServiciosAsignadosViewModel()
        {
            ServiciosFiltrados = new ObservableCollection<Servicio>();
            CargarServiciosAsync().ConfigureAwait(false);
        }

        private async Task CargarServiciosAsync()
        {
            var servicios = new List<Servicio>();
            var serv1 = new Servicio();
            serv1.Id = 1;
            serv1.Estado = 1;
            var serv2 = new Servicio();
            serv2.Id = 2;
            serv2.Estado = 2;
            var serv3 = new Servicio();
            serv3.Id = 3;
            serv3.Estado = 3;
            servicios.Add(serv1);
            servicios.Add(serv2);
            servicios.Add(serv3);
            if (servicios != null)
            {
                var filtrados = servicios.Where(s => s.Estado == 0 || s.Estado == 1 || s.Estado == 2);
                foreach (var servicio in filtrados)
                {
                    servicio.EstadoTexto = EstadoToString(servicio.Estado);
                    ServiciosFiltrados.Add(servicio);
                }
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
                2 => "En ejecucion"
            };
        }

        public class Servicio
        {
            public int Id { get; set; }
            public int Estado { get; set; }
            public string EstadoTexto { get; set; }
        }
    }
}
