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

        /*public virtual string GetCarateristicas()
        {
            return 
        }*/
        
        public float GetPrecio()
        {
            return precio;
        }
       
    }
}
