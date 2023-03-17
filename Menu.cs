namespace Ejercicio2
{

  class Menu{

    Concesionaria concesionaria = new Concesionaria(10);
    public bool ShowMenu(){
      Console.Clear();
      Console.WriteLine("Selecciona una opcion:");
      Console.WriteLine("1.- Agregar Automóvil");
      Console.WriteLine("2.- Eliminar Automóvil");
      Console.WriteLine("3.- Buscar Automóvil");
      Console.WriteLine("4.- Listar todos");
      Console.WriteLine("5.- Salir");
      Console.Write("Opción: ");

      switch(Console.ReadLine()){
        case "1":
          AgregarAutomovil();
          Console.ReadLine();
          return true;
        case "2":
          EliminarAutomovil();
          Console.ReadLine();
          return true;
        case "3":
          BuscarAutomovil();
          Console.ReadLine();
          return true;
        case "4":
          MostrarTodos();
          Console.ReadLine();
          return true;
        case "5":
          return false;
        default:
          return true;
      }
    }

    public void AgregarAutomovil(){

      Console.Clear();
      Console.WriteLine("Creando nuevo automóvil...");

      Console.Write("ID: ");
      string? id = Console.ReadLine();

      Console.Write("Marca: ");
      string? marca = Console.ReadLine();

      Console.Write("Modelo: ");
      string? modelo = Console.ReadLine();

      Console.Write("KM: ");
      string? km = Console.ReadLine();

      Console.Write("Precio: ");
      string? precio = Console.ReadLine();

      Automovil nuevo = new Automovil(id, marca, modelo, int.Parse(km), double.Parse(precio));
      concesionaria.AgregarAuto(nuevo);
      Console.WriteLine("Automovil agregado correctamente.");
    }

    public void EliminarAutomovil(){
      Console.Clear();
      Console.Write("Ingrese el id del auto a eliminar: ");
      string? id = Console.ReadLine();
      concesionaria.EliminarAuto(id);
    }

    public void BuscarAutomovil(){
      Console.Clear();
      Console.Write("Ingrese el id del auto a encontrar: ");
      string? id = Console.ReadLine();
      concesionaria.MostrarAuto(id);
    }

    public void MostrarTodos(){
      Console.Clear();
      concesionaria.MostrarAutos();
    }
  }
}