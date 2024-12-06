using System.Collections.Generic;
using Microsoft.Maui.Controls;

namespace MenuLateral
{

    public partial class MainFlyoutPage : FlyoutPage
    {
        public MainFlyoutPage()
        {
            InitializeComponent();

            // Define las opciones del menú
            var menuItems = new List<MenuItem>
            {
                new MenuItem { Title = "Inicio", TargetPage = typeof(HomePage) },
                new MenuItem { Title = "Datos Personales", TargetPage = typeof(DatosPersonalesPage) },
                new MenuItem { Title = "Servicios Asignados", TargetPage = typeof(ServiciosAsignadosPage) },
            };

            MenuItems.ItemsSource = menuItems;

            MenuItems.ItemTapped += (sender, e) =>
            {
                if (e.Item is MenuItem item)
                {
                    Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetPage));
                    IsPresented = false; // Cierra el menú
                }
            };
        }
    }

    public class MenuItem
    {
        public string Title { get; set; }
        public Type TargetPage { get; set; }
    }
}