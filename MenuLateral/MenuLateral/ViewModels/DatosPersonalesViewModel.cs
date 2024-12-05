using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Net.Http;
using System.Text.Json;
using Microsoft.Maui.Controls;

namespace MenuLateral.ViewModels
{
    public class DatosPersonalesViewModel : INotifyPropertyChanged
    {
        private string _nombre;
        private string _email;

        public string Nombre
        {
            get => _nombre;
            set
            {
                _nombre = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged();
            }
        }

        public ICommand CargarDatosCommand { get; }

        public DatosPersonalesViewModel()
        {
            CargarDatosAsync().ConfigureAwait(false);
        }

        private async Task CargarDatosAsync()
        {
            Nombre = "Hola";
            Email = "Algo";
            //using var client = new HttpClient();
            //try
            //{
            //    var response = await client.GetStringAsync("https://api.ejemplo.com/usuario");
            //    var usuario = JsonSerializer.Deserialize<Usuario>(response);

            //    if (usuario != null)
            //    {
            //        Nombre = usuario.Nombre;
            //        Email = usuario.Email;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    await Application.Current.MainPage.DisplayAlert("Error", $"No se pudieron cargar los datos: {ex.Message}", "OK");
            //}
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private class Usuario
        {
            public string Nombre { get; set; }
            public string Email { get; set; }
        }
    }
}
