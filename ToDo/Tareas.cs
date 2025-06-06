using System;
using System.Collections.Generic;

namespace TAREAS
{
    public class Tarea
    {
        public int TareaId;
        public string descripcion;
        public int duracion;

        public Tarea(int id, string des, int dur)
        {
            TareaId = id;
            descripcion = des;
            duracion = dur;

        }
    };


}