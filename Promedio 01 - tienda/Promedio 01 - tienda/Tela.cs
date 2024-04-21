using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio_01___tienda
{
    internal class Tela : Productos
    {
        public string Tamaño { get; set; }
        public string Meterial { get; set; }

        public override string GetCarateristicas() 
        {
            return "Nombres: " + nombre + "Tamaño: " + Tamaño + "Material: " + Materiales + "Color: " + Color + "Precio: " + Precio;
        }
    }
}
