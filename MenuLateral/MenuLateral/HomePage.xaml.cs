namespace MenuLateral
{

    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }
    }

    public class ServiciosAsignadosPage : ContentPage
    {
        public ServiciosAsignadosPage()
        {
            Title = "Servicios Asignados";
            Content = new Label { Text = "P�gina de Servicios Asignados" };
        }
    }

    public class ConfiguracionPage : ContentPage
    {
        public ConfiguracionPage()
        {
            Title = "Configuraci�n";
            Content = new Label { Text = "P�gina de Configuraci�n" };
        }
    }
}