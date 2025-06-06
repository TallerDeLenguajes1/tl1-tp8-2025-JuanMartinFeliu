using TAREAS;
using System;

List<Tarea> TareasPendientes = new List<Tarea>();
List<Tarea> TareasRealizadas = new List<Tarea>();
Random random = new Random();



int decidirQueTareaHacer = 0;
int seguir = 0;

int id;
string? descripcion;
int duracion;

while(decidirQueTareaHacer != 6){
        Console.WriteLine("\n------MENU------\n");
        Console.WriteLine("1-Cargar tareas pendientes\n");
        Console.WriteLine("2-Cargar tareas completadas\n");
        Console.WriteLine("3-Mostrar tareas pendientes y tareas completadas\n");
        Console.WriteLine("4-Consultar tarea por id\n");
        Console.WriteLine("5-Consultar tarea por nombre\n");
        Console.WriteLine("6-Salir\n");
        Console.WriteLine("Ingrese el numero de lo que quiere hacer:");
        decidirQueTareaHacer = Convert.ToInt32(Console.ReadLine());
    switch (decidirQueTareaHacer)
    {
        case 1:
            while (seguir != 2)
            {
                id = random.Next(11);
                Console.WriteLine("\nIngrese la descripcion de la tarea:");
                descripcion = Console.ReadLine();
                Console.WriteLine("\nIngrese la duracion de la tarea:");
                duracion = Convert.ToInt32(Console.ReadLine());

                TareasPendientes.Add(new Tarea(id, descripcion, duracion));

                Console.WriteLine("\nQuiere seguir agregando tareas pendientes?\n1-Si\n2-No");
                Console.WriteLine("\nIngrese su decision:");
                seguir = Convert.ToInt32(Console.ReadLine());
            }
            break;
        case 2:
            Console.WriteLine("Las Tareas Pendientes actuales son:");
            for (int i = 0; i < TareasPendientes.Count; i++)
            {
                Console.WriteLine(TareasPendientes[i].TareaId);
                Console.WriteLine(TareasPendientes[i].descripcion);
                Console.WriteLine(TareasPendientes[i].duracion);
                Console.WriteLine("--------------------------------------");
            }

            Console.WriteLine("Ingrese la ID de la tarea que quiere mover hacia Realizadas:");
            int id_Transferir = Convert.ToInt32(Console.ReadLine());

            Tarea? tareaAMover = TareasPendientes.FirstOrDefault(t => t.TareaId == id_Transferir);

            if (tareaAMover != null)
            {
                TareasRealizadas.Add(tareaAMover);           // agregar a realizadas
                TareasPendientes.Remove(tareaAMover);         // eliminar de pendientes
                Console.WriteLine("Tarea movida correctamente.");
            }
            else
            {
                Console.WriteLine("No se encontró ninguna tarea con ese ID.");
            }
            break;
        case 3:
            Console.WriteLine("Tareas Pendientes:");
            Console.WriteLine("--------------------------------------");
            for (int i = 0; i < TareasPendientes.Count; i++)
            {
                Console.WriteLine("ID:" + TareasPendientes[i].TareaId);
                Console.WriteLine("Descripcion:" + TareasPendientes[i].descripcion);
                Console.WriteLine("Duracion:" + TareasPendientes[i].duracion);
                Console.WriteLine("--------------------------------------");
            }

            Console.WriteLine("Tareas Realizadas:");
            Console.WriteLine("--------------------------------------");
            for (int i = 0; i < TareasRealizadas.Count; i++)
            {
                Console.WriteLine("ID:" + TareasRealizadas[i].TareaId);
                Console.WriteLine("Descripcion:" + TareasRealizadas[i].descripcion);
                Console.WriteLine("Duracion:" + TareasRealizadas[i].duracion);
                Console.WriteLine("--------------------------------------");
            }

            break;
        case 4:
            Console.WriteLine("Ingrese el ID de la tarea que quiere buscar:");
            int idParaLlamar = Convert.ToInt32(Console.ReadLine());


            Tarea? tareaBuscadaPorID = TareasPendientes.FirstOrDefault(t => t.TareaId == idParaLlamar);

            if (tareaBuscadaPorID != null)
            {
                Console.WriteLine("ID:" + tareaBuscadaPorID.TareaId);
                Console.WriteLine("Descripcion:" + tareaBuscadaPorID.descripcion);
                Console.WriteLine("Duracion:" + tareaBuscadaPorID.duracion);
            }
            else
            {
                Console.WriteLine("No se encontró ninguna tarea pendiente con esa ID :( ");

            }
            break;
        case 5:
            Console.WriteLine("Ingrese el ID de la tarea que quiere buscar:");
            string nombreParaLlamar = Console.ReadLine();


            Tarea? tareaBuscadaPorDescripcion = TareasPendientes.FirstOrDefault(t => t.descripcion == nombreParaLlamar);

            if (tareaBuscadaPorDescripcion != null)
            {
                Console.WriteLine("ID:" + tareaBuscadaPorDescripcion.TareaId);
                Console.WriteLine("Descripcion:" + tareaBuscadaPorDescripcion.descripcion);
                Console.WriteLine("Duracion:" + tareaBuscadaPorDescripcion.duracion);
            }
            else
            {
                Console.WriteLine("No se encontró ninguna tarea pendiente con esa ID :( ");
                
            }
            break;
        }

        
}