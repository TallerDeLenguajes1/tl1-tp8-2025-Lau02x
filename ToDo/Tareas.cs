namespace Tareas
{
    public class Tarea
    {
    private int tareaID;
    public int TareaID { get => tareaID; set => tareaID = value; }
    private string descripcion = string.Empty;
    public string Descripcion { get => descripcion; set => descripcion = value; }
    private int duracion;
    public int Duracion { get => duracion; set => duracion = value; } // Validar que esté entre
                                                                      //10 y 100
                                                                      // Puedes añadir un constructor y métodos auxiliares si lo consideras necesario
    
    }
    public void CrearTareas(List<Tarea> listaDeTareas)
        {
          
        }

 }
