using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio_01___tienda
{
    internal class Tienda
    {
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
                    case "0":
                        continueFlag = false;
                        break;

                    case "1":
                        AddAgregarProducto();
                        break;

                    //case "2":

                }
            }
        }

        private void AddAgregarProducto()
        {
            Console.WriteLine("Elige que producto quieres elegir:");
            Console.WriteLine("Tela o Arcilla");

            string OpcionesProducto = Console.ReadLine();

            switch (OpcionesProducto) 
            {
                case "Arcilla":
                    AddArcilla();
                    break;

                case "Tela":

                    break;
            }
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

        public void Tela()
        {
            Console.WriteLine("Introduce el nombre del producto:");
            string name = Console.ReadLine();

            Console.WriteLine("Introduce el tamaño del producto:");
            float tamaño = float.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el color del producto:");
        }
    }
}
