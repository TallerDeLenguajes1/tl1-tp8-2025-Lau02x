using Tareas;
using System.Collections.Generic;
using System.Security.Cryptography;
//menu para hacer todas estas funciones 
int activo = 1;
string buff;
int eleccion = 0;
int cantidad = 0;
Random random = new Random();
int id_random = 0;
string descripcion_random = string.Empty;
int duracion_random = 0;
List<Tarea> TareasPendientes = new List<Tarea>();
List<Tarea> TareasRealizadas = new List<Tarea>();
do
{
    do
    {
        System.Console.WriteLine("----Menu----");
        System.Console.WriteLine("1:Crear n tareas aleatorias y guardar en Tareas Pendientes");
        System.Console.WriteLine("2:Mover de tareas pendientes a realizadas");
        System.Console.WriteLine("3:Buscar tareas Pendientes por descripcion");
        System.Console.WriteLine("4:Listar todas las tareas(Pendientes y realizadas)");
        buff = Console.ReadLine();
        eleccion = int.Parse(buff);
        if (!int.TryParse(buff, out eleccion))
        {
            System.Console.WriteLine("Ingresar una opcion valida Por favor");
        }
    } while (!int.TryParse(buff, out eleccion));
    switch (eleccion)
    {
        case 1:
            do
            {
                System.Console.WriteLine("Cuantas tareas aleatorias creara? escriba un numero mayor a 0: ");
                buff = Console.ReadLine();
            } while (!int.TryParse(buff, out cantidad) || cantidad <= 0);

            for (int i = 0; i < cantidad; i++)
            {
                Tarea x = new Tarea();
                id_random = random.Next(10);
                descripcion_random = ((TareasRandom)random.Next(0, 5)).ToString();
                duracion_random = random.Next(10, 101);
                TareasPendientes.Add(x.CrearTarea(id_random, descripcion_random, duracion_random));
            }
            break;
        case 2:
            do
            {
                System.Console.WriteLine("Cual tarea mover a realizada? (Elegir id) : ");
                Listar(TareasPendientes);
                buff = Console.ReadLine();
            } while (!int.TryParse(buff, out eleccion));
            Tarea tareaAMover = TareasPendientes.Find(t => t.TareaID == eleccion);
            if (tareaAMover != null)
            {
                TareasPendientes.Remove(tareaAMover);
                TareasRealizadas.Add(tareaAMover);
                System.Console.WriteLine("Tarea movida con exito");
            }
            else
            {
                System.Console.WriteLine("No se pudo mover la tarea o no existe");
            }
            break;
        case 3:
            System.Console.WriteLine("Cual tarea busca en pendientes? (Dar descripcion): ");
            Listar(TareasPendientes);
            buff = Console.ReadLine();
            Tarea tareaEncontrada = TareasPendientes.Find(t => t.Descripcion == buff);
            if (tareaEncontrada != null)
            {
                System.Console.WriteLine("Tarea encontrada con exito");
                tareaEncontrada.MostrarTarea();
            }
            else
            {
                System.Console.WriteLine("no hay tarea con esa descripcion en pendientes");
            }
            break;
        case 4:
            System.Console.WriteLine("----Tareas Pendientes----");
            Listar(TareasPendientes);
            System.Console.WriteLine("-----");
            System.Console.WriteLine("----Tareas Realizadas----");

            Listar(TareasRealizadas);
            System.Console.WriteLine("-----");
            break;
        default:
            break;
    }
    do
    {
        System.Console.WriteLine("Desea realizar otra funcion? 1:SI 2:NO");
        buff = Console.ReadLine();
        int.TryParse(buff, out activo);
        if (!int.TryParse(buff, out activo))
        {
            System.Console.WriteLine("Ingresar una opcion valida");
        }
    } while (!int.TryParse(buff, out activo));

} while (activo == 1);

void Listar(List<Tarea> Lista)
{
    foreach (Tarea t in Lista)
    {
        System.Console.WriteLine($"TareaId:{t.TareaID}, Descripcion: {t.Descripcion},duracion: {t.Duracion}");

     }
}


////crear aleatoriamente n tareas y guardarlas en la lista de tareas pendientes

//interfaz para mover de tareas pendientes a realizadas 

//funcion para buscar tareas pendientes por descripcion y mostrarlas en consola

//listar tareas pendientes y realizadas




