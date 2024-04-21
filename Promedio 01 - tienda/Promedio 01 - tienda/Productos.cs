using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio_01___tienda
{
    internal class Productos
    {        
        public string Nombre { get; set; }
        public string Color { get; set; }
        public string Precio { get; set; }

        public virtual string GetCaracteristicas()
        {
            return "Nombres: " + Nombre + "Color: " + Color + "Precio: " + Precio;
        }
        
        public float GetPrecio()
        {
            return Precio;
        }
    }
}
