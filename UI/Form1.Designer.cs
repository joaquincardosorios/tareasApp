namespace UI
{
    partial class TareasApp
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.lb_tareas = new System.Windows.Forms.ListBox();
            this.lbl_tarea = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.chb_estado = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(33, 43);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(195, 20);
            this.txtDescripcion.TabIndex = 0;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(33, 105);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 1;
            this.btn_agregar.Text = "Agregar Tarea";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(266, 222);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(169, 23);
            this.btn_eliminar.TabIndex = 2;
            this.btn_eliminar.Text = "Eliminar tarea";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // lb_tareas
            // 
            this.lb_tareas.FormattingEnabled = true;
            this.lb_tareas.Location = new System.Drawing.Point(266, 43);
            this.lb_tareas.Name = "lb_tareas";
            this.lb_tareas.Size = new System.Drawing.Size(169, 173);
            this.lb_tareas.TabIndex = 3;
            // 
            // lbl_tarea
            // 
            this.lbl_tarea.AutoSize = true;
            this.lbl_tarea.Location = new System.Drawing.Point(33, 24);
            this.lbl_tarea.Name = "lbl_tarea";
            this.lbl_tarea.Size = new System.Drawing.Size(38, 13);
            this.lbl_tarea.TabIndex = 4;
            this.lbl_tarea.Text = "Tarea:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(30, 78);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 5;
            this.lblEstado.Text = "Estado:";
            // 
            // chb_estado
            // 
            this.chb_estado.AutoSize = true;
            this.chb_estado.Location = new System.Drawing.Point(79, 77);
            this.chb_estado.Name = "chb_estado";
            this.chb_estado.Size = new System.Drawing.Size(82, 17);
            this.chb_estado.TabIndex = 6;
            this.chb_estado.Text = "Completado";
            this.chb_estado.UseVisualStyleBackColor = true;
            // 
            // TareasApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 275);
            this.Controls.Add(this.chb_estado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lbl_tarea);
            this.Controls.Add(this.lb_tareas);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txtDescripcion);
            this.Name = "TareasApp";
            this.Text = "Tareas App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.ListBox lb_tareas;
        private System.Windows.Forms.Label lbl_tarea;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.CheckBox chb_estado;
    }
}

