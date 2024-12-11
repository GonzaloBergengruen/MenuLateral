using System.Globalization;

namespace MenuLateral.Converters
{
    public class EstadoToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is int estado)
            {
                return EstadoToString(estado);
            }

            return "Estado desconocido";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException(); // No es necesario para un solo sentido de conversión
        }

        private string EstadoToString(int? estado)
        {
            return estado switch
            {
                0 => "Solicitado",
                1 => "Agendado",
                2 => "En ejecución",
                3 => "Ejecutando",
                4 => "Validando",
                5 => "Facturado",
                _ => "Desconocido"
            };
        }
    }
}
