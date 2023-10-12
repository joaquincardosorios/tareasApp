using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class TareaBLL
    {
        private List<Tarea> tareas = new List<Tarea>();

        public void AgregarTarea(string descripcion, bool estado)
        {
            Tarea tarea = new Tarea(descripcion, estado);
            tareas.Add(tarea);
            tarea.EscribirTareas(tareas);
        }

        public List<Tarea> ObtenerTareas()
        {
            return tareas;
        }

        public void EliminarTarea(int id)
        {
            if(id >=0 && id < tareas.Count)
            {
                tareas.RemoveAt(id);
            }
        }
    }
}
