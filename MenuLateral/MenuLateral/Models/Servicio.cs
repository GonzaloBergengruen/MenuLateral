using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuLateral.Models
{
    public class Servicio
    {
        public int Id { get; set; }
        public int Estado { get; set; }
        public string EstadoTexto { get; set; }
        public DateTime HoraComienzo {  get; set; }
        public string Detalle {  get; set; }
        public short Precio { get; set; }
    }
}
