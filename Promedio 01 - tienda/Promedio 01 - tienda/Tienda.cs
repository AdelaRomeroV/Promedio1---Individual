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
            while(continueFlag) 
            {
                Console.WriteLine("Bienvenido a la tienda, que deseas hacer:/n ");
                Console.WriteLine("1. Contenido del carrito");
                Console.WriteLine("2. Agregar productos");
                Console.WriteLine("Comprar Productos");

                string Option = Console.ReadLine();

                switch(Option) 
                {
                    case "1":

                        break;
                }
            }
        }
    }
}
