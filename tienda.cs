using System.Collections.Generic;
using ProductoNamespace;

namespace TiendaNamespace {
public class Tienda{

/*  public void Vender(Tienda tienda, Producto producto, int cantidad){
    for(int i = 0; i < cantidad; i++){
      tienda.Lproductos.Remove(producto);
      tienda.Remove(tienda.producto)
    }
  }
*/

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
    foreach(Producto producto in tienda.Lproductos)
      Console.WriteLine("{0}, {1} unidades en stock", producto.Nombre, producto.Stock);

  }

  public Producto GetProducto (Tienda tienda, int indice){
      if (indice >= 0 && indice < tienda.Lproductos.Count)
      {
        return tienda.Lproductos[indice];
      }
      else
      {
        return null;
      }
    }

  public List<Producto> Lproductos = new List<Producto>();
  private float dinero = 0;

  public Tienda(List<Producto> productos, float dinero) {
    Lproductos = productos;
    this.dinero = dinero;
  }
}
}