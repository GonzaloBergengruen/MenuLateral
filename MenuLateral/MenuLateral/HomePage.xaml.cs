namespace MenuLateral
{

    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
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