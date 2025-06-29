using Tareas;
//menu para hacer todas estas funciones 
int activo = 1;
string buff;
int eleccion = 0;
int cantidad = 0;
do
{
    do{
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
                System.Console.WriteLine("Cuantas tareas aleatorias creara? escriba un numero mayor a 0");
                buff = Console.ReadLine();
                cantidad = int.TryParse(buff);
            } while (!int.TryParse(buff, out cantidad) || cantidad<=0);
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


////crear aleatoriamente n tareas y guardarlas en la lista de tareas pendientes

//interfaz para mover de tareas pendientes a realizadas 

//funcion para buscar tareas pendientes por descripcion y mostrarlas en consola

//listar tareas pendientes y realizadas




List<Tarea> TareasPendientes = [];
List<Tarea> TareasCompletadas = [];

