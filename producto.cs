using System.Collections.Generic;

namespace ProductoNamespace{

// Clase
public class Producto {

  public string nombre = "";
  public float costo = 0;
  public float precio;
  public int stock;

  // Constructor
  public Producto(string nombre, float costo, float precio, int stock) {

      this.nombre = nombre;
      this.costo = costo;
      this.precio = precio;
      this.stock = stock;

  if (this.nombre.Length == 0)
    throw new System.Exception("El nombre del producto no puede estar vacío");

  }
  // Propiedades
  public string Nombre
  {
      get { return nombre; }
      set {
        if (this.nombre.Length == 0)
          throw new System.Exception("El nombre del producto no puede estar vacío");
        nombre = value; 
      }
  }

  public float Costo{
    get { return costo; }
    set { costo = value;
      if (costo == 0)
        throw new System.Exception("El costo no puede ser 0");
    }
  }

  public float Precio{
    get { return precio; }
    set { precio = (float)1.3 * costo; }
  }

  public int Stock{
    get { return stock; }
    set { stock = value; }
  }
}
  }

