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
                Console.WriteLine("Elige una opcion: ");
                Console.WriteLine("1. Agregar producto a la tienda.");
                Console.WriteLine("2. Eliminar producto de la tienda.");
                Console.WriteLine("3. Mostrar productos de la tienda.");
                Console.WriteLine("4. Agregar producto al carrito.");
                Console.WriteLine("5. Eliminar producto del carrito.");
                Console.WriteLine("6. Cobrar.");
                Console.WriteLine("7. Salir.");


                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese el nombre del Producto: ");
                        string nombre = Console.ReadLine();
                        Console.Write("Ingrese el Precio del producto: ");
                        float precio = float.Parse(Console.ReadLine());
                        Console.Write("Ingrese en costo del producto: ");
                        float costo = float.Parse(Console.ReadLine());
                        Console.Write("Ingrese el stock del producto: ");
                    int stock = int.Parse(Console.ReadLine());
                        Producto p = new Producto(nombre, precio, costo, stock);
                        tienda.AgregarProducto(tienda, p);
                        break;
                    case 2:
                        tienda.MostrarProductos(tienda);
                        Console.WriteLine("Elja el indice del producto a eliminar: ");
                        int eliminado = int.Parse(Console.ReadLine());
                        tienda.EliminarProducto(tienda, eliminado);
                        break;
                    case 3:
                        tienda.MostrarProductos(tienda);
                        break;
                    case 4:
                        tienda.MostrarProductos(tienda);
                        Console.WriteLine("Eliga el producto para agregar al carrito: ");
                        int agregadoCarrito = int.Parse(Console.ReadLine());
                        Console.WriteLine("Eliga la cantidad a agregar: ");
                        int cantidad = int.Parse(Console.ReadLine());
                        carrito.AgregarCarrito(tienda, carrito, agregadoCarrito, cantidad);
                        break;

                    case 5:
                        carrito.MostrarCarrito(carrito);
                        Console.WriteLine("Elija el indice del producto a eliminar del carrito: ");
                        int eliminadoCarrito = int.Parse(Console.ReadLine());
                        carrito.EliminarCarrito(carrito, eliminadoCarrito);
                        break;

                    case 6:
                        float subtotal = carrito.CalcularSubtotal(carrito);
                        Console.WriteLine("Subtotal: {0} ", subtotal);
                        Console.Write("Ingrese el total a pagar: ");
                        float pagar = float.Parse(Console.ReadLine());
                        if (pagar < subtotal)
                        {
                            Console.WriteLine("El monto ingresado es menor al subtotal. Por favor, ingrese un monto mayor o igual al subtotal.");
                        }
                        else
                        {
                            float vuelto = (pagar - subtotal);
                            Console.WriteLine("Su vuelto es {0}", vuelto);
                            carrito = new Carrito();
                        }
                        break;

                    case 7:
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

/*
Main:
Inicializa una instancia de Tienda con un dinero inicial.
Inicializa una instancia de Carrito.
Contiene un bucle iterativo para el menú:
Opciones:
Agregar producto a la tienda.
Eliminar producto de la tienda.
Mostrar productos de la tienda.
Agregar producto al carrito.
Eliminar producto del carrito.
Cobrar.
Salir.
Pasos del Programa
Inicialización:

Crear instancias de Tienda y Carrito.
Menú Iterativo:

Mostrar el menú.
Leer la opción seleccionada por el usuario.
Ejecutar la acción correspondiente:
Agregar/Eliminar productos en la tienda.
Mostrar productos disponibles.
Agregar/Eliminar productos en el carrito.
Calcular y procesar el pago.
Salir del programa.
Flujo de Trabajo
Agregar Producto a la Tienda:

Pedir al usuario el nombre, costo y stock del producto.
Crear una instancia de Producto.
Llamar a AgregarProducto en la instancia de Tienda.
Eliminar Producto de la Tienda:

Mostrar lista de productos.
Pedir al usuario el índice del producto a eliminar.
Llamar a EliminarProducto en la instancia de Tienda.
Mostrar Productos de la Tienda:

Llamar a MostrarProductos en la instancia de Tienda.
Agregar Producto al Carrito:

Mostrar lista de productos.
Pedir al usuario el índice del producto y la cantidad.
Llamar a AgregarProducto en la instancia de Carrito.
Eliminar Producto del Carrito:

Pedir al usuario el índice del producto en el carrito a eliminar.
Llamar a EliminarProducto en la instancia de Carrito.
Cobrar:

Calcular el subtotal llamando a CalcularSubtotal en la instancia de Carrito.
Pedir al usuario la cantidad con la que pagará.
Llamar a Cobrar en la instancia de Tienda.
Vaciar el carrito llamando a VaciarCarrito en la instancia de Carrito.
*/