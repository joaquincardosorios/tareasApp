using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace UI
{
    public partial class TareasApp : Form
    {
        private TareaBLL tareaBLL;
        public TareasApp()
        {
            InitializeComponent();
            this.
                tareaBLL = new TareaBLL();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string descripcion = txtDescripcion.Text;
            bool estado = chb_estado.Checked;
            tareaBLL.AgregarTarea(descripcion, estado);
            ActualizarListaTareas();
        }

        private void ActualizarListaTareas()
        {
            lb_tareas.Items.Clear();
            foreach(Tarea tarea in tareaBLL.ObtenerTareas())
            {
                lb_tareas.Items.Add(tarea.Descripcion);
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if(lb_tareas.SelectedIndex != -1) 
            {
                tareaBLL.EliminarTarea(lb_tareas.SelectedIndex);
                ActualizarListaTareas();
            }
        }
    }
}
