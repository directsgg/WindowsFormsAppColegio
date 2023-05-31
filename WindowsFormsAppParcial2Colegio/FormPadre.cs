using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppParcial2Colegio
{
    public partial class FormPadre : Form
    {
        public FormPadre()
        {
            InitializeComponent();
        }

        private void ingresoDeAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIngresoAlumno formIngresoAlumno = new FormIngresoAlumno { MdiParent = this};
            formIngresoAlumno.Show();
        }

        private void ingresoDeProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIngresoProfesor formIngresoProfesor = new FormIngresoProfesor { MdiParent = this};
            formIngresoProfesor.Show();
        }

        private void asignacionDeCursoAProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProfesorCurso formProfesorCurso = new FormProfesorCurso { MdiParent = this};
            formProfesorCurso.Show();
        }

        private void asignacionParaAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAsignacionCurso formAsignacionCurso = new FormAsignacionCurso { MdiParent = this};
            formAsignacionCurso.Show();
        }

        private void cursosAsignadosAAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListaAlumno formListaAlumno = new FormListaAlumno { MdiParent = this};
            formListaAlumno.Show();
        }

        private void cursosAsignadosAProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListaProfesor formListaProfesor = new FormListaProfesor { MdiParent = this};
            formListaProfesor.Show();
        }

        private void listadoDeCursosPorCicloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListaCiclo formListaCiclo = new FormListaCiclo { MdiParent = this};
            formListaCiclo.Show();
        }

        private void listadoDeAlumnosPorCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListaProfesorCurso formListaProfesorCurso = new FormListaProfesorCurso { MdiParent = this };
            formListaProfesorCurso.Show();
        }

        private void ingresoDeCicloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIngresoCiclo formIngresoCiclo = new FormIngresoCiclo { MdiParent = this };
            formIngresoCiclo.Show();
        }

        private void ingresoDeCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIngresoCurso formIngresoCurso = new FormIngresoCurso { MdiParent = this};
            formIngresoCurso.Show();
        }

        private void FormPadre_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
