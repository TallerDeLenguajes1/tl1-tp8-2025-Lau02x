namespace Tareas
{
    enum TareasRandom
    {
        Cocinar = 0,
        Lavar = 1,
        Planchar = 2,
        Estudiar = 3,
        Programar = 4
    }

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

        public Tarea CrearTarea(int tareaId, string descripcion, int duracion)
        {
            Tarea nuevaTarea = new Tarea();
            nuevaTarea.tareaID = TareaID;
            nuevaTarea.descripcion = Descripcion;
            nuevaTarea.duracion = Duracion;
            return nuevaTarea;
        }
    }
}
 
