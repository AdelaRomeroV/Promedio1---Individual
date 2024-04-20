using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio_01___tienda
{
    internal class Tienda
    {
        Productos productos;
        bool continueFlag = true;
        public void ElegirOpciones()
        {
            while (continueFlag)
            {
                Console.WriteLine("Bienvenido a la tienda, que deseas hacer:/n ");
                Console.WriteLine("1. Agregar productos");
                Console.WriteLine("2. Ver contenido del carrito");
                Console.WriteLine("3. Finalizar compra");
                Console.WriteLine("4. Salir");

                string Option = Console.ReadLine();

                switch (Option)
                {                    
                    case "1":
                        AddAgregarProducto();
                        break;

                    case "2":
                        MostrarProductos();
                        break;

                    case "3":
                        FinalizarCompra();
                        break;
                }
            }
        }

        private void AddAgregarProducto()
        {
            Console.WriteLine("Elige que producto quieres añadir:");
            Console.WriteLine("1. Tela");
            Console.WriteLine("2. Arcilla");

            string OpcionesProducto = Console.ReadLine();

            switch (OpcionesProducto) 
            {
                case "1":
                    AddTela();
                    break;

                case "2":
                    AddArcilla();
                    break;

                default:
                    Console.WriteLine("Opcion no valida");
                    break;
                
            }
        }

        public void MostrarProductos()
        {
            bool continueFlag = true;

            while(continueFlag)
            {
                Console.WriteLine("Introduce el producto que quieres mostrar:\n ");
                Console.WriteLine("1. Arcilla");
                Console.WriteLine("2. Tela");
                Console.WriteLine("Regresa al menú anterior");

                string Option = Console.ReadLine();

                switch(Option) 
                {
                    case "1":
                        VerCarrito();
                        break;
                }
            }
        }

        public void FinalizarCompra()
        {

        }

        public void VerCarrito()
        {
            Console.WriteLine($"Producto: ");
            Console.WriteLine($"Producto: ");
            Console.WriteLine($"Producto: ");
            Console.WriteLine($"Producto: ");
        }

        public void AddArcilla()
        {
            Console.WriteLine("Introduce el nombre del producto:");
            string name = Console.ReadLine();

            Console.WriteLine("Introduce el peso del producto:");
            float peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el tamaño:");
            float tamaño = float.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el color:");
            string color = Console.ReadLine();

            Console.WriteLine("Introduce el precio:");
            float precio = float.Parse(Console.ReadLine());
        }

        public void AddTela()
        {
            Console.WriteLine("Introduce el nombre del producto:");
            string name = Console.ReadLine();

            Console.WriteLine("Introduce el tamaño del producto:");
            float tamaño = float.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el color del producto:");
            string color = Console.ReadLine();

            Console.WriteLine("Introduce el precio del producto");
            float precio = float.Parse(Console.ReadLine());
        }
    }
}
