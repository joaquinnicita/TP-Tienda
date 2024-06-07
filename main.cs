// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using TiendaNamespace;
using CarritoNamespace;
using ProductoNamespace;

namespace Tp2AAT
{

    class Program
    {
        public static void Main()
        {

            Tienda tienda = new Tienda(new List<Producto>(), 1000f);
            Carrito carrito = new Carrito();


            for (int i = 1; i > 0;)
            {
                Console.WriteLine("\n\nElige una opcion: ");
                Console.WriteLine("1. Agregar producto a la tienda.");
                Console.WriteLine("2. Eliminar producto de la tienda.");
                Console.WriteLine("3. Mostrar productos de la tienda.");
                Console.WriteLine("4. Agregar producto al carrito.");
                Console.WriteLine("5. Eliminar producto del carrito.");
                Console.WriteLine("6. Cobrar.");
                Console.WriteLine("7. Mostrar dinero en caja.");
                Console.WriteLine("8. Salir.");


                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el nombre del Producto: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Ingrese en costo del producto: ");
                        float costo = float.Parse(Console.ReadLine());
                        float precio = (float)1.3 * costo;
                        Console.Write("Ingrese el stock del producto: ");
                        int stock = int.Parse(Console.ReadLine());
                        Producto p = new Producto(nombre, costo, precio, stock);
                        tienda.AgregarProducto(tienda, p);
                        break;
                    case 2:
                        tienda.MostrarProductos(tienda);
                        Console.Write("Elija el indice del producto a eliminar: ");
                        int eliminado = int.Parse(Console.ReadLine());
                        tienda.EliminarProducto(tienda, eliminado);
                        break;
                    case 3:
                        tienda.MostrarProductos(tienda);
                        break;
                    case 4:
                        tienda.MostrarProductos(tienda);
                        Console.Write("Eliga el producto para agregar al carrito: ");
                        int agregadoCarrito = int.Parse(Console.ReadLine());
                        Console.Write("Eliga la cantidad a agregar: ");
                        int cantidad = int.Parse(Console.ReadLine());
                        carrito.AgregarCarrito(tienda, agregadoCarrito, cantidad);
                        break;

                    case 5:
                        carrito.MostrarCarrito();
                        Console.Write("Elija el indice del producto a eliminar del carrito: ");
                        int eliminadoCarrito = int.Parse(Console.ReadLine());
                        carrito.EliminarCarrito (eliminadoCarrito);
                        break;

                    case 6:
                        float subtotal = carrito.CalcularSubtotal();
                        Console.WriteLine("Subtotal: {0} ", subtotal);
                        Console.Write("Ingrese el monto que pagara: ");
                        float pagar = float.Parse(Console.ReadLine());
                        if (pagar < subtotal)
                        {
                            Console.WriteLine("El monto ingresado es menor al subtotal. Por favor, ingrese un monto mayor o igual al subtotal.");
                        }
                        else
                        {
                            float vuelto = (pagar - subtotal);
                            Console.WriteLine("Su vuelto es {0}", vuelto);
                            tienda.Cobrar(tienda, subtotal);
                            carrito = new Carrito();
                        }
                        break;

                    case 7:
                        tienda.MostrarDinero(tienda);
                        break;

                    case 8:
                        Console.WriteLine("Gracias por su compra :)");
                        i = 0;
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Por favor, elija una opción del 1 al 7.");
                        break;
                }
            }
        }
    }
}