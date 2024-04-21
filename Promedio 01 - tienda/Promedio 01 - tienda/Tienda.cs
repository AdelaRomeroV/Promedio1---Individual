using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio_01___tienda
{
    internal class Tienda
    {
        CarritoCompras car = new CarritoCompras();

        bool continueFlag = true;
        public void ElegirOpciones()
        {

            while (continueFlag)
            {
                Console.WriteLine("Bienvenido a la tienda, que deseas hacer:/n ");
                Console.WriteLine("1. Agregar productos");
                Console.WriteLine("2. Ver contenido del carrito");
                Console.WriteLine("3. Finalizar compra");

                string Option = Console.ReadLine();

                switch (Option)
                {
                    case "1":

                        Console.WriteLine("Caracteristica primordiales");

                        Console.WriteLine("Nombre:");
                        string nombre = Console.ReadLine();

                        Console.Write("Color:");
                        string color = Console.ReadLine();

                        Console.Write("Precio:");
                        float precio;

                        if (!float.TryParse(Console.ReadLine(), out precio))
                        {
                            Console.WriteLine("Precio invalido");
                            break;
                        }

                        Console.WriteLine("Que producto deseas agregar Tela/Arcilla");

                        string respuesta = Console.ReadLine();

                        if(respuesta.ToUpper() == "Tela")
                        {
                            Console.WriteLine("Elegiste Tela\n");
                            Console.WriteLine("Tamaño:");
                            string tamaño = Console.ReadLine();

                            Console.WriteLine("Material: ");
                            string material = Console.ReadLine();

                            car.AgregarProducto(new Tela
                            {
                                Nombre = nombre,
                                Color = color,
                                Precio = precio,
                                Tamaño = tamaño,
                                Material = material,
                            });
                        }

                        else
                        {
                            Console.WriteLine("Elegiste Arcilla\n");
                            Console.WriteLine("Peso:");
                            float peso;

                            if (!float.TryParse(Console.ReadLine(), out peso))
                            {
                                Console.WriteLine("Peso invalido");
                                break;
                            }
                            car.AgregarProducto(new Arcilla
                            {
                                Nombre = nombre,
                                Color = color,
                                Precio = precio,
                                Peso = peso,
                            });
                            Console.WriteLine("Producto agregado al carrito de compras");
                        }

                        break;

                    case "2":
                        car.MostrarProductos();
                        break;

                    case "3":
                        Console.WriteLine("Finalizar compra");
                        car.MostrarProductos();
                        break;
                }
            }
        }

    }
}
