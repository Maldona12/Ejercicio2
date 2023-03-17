namespace Ejercicio2
{
    class Automovil{

    public string? id = "";
    string? marca = "";
    string? modelo = "";
    int? km;
    double? precio;

    public Automovil(string? id, string? marca, string? modelo, int? km, double? precio)
    {
      this.id = id;
      this.marca = marca;
      this.modelo = modelo;
      this.km = km;
      this.precio = precio;
    }

    public override string ToString(){
      return $"ID: {this.id}, Marca: {this.marca}, Modelo {this.modelo}, KM: {this.km}, Precio: {this.precio}";
    }
  }
}