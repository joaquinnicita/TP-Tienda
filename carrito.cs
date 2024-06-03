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


public void AgregarCarrito (Tienda tienda, Carrito carrito, int indice, int cantidad){
    Producto producto = tienda.GetProducto(tienda, indice-1);
    if((producto.stock - cantidad) > 0){
        carrito.Lproductos.Add(producto);
        producto.stock -= cantidad;
    }
    else {
        Console.WriteLine("No hay suficiente stock del producto");
    }
}

public void MostrarCarrito(Carrito carrito)
  {
    foreach(Producto producto in carrito.Lproductos)
      Console.WriteLine("{0}, {1} unidades", producto.Nombre, producto.Stock);
  }

public void EliminarCarrito (Carrito carrito, int producto){
    carrito.Lproductos.RemoveAt(producto);
}

public float CalcularSubtotal(Carrito carrito){
    float subtotal = 0;
    foreach(Producto producto in carrito.Lproductos)
        subtotal += producto.precio;
    return subtotal;
}
}}