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
        float tamaño;
        float precio;
        
        public Arcilla(string nombre, float peso, float tamaño, string color, float precio)
        {
            this.nombres = nombre;
            this.color = color;
            this.peso = peso;
            this.tamaño = tamaño;
            this.precio = precio;
        }

        public Tela(string nombre, float tamaño, string material, string color, float precio)
        {
            this.nombres = nombre;
            this.color = color;
            this.tamaño = tamaño;
            this.precio = precio;
            this.material = material;
        }

        public void GetCarateristicas()
        {

        }
        
        public void GetPrecio()
        {

        }
       
    }
}
