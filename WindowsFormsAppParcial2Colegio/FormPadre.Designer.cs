namespace WindowsFormsAppParcial2Colegio
{
    partial class FormPadre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ingresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoDeAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoDeProfesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionDeCursoAProfesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionParaAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoDeCicloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoDeCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosAsignadosAAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosAsignadosAProfesorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeCursosPorCicloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeAlumnosPorCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ingresosToolStripMenuItem
            // 
            this.ingresosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoDeAlumnoToolStripMenuItem,
            this.ingresoDeProfesorToolStripMenuItem,
            this.asignacionDeCursoAProfesorToolStripMenuItem,
            this.asignacionParaAlumnoToolStripMenuItem,
            this.ingresoDeCicloToolStripMenuItem,
            this.ingresoDeCursoToolStripMenuItem});
            this.ingresosToolStripMenuItem.Name = "ingresosToolStripMenuItem";
            this.ingresosToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.ingresosToolStripMenuItem.Text = "Ingresos";
            // 
            // ingresoDeAlumnoToolStripMenuItem
            // 
            this.ingresoDeAlumnoToolStripMenuItem.Name = "ingresoDeAlumnoToolStripMenuItem";
            this.ingresoDeAlumnoToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.ingresoDeAlumnoToolStripMenuItem.Text = "Ingreso de alumno";
            this.ingresoDeAlumnoToolStripMenuItem.Click += new System.EventHandler(this.ingresoDeAlumnoToolStripMenuItem_Click);
            // 
            // ingresoDeProfesorToolStripMenuItem
            // 
            this.ingresoDeProfesorToolStripMenuItem.Name = "ingresoDeProfesorToolStripMenuItem";
            this.ingresoDeProfesorToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.ingresoDeProfesorToolStripMenuItem.Text = "Ingreso de profesor";
            this.ingresoDeProfesorToolStripMenuItem.Click += new System.EventHandler(this.ingresoDeProfesorToolStripMenuItem_Click);
            // 
            // asignacionDeCursoAProfesorToolStripMenuItem
            // 
            this.asignacionDeCursoAProfesorToolStripMenuItem.Name = "asignacionDeCursoAProfesorToolStripMenuItem";
            this.asignacionDeCursoAProfesorToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.asignacionDeCursoAProfesorToolStripMenuItem.Text = "Asignacion de curso a profesor";
            this.asignacionDeCursoAProfesorToolStripMenuItem.Click += new System.EventHandler(this.asignacionDeCursoAProfesorToolStripMenuItem_Click);
            // 
            // asignacionParaAlumnoToolStripMenuItem
            // 
            this.asignacionParaAlumnoToolStripMenuItem.Name = "asignacionParaAlumnoToolStripMenuItem";
            this.asignacionParaAlumnoToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.asignacionParaAlumnoToolStripMenuItem.Text = "Asignacion para alumno";
            this.asignacionParaAlumnoToolStripMenuItem.Click += new System.EventHandler(this.asignacionParaAlumnoToolStripMenuItem_Click);
            // 
            // ingresoDeCicloToolStripMenuItem
            // 
            this.ingresoDeCicloToolStripMenuItem.Name = "ingresoDeCicloToolStripMenuItem";
            this.ingresoDeCicloToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.ingresoDeCicloToolStripMenuItem.Text = "Ingreso de ciclo";
            this.ingresoDeCicloToolStripMenuItem.Click += new System.EventHandler(this.ingresoDeCicloToolStripMenuItem_Click);
            // 
            // ingresoDeCursoToolStripMenuItem
            // 
            this.ingresoDeCursoToolStripMenuItem.Name = "ingresoDeCursoToolStripMenuItem";
            this.ingresoDeCursoToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.ingresoDeCursoToolStripMenuItem.Text = "Ingreso de curso";
            this.ingresoDeCursoToolStripMenuItem.Click += new System.EventHandler(this.ingresoDeCursoToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cursosAsignadosAAlumnoToolStripMenuItem,
            this.cursosAsignadosAProfesorToolStripMenuItem,
            this.listadoDeAlumnosPorCursoToolStripMenuItem,
            this.listadoDeCursosPorCicloToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // cursosAsignadosAAlumnoToolStripMenuItem
            // 
            this.cursosAsignadosAAlumnoToolStripMenuItem.Name = "cursosAsignadosAAlumnoToolStripMenuItem";
            this.cursosAsignadosAAlumnoToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.cursosAsignadosAAlumnoToolStripMenuItem.Text = "Cursos asignados a alumno";
            this.cursosAsignadosAAlumnoToolStripMenuItem.Click += new System.EventHandler(this.cursosAsignadosAAlumnoToolStripMenuItem_Click);
            // 
            // cursosAsignadosAProfesorToolStripMenuItem
            // 
            this.cursosAsignadosAProfesorToolStripMenuItem.Name = "cursosAsignadosAProfesorToolStripMenuItem";
            this.cursosAsignadosAProfesorToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.cursosAsignadosAProfesorToolStripMenuItem.Text = "Cursos asignados a profesor";
            this.cursosAsignadosAProfesorToolStripMenuItem.Click += new System.EventHandler(this.cursosAsignadosAProfesorToolStripMenuItem_Click);
            // 
            // listadoDeCursosPorCicloToolStripMenuItem
            // 
            this.listadoDeCursosPorCicloToolStripMenuItem.Name = "listadoDeCursosPorCicloToolStripMenuItem";
            this.listadoDeCursosPorCicloToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.listadoDeCursosPorCicloToolStripMenuItem.Text = "Listado de cursos por ciclo";
            this.listadoDeCursosPorCicloToolStripMenuItem.Click += new System.EventHandler(this.listadoDeCursosPorCicloToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // listadoDeAlumnosPorCursoToolStripMenuItem
            // 
            this.listadoDeAlumnosPorCursoToolStripMenuItem.Name = "listadoDeAlumnosPorCursoToolStripMenuItem";
            this.listadoDeAlumnosPorCursoToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.listadoDeAlumnosPorCursoToolStripMenuItem.Text = "Listado de alumnos por curso";
            this.listadoDeAlumnosPorCursoToolStripMenuItem.Click += new System.EventHandler(this.listadoDeAlumnosPorCursoToolStripMenuItem_Click);
            // 
            // FormPadre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsAppParcial2Colegio.Properties.Resources.books1920x1280;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPadre";
            this.Text = "Sistema Colegio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPadre_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ingresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoDeAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoDeProfesorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignacionDeCursoAProfesorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignacionParaAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosAsignadosAProfesorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosAsignadosAAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeCursosPorCicloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoDeCicloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoDeCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeAlumnosPorCursoToolStripMenuItem;
    }
}