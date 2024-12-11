using System.Collections.Generic;
using MenuLateral.UI;
using Microsoft.Maui.Controls;

namespace MenuLateral
{

    public partial class MainFlyoutPage : FlyoutPage
    {
        public MainFlyoutPage()
        {
            InitializeComponent();

            // Define las opciones del menú
            var menuItems = new List<Models.MenuItem>
            {
                new Models.MenuItem ("Inicio", typeof(HomePage)),
                new Models.MenuItem ("Datos Personales", typeof(DatosPersonalesPage)),
                new Models.MenuItem ("Servicios Asignados", typeof(ServiciosAsignadosPage)),
                new Models.MenuItem ("Servicios Completados", typeof(ServiciosCompletadosPage))
            };

            MenuItems.ItemsSource = menuItems;

            MenuItems.ItemTapped += (sender, e) =>
            {
                if (e.Item is Models.MenuItem item)
                {
                    Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetPage));
#if !WINDOWS
                    IsPresented = false; // Cierra el menú
#endif
                }
            };
        }
    }
}