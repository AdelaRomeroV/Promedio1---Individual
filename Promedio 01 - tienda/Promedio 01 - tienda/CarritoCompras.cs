using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio_01___tienda
{
    internal class CarritoCompras : Productos
    {
        private List<Productos> productos = new List<Productos>();
        
        public void AgregarProducto(Productos p)
        {
            productos.Add(p);
        }

        public float CalculatePrecioTotal()
        {
            float precioTotal = 0;
            foreach (Productos p in productos) 
            {
                //precioTotal += productos.GetPrecio();
            }

            return precioTotal;

        }

        public void MostrarProductos()
        {
            Console.WriteLine("Productos del carrito: ");
            foreach (var producto in productos) 
            {
                Console.WriteLine(producto.GetCaracteristicas());
            }

            Console.WriteLine("Precio total: " + CalculatePrecioTotal());
        }

    }
}
