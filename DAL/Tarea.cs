using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Tarea
    {
        private static int contadorIds = 0;
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public bool Estado { get; set; }
        private string filePath = "C:\\Users\\Alumnos\\Downloads\\tareas.txt";

        public Tarea(string descripcion, bool estado=false)
        {
            Descripcion = descripcion;
            Estado = estado;
        }


        private string TareaString(Tarea tarea)
        {
            return tarea.Descripcion+"#"+tarea.Estado.ToString();
        }

        public List<Tarea> CargarTareas()
        {
            List<Tarea> tareas = new List<Tarea>();
            if(File.Exists(filePath))
            {
                StreamReader sr = new StreamReader(filePath);
                string line;
;
                while((line = sr.ReadLine()) != null) 
                {
                    string[] parts = line.Split('#');
                    if(parts.Length == 2) 
                    {
                        string descripcion = parts[0];
                        bool estado = parts[1] == "true" ? true : false;
                        tareas.Add(new Tarea(descripcion, estado));
                    }
                }
            }
            return tareas; 
        }

        public void EscribirTareas(List<Tarea> tareas)
        {
            StreamWriter sw = new StreamWriter(filePath, true, Encoding.ASCII);
            foreach (Tarea tarea in tareas)
            {
                sw.WriteLine(TareaString(tarea));
            }
        }
    }
}
