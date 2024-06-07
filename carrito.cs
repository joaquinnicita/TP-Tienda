using System;
using System.Collections.Generic;
using System.Data.Common;
using ProductoNamespace;
using TiendaNamespace;

namespace CarritoNamespace {

public class Carrito
{
    public List<Producto> Lproductos { get; set; }

    // Constructor
    public Carrito()
    {
        Lproductos = new List<Producto>();
    }


    public void AgregarCarrito(Tienda tienda, int indice, int cantidad)
    {
        if (indice - 1 >= 0 && indice - 1 < tienda.Lproductos.Count)
        {
            Producto producto = tienda.GetProducto(indice - 1);
            if (producto.stock >= cantidad)
            {
                Producto productoCarrito = new Producto(producto.Nombre, producto.Costo, producto.Precio, cantidad);
                Lproductos.Add(productoCarrito);
                producto.stock -= cantidad;
            }
            else
            {
                Console.WriteLine("No hay suficiente stock del producto");
            }
        }
        else
        {
            Console.WriteLine("Índice fuera de rango");
        }
    }


public void MostrarCarrito()
  {
      int indice = 1;
      foreach(Producto producto in Lproductos){
        Console.WriteLine("\n({3}) {0} \n${1} \n{2} unidades en stock", producto.nombre, producto.precio, producto.stock, indice);
        indice++;
      }
  }

public void EliminarCarrito (int indice) {
        if (indice - 1 < Lproductos.Count && indice - 1 >= 0)
        {
            Lproductos.RemoveAt(indice - 1);
        }
        else
        {
            Console.WriteLine("Índice fuera de rango");
        }
    }

public float CalcularSubtotal()
    {
        float subtotal = 0;
        foreach (Producto producto in Lproductos)
        {
            subtotal += producto.Precio * producto.Stock;
        }
        return subtotal;
    }
}}