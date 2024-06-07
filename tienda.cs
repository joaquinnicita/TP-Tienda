using System.Collections.Generic;
using ProductoNamespace;
using CarritoNamespace;
using System;

namespace TiendaNamespace {
public class Tienda{

  public void AgregarProducto(Tienda tienda, Producto producto)
  {
    tienda.Lproductos.Add(producto);
  }

  public void EliminarProducto(Tienda tienda, int indice)
  {
    tienda.Lproductos.RemoveAt(indice-1);
  }

  public void MostrarProductos(Tienda tienda)
  {
    int indice = 1;
    foreach(Producto producto in tienda.Lproductos){
      Console.WriteLine("\n({3}) {0} \n${1} \n{2} unidades en stock", producto.Nombre, producto.precio, producto.Stock, indice);
      indice++;
    }
  }

  public Producto GetProducto (int indice){
      if (indice >= 0 && indice < Lproductos.Count)
      {
        return Lproductos[indice];
      }
      else
      {
        return null;
      }
    }

  public void Cobrar(Tienda tienda, float subtotal)
  {
    tienda.dinero += subtotal;
  }

  public void MostrarDinero(Tienda tienda)
  {
    Console.WriteLine("Dinero en caja: {0}", tienda.dinero);
  }

  public List<Producto> Lproductos = new List<Producto>();
  private float dinero = 0;

  public Tienda(List<Producto> productos, float dinero) {
    Lproductos = productos;
    this.dinero = dinero;
  }
}
}