namespace Ejercicio2
{

  class Concesionaria{

    List<Automovil> listaAutomovil;
    int limiteAutomoviles;
    int noAutosActual;

    public Concesionaria(int limiteAutomoviles){

      listaAutomovil = new List<Automovil>();
      this.limiteAutomoviles = limiteAutomoviles;
      noAutosActual = 0;
    }

    public void AgregarAuto(Automovil a){
        if(a != null && noAutosActual < limiteAutomoviles && !listaAutomovil.Contains(a)){
            listaAutomovil.Add(a);
            noAutosActual++;
        }
    }

    public void MostrarAuto(string? id){

      if(id != null){
        Automovil? autoEncontrado = listaAutomovil.Find((a)=> a.id==id);
        if(autoEncontrado != null){
          Console.WriteLine(autoEncontrado.ToString());
          return;
        }
      }

        Console.WriteLine("El automovil no se encuentra en la concessionaria");
      }

      public void EliminarAuto(string? id){

      if(id != "" && noAutosActual != 0){
        Automovil? autoEcontrado = listaAutomovil.Find((a)=> a.id == id);
        if(autoEcontrado != null){
          listaAutomovil.Remove(autoEcontrado);
          noAutosActual--;
          Console.WriteLine("Automovil eliminado correctamente");
        } else {
          Console.WriteLine("El automovil no existe");
        }
      }
    }

    public void MostrarAutos(){

      foreach(Automovil item in listaAutomovil){
          Console.WriteLine(item.ToString());
	    }     
    }
    public void VaciarConcesionaria(){
      listaAutomovil = new List<Automovil>();
      noAutosActual = 0;
    }
  }
}