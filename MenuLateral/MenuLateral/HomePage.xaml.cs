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
            Title = "Configuraci�n";
            Content = new Label { Text = "P�gina de Configuraci�n" };
        }
    }
}