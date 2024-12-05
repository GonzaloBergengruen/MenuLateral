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
            Content = new Label { Text = "Página de Servicios Asignados" };
        }
    }

    public class ConfiguracionPage : ContentPage
    {
        public ConfiguracionPage()
        {
            Title = "Configuración";
            Content = new Label { Text = "Página de Configuración" };
        }
    }
}