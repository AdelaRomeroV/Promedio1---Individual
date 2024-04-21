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
        public string Material {  get; set; }

        public override string GetCaracteristicas()
        {
            return "Nombre: " + Nombre + "Tamaño: " + Tamaño + "Material: " + Material + "Color: " + Color + "Precio: " + Precio;
        }
    }
}
