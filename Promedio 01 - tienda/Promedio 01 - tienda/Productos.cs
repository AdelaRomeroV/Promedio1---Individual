using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio_01___tienda
{
    internal class Productos
    {
        string nombres;
        string color;
        string material;
        float peso;
        float tamano;
        float precio;
        
        public Arcilla(string nombre, float peso, float tamano, string color, float precio)
        {
            this.nombres = nombre;
            this.color = color;
            this.peso = peso;
            this.tamaño = tamano;
            this.precio = precio;
        }

        public Tela(string nombre, float tamano, string material, string color, float precio)
        {
            this.nombres = nombre;
            this.color = color;
            this.tamaño = tamano;
            this.precio = precio;
            this.material = material;
        }

        public virtual string GetCarateristicas()
        {
            return "Nombre: " + nombres + "Color: " + color + "Precio: " + Precio;
        }
        
        public void GetPrecio()
        {
            return Precio;
        }
       
    }
}
