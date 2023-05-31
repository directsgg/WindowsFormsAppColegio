using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsAppParcial2Colegio
{
    public partial class FormAsignacionCurso : Form
    {
        public FormAsignacionCurso()
        {
            InitializeComponent();
        }

        DataTable tablaProfesorCurso = new DataTable();
        DataTable tablaAlumno = new DataTable();
        DataTable tablaAsignacion = new DataTable();
        DataView vistaTablaAsignacion;
        DataTable tablaProfesor = new DataTable();
        DataTable tablaCurso = new DataTable();
        DataTable tablaCiclo = new DataTable();
        DataTable tablaDelegado = new DataTable();

        string ubcCiclo = "Archivos/Ciclo.txt";
        string ubcCurso = "Archivos/Curso.txt";
        string ubcProfesorCurso = "Archivos/Profesor_Curso.txt";
        string ubcProfesor = "Archivos/Profesor.txt";
        string ubcAlumno = "Archivos/Alumno.txt";
        string ubcAsignacion = "Archivos/Asignacion.txt";
        string ubcDelegado = "Archivos/Delegado.txt";
        int indice = -1;

        private void FormAsignacionCurso_Load(object sender, EventArgs e)
        {
            //agregar columnas a la tabla delegado
            tablaDelegado.Columns.Add("codigo");
            tablaDelegado.Columns.Add("nombre");

            //agregar filas a la tabla delegado
            StreamReader leer = new StreamReader(ubcDelegado);
            while (!leer.EndOfStream)
            {
                string[] datos = leer.ReadLine().Split(',');
                tablaDelegado.Rows.Add(datos);
            }
            leer.Close();
            comboBoxDelegado.DataSource = tablaDelegado;
            comboBoxDelegado.DisplayMember = "nombre";
            comboBoxDelegado.ValueMember = "codigo";

            //agregar columnas a la tabla alumno
            tablaAlumno.Columns.Add("Carne");
            tablaAlumno.Columns.Add("Nombre");
            tablaAlumno.Columns.Add("Apellido");
            tablaAlumno.Columns.Add("Fecha Nacimiento");
            tablaAlumno.Columns.Add("Municipio");
            tablaAlumno.Columns.Add("Estado", typeof(int));

            //agregar filas a la tabla alumno
            leer = new StreamReader(ubcAlumno);
            while (!leer.EndOfStream)
            {
                string[] datos = leer.ReadLine().Split(',');
                tablaAlumno.Rows.Add(datos);
            }
            leer.Close();

            //agregar columnas a la tabla profesor
            tablaProfesor.Columns.Add("DPI");
            tablaProfesor.Columns.Add("Nombre y Apellido");
            tablaProfesor.Columns.Add("Direccion");
            tablaProfesor.Columns.Add("Telefono");
            tablaProfesor.Columns.Add("Municipio");
            tablaProfesor.Columns.Add("Estado", typeof(int));

            //agregar filas a la tabla profesor
            leer = new StreamReader(ubcProfesor);
            while (!leer.EndOfStream)
            {
                string[] datos = leer.ReadLine().Split(',');
                tablaProfesor.Rows.Add(datos);
            }
            leer.Close();

            //agregar columnas a la tabla curso
            tablaCurso.Columns.Add("Codigo");
            tablaCurso.Columns.Add("Nombre");
            tablaCurso.Columns.Add("Estado");

            //agregar filas a la tabla curso
            leer = new StreamReader(ubcCurso);
            while (!leer.EndOfStream)
            {
                string[] datos = leer.ReadLine().Split(',');

                tablaCurso.Rows.Add(datos);
            }
            leer.Close();

            //agregar columnas a la tabla ciclo
            tablaCiclo.Columns.Add("Codigo");
            tablaCiclo.Columns.Add("Nombre ciclo");
            tablaCiclo.Columns.Add("Estado");

            //agregar filas a la tabla ciclo
            leer = new StreamReader(ubcCiclo);
            while (!leer.EndOfStream)
            {
                string[] datos = leer.ReadLine().Split(',');

                tablaCiclo.Rows.Add(datos);
            }
            leer.Close();

            //agregar columnas a la tabla profesor curso
            tablaProfesorCurso.Columns.Add("Codigo");
            tablaProfesorCurso.Columns.Add("Fecha asignación");
            tablaProfesorCurso.Columns.Add("DPIProfesor");
            tablaProfesorCurso.Columns.Add("CodigoCurso");
            tablaProfesorCurso.Columns.Add("CodigoCiclo");
            tablaProfesorCurso.Columns.Add("Profesor");
            tablaProfesorCurso.Columns.Add("Curso");
            tablaProfesorCurso.Columns.Add("Ciclo");
            tablaProfesorCurso.Columns.Add("Estado");

            //agregar filas a la tabla profesor curso
            leer = new StreamReader(ubcProfesorCurso);
            while (!leer.EndOfStream)
            {
                string[] datos = leer.ReadLine().Split(',');
                string nombreProfesor = "", nombreCurso = "", nombreCiclo = "";
                foreach (DataRow filaProfesor in tablaProfesor.Rows)
                {
                    if (filaProfesor["DPI"].ToString() == datos[2])
                    {
                        nombreProfesor = filaProfesor["Nombre y Apellido"].ToString();
                        break;
                    }
                }

                foreach (DataRow filaCurso in tablaCurso.Rows)
                {
                    if (filaCurso["Codigo"].ToString() == datos[3])
                    {
                        nombreCurso = filaCurso["Nombre"].ToString();
                        break;
                    }
                }

                foreach (DataRow filaCiclo in tablaCiclo.Rows)
                {
                    if (filaCiclo["Codigo"].ToString() == datos[4])
                    {
                        nombreCiclo = filaCiclo["Nombre ciclo"].ToString();
                        break;
                    }
                }
                tablaProfesorCurso.Rows.Add(datos[0], datos[1], datos[2], datos[3], datos[4],
                    nombreProfesor, nombreCurso, nombreCiclo, datos[5]);
            }
            leer.Close();


            //agregar columnas a la tabla asignacion
            tablaAsignacion.Columns.Add("Codigo");
            tablaAsignacion.Columns.Add("Fecha asignación");
            tablaAsignacion.Columns.Add("Carné");
            tablaAsignacion.Columns.Add("Alumno");
            tablaAsignacion.Columns.Add("Estado Delegado");
            tablaAsignacion.Columns.Add("codProfesorCurso");
            tablaAsignacion.Columns.Add("Curso y profesor");
            tablaAsignacion.Columns.Add("Zona");
            tablaAsignacion.Columns.Add("Final");
            tablaAsignacion.Columns.Add("Total");
            tablaAsignacion.Columns.Add("Resultado");
            tablaAsignacion.Columns.Add("Estado");

            //agregar filas a la tabla asignacion
            leer = new StreamReader(ubcAsignacion);
            while (!leer.EndOfStream)
            {
                string[] datos = leer.ReadLine().Split(',');
                string nombreAlumno = "", profesorCurso = "", estDelegado = "";
                foreach (DataRow filaAlumno in tablaAlumno.Rows)
                {
                    if (filaAlumno["Carne"].ToString() == datos[2])
                    {
                        nombreAlumno = filaAlumno["Nombre"].ToString() + " " +
                            filaAlumno["Apellido"].ToString();
                        break;
                    }
                }

                foreach (DataRow filaProfCurso in tablaProfesorCurso.Rows)
                {
                    if (filaProfCurso["Codigo"].ToString() == datos[4])
                    {
                        profesorCurso = filaProfCurso["Profesor"] + " - " +
                            filaProfCurso["Curso"];
                        break;
                    }
                }

                foreach (DataRow filaDelegado in tablaDelegado.Rows)
                {
                    if (filaDelegado["codigo"].ToString() == datos[3])
                    {
                        estDelegado = filaDelegado["nombre"].ToString();
                        break;
                    }
                }

                tablaAsignacion.Rows.Add(datos[0], datos[1], datos[2], nombreAlumno, estDelegado,
                    datos[4], profesorCurso, datos[5], datos[6], datos[7], datos[8], datos[9]);
            }
            leer.Close();

            vistaTablaAsignacion = new DataView(tablaAsignacion);
            vistaTablaAsignacion.RowFilter = "Estado > 0";

            dataGridViewAsignacion.DataSource = vistaTablaAsignacion;
            dataGridViewAsignacion.Columns["codProfesorCurso"].Visible = false;
            dataGridViewAsignacion.Columns["Estado"].Visible = false;
            dataGridViewAsignacion.Columns["Curso y profesor"].Width = 200;
        }

        private void textBoxAlumno_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormModalAlumno formModalAlumno = new FormModalAlumno();
            formModalAlumno.ShowDialog();
            e.KeyChar = Convert.ToChar(13);
            textBoxAlumno.Text = ClassDatosAlumno.nombre;
        }

        private void textBoxProfesorCurso_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormModalProfesorCurso formModalProfesorCurso = new FormModalProfesorCurso();
            formModalProfesorCurso.ShowDialog();
            e.KeyChar = Convert.ToChar(13);
            textBoxProfesorCurso.Text = ClassDatosProfesorCurso.nombre;
        }

        private void restablecer()
        {
            textBoxAlumno.Clear();
            textBoxProfesorCurso.Clear();
            dateTimePickerFAsign.Focus();

            buttonGuardar.Enabled = true;
            buttonEditar.Enabled = false;
            buttonEliminar.Enabled = false;
            dataGridViewAsignacion.Enabled = true;

            indice = -1;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string alumno = textBoxAlumno.Text;
            string profesorCurso = textBoxProfesorCurso.Text;
            DateTime fAct = DateTime.Now;
            string fAsignString = dateTimePickerFAsign.Text;
            DateTime fAsignDateTime = DateTime.ParseExact(fAsignString, "dd/MM/yyyy", null);
            string estDelegado = comboBoxDelegado.Text;
            string codDelegado = comboBoxDelegado.SelectedValue.ToString();

            if (fAct >= fAsignDateTime)
            {
                if (!string.IsNullOrEmpty(alumno))
                {
                    if (!string.IsNullOrEmpty(profesorCurso))
                    {
                        bool alumnoAsignado = false;
                        foreach (DataRow filaAsignacion in tablaAsignacion.Rows)
                        {
                            if (filaAsignacion["Carné"].ToString() == ClassDatosAlumno.carne &&
                                filaAsignacion["codProfesorCurso"].ToString() == ClassDatosProfesorCurso.codigo &&
                                filaAsignacion["Estado"].ToString() == "1")
                            {
                                alumnoAsignado = true;
                            }
                        }

                        if (!alumnoAsignado) {
                            bool delegadoExiste = false;
                            foreach (DataRow filaAsignacion in tablaAsignacion.Rows)
                            {
                                if (estDelegado == tablaDelegado.Rows[1]["nombre"].ToString() &&
                                   filaAsignacion["Estado Delegado"].ToString() == tablaDelegado.Rows[1]["nombre"].ToString() &&
                                   filaAsignacion["codProfesorCurso"].ToString() == ClassDatosProfesorCurso.codigo &&
                                   filaAsignacion["Estado"].ToString() == "1")
                                {
                                    delegadoExiste = true;
                                }

                            }

                            if (!delegadoExiste)
                            {
                                string codAsignacion = (10000 + tablaAsignacion.Rows.Count).ToString();
                                tablaAsignacion.Rows.Add(codAsignacion, fAsignString,
                                    ClassDatosAlumno.carne, ClassDatosAlumno.nombre, estDelegado, ClassDatosProfesorCurso.codigo,
                                    ClassDatosProfesorCurso.nombre, 0, 0, 0, "", 1);

                                StreamWriter escribir = new StreamWriter(ubcAsignacion, true);
                                string linea = codAsignacion + "," +
                                               fAsignString + "," +
                                               ClassDatosAlumno.carne + "," +
                                               codDelegado + "," +
                                               ClassDatosProfesorCurso.codigo + "," +
                                               0 + "," +
                                               0 + "," +
                                               0 + "," +
                                               "" + "," +
                                               1;
                                escribir.WriteLine(linea);
                                escribir.Close();
                                restablecer();
                            }
                            else
                            {
                                MessageBox.Show("Ya hay un delegado, intente nuevamente");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Alumno ya esta asignado al curso, ingrese un registro diferente");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un profesor y curso en la tabla");
                        textBoxProfesorCurso.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione a un alumno en la tabla");
                    textBoxAlumno.Focus();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fecha menor a la actual");
                dateTimePickerFAsign.Focus();
            }
        }

        private void dataGridViewAsignacion_DoubleClick(object sender, EventArgs e)
        {
            dateTimePickerFAsign.Text = dataGridViewAsignacion.CurrentRow.Cells["Fecha asignación"].Value.ToString();
            textBoxAlumno.Text = dataGridViewAsignacion.CurrentRow.Cells["Alumno"].Value.ToString();
            textBoxProfesorCurso.Text = dataGridViewAsignacion.CurrentRow.Cells["Curso y profesor"].Value.ToString();
            
            int codDelegado = -1;
            foreach (DataRow filaDelegado in tablaDelegado.Rows)
            {
                if (filaDelegado["nombre"].ToString() == dataGridViewAsignacion.CurrentRow.Cells["Estado Delegado"].Value.ToString())
                {
                    codDelegado = Convert.ToInt32(filaDelegado["codigo"]);
                    break;
                }
            }
            comboBoxDelegado.SelectedValue = codDelegado;
            
            ClassDatosAlumno.carne = dataGridViewAsignacion.CurrentRow.Cells["Carné"].Value.ToString();
            ClassDatosAlumno.nombre = dataGridViewAsignacion.CurrentRow.Cells["Alumno"].Value.ToString();
            ClassDatosProfesorCurso.codigo = dataGridViewAsignacion.CurrentRow.Cells["codProfesorCurso"].Value.ToString();
            ClassDatosProfesorCurso.nombre = dataGridViewAsignacion.CurrentRow.Cells["Curso y profesor"].Value.ToString();

            dateTimePickerFAsign.Focus();

            buttonGuardar.Enabled = false;
            buttonEditar.Enabled = true;
            buttonEliminar.Enabled = true;
            dataGridViewAsignacion.Enabled = false;

            for (int i = 0; i < tablaAsignacion.Rows.Count; i++)
            {
                if (tablaAsignacion.Rows[i]["Codigo"].ToString() ==
                    dataGridViewAsignacion.CurrentRow.Cells["Codigo"].Value.ToString())
                {
                    indice = i;
                    break;
                }
            }

            if (indice == -1)
            {
                MessageBox.Show("Ocurrio un error inesperado, intente de nuevo");
                restablecer();
            }
            
        }

        private void actualizarBDAsignacion()
        {
            StreamWriter escribir = new StreamWriter(ubcAsignacion);
            foreach (DataRow filaAsignacion in tablaAsignacion.Rows)
            {
                int codDelegado = 0;
                foreach (DataRow filaDelegado in tablaDelegado.Rows)
                {
                    if (filaDelegado["nombre"].ToString() == filaAsignacion["Estado Delegado"].ToString())
                    {
                        codDelegado = Convert.ToInt32(filaDelegado["codigo"]);
                        break;
                    }
                }
               
                string linea = filaAsignacion["Codigo"] + "," +
                               filaAsignacion["Fecha asignación"] + "," +
                               filaAsignacion["Carné"] + "," +
                               codDelegado + "," +
                               filaAsignacion["codProfesorCurso"] + "," +
                               filaAsignacion["Zona"] + "," +
                               filaAsignacion["Final"] + "," +
                               filaAsignacion["Total"] + "," +
                               filaAsignacion["Resultado"] + "," +
                               filaAsignacion["Estado"];
                escribir.WriteLine(linea);
            }
            escribir.Close();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            string alumno = textBoxAlumno.Text;
            string profesorCurso = textBoxProfesorCurso.Text;
            DateTime fAct = DateTime.Now;
            string fAsignString = dateTimePickerFAsign.Text;
            DateTime fAsignDateTime = DateTime.ParseExact(fAsignString, "dd/MM/yyyy", null);
            string estDelegado = comboBoxDelegado.Text;
            string codDelegado = comboBoxDelegado.SelectedValue.ToString();

            if (fAct >= fAsignDateTime)
            {
                if (!string.IsNullOrEmpty(alumno))
                {
                    if (!string.IsNullOrEmpty(profesorCurso))
                    {
                        bool alumnoAsignado = false;
                        foreach (DataRow filaAsignacion in tablaAsignacion.Rows)
                        {
                            if (filaAsignacion["Carné"].ToString() == ClassDatosAlumno.carne &&
                                filaAsignacion["codProfesorCurso"].ToString() == ClassDatosProfesorCurso.codigo &&
                                filaAsignacion["Estado"].ToString() == "1" &&
                                filaAsignacion["Codigo"].ToString() != dataGridViewAsignacion.CurrentRow.Cells["Codigo"].Value.ToString())
                            {
                                alumnoAsignado = true;
                            }
                        }

                        if (!alumnoAsignado)
                        {
                            bool delegadoExiste = false;
                            foreach (DataRow filaAsignacion in tablaAsignacion.Rows)
                            {
                                if (estDelegado == tablaDelegado.Rows[1]["nombre"].ToString() &&
                                   filaAsignacion["Estado Delegado"].ToString() == tablaDelegado.Rows[1]["nombre"].ToString() &&
                                   filaAsignacion["codProfesorCurso"].ToString() == ClassDatosProfesorCurso.codigo &&
                                   filaAsignacion["Estado"].ToString() == "1" &&
                                   filaAsignacion["Codigo"].ToString() != dataGridViewAsignacion.CurrentRow.Cells["Codigo"].Value.ToString())
                                {
                                    delegadoExiste = true;
                                }

                            }

                            if (!delegadoExiste)
                            {
                                /* //agregar columnas a la tabla asignacion
            tablaAsignacion.Columns.Add("Codigo");
            tablaAsignacion.Columns.Add("Fecha asignación");
            tablaAsignacion.Columns.Add("Carné");
            tablaAsignacion.Columns.Add("Alumno");
            tablaAsignacion.Columns.Add("Estado Delegado");
            tablaAsignacion.Columns.Add("codProfesorCurso");
            tablaAsignacion.Columns.Add("Curso y profesor");
            tablaAsignacion.Columns.Add("Zona");
            tablaAsignacion.Columns.Add("Final");
            tablaAsignacion.Columns.Add("Total");
            tablaAsignacion.Columns.Add("Resultado");
            tablaAsignacion.Columns.Add("Estado");*/
                                /*tablaProfesorCurso.Rows[indice]["Fecha asignación"] = fAsignString;
                                                    tablaProfesorCurso.Rows[indice]["DPIProfesor"] = ClassDatosProfesor.DPIProfesor;
                                                    tablaProfesorCurso.Rows[indice]["CodigoCurso"] = ClassDatosCurso.codigoCurso;
                                                    tablaProfesorCurso.Rows[indice]["CodigoCiclo"] = ClassDatosCiclo.codigoCiclo;
                                                    tablaProfesorCurso.Rows[indice]["Profesor"] = ClassDatosProfesor.nombre;
                                                    tablaProfesorCurso.Rows[indice]["Curso"] = ClassDatosCurso.nombre;
                                                    tablaProfesorCurso.Rows[indice]["Ciclo"] = ClassDatosCiclo.nombre;

                                                    actualizarBDProfesorCurso();
                                                    MessageBox.Show("Datos actualizados con exito");
                                                    restablecer();*/

                               /* string codAsignacion = (10000 + tablaAsignacion.Rows.Count).ToString();
                                tablaAsignacion.Rows.Add(codAsignacion, fAsignString,
                                    ClassDatosAlumno.carne, ClassDatosAlumno.nombre, estDelegado, ClassDatosProfesorCurso.codigo,
                                    ClassDatosProfesorCurso.nombre, 0, 0, 0, "", 1);

                                StreamWriter escribir = new StreamWriter(ubcAsignacion, true);
                                string linea = codAsignacion + "," +
                                               fAsignString + "," +
                                               ClassDatosAlumno.carne + "," +
                                               codDelegado + "," +
                                               ClassDatosProfesorCurso.codigo + "," +
                                               0 + "," +
                                               0 + "," +
                                               0 + "," +
                                               "" + "," +
                                               1;
                                escribir.WriteLine(linea);
                                escribir.Close();
                                restablecer();*/
                                tablaAsignacion.Rows[indice]["Fecha asignación"] = fAsignString;
                                tablaAsignacion.Rows[indice]["Carné"] = ClassDatosAlumno.carne;
                                tablaAsignacion.Rows[indice]["Alumno"] = ClassDatosAlumno.nombre;
                                tablaAsignacion.Rows[indice]["Estado Delegado"] = estDelegado;
                                tablaAsignacion.Rows[indice]["codProfesorCurso"] = ClassDatosProfesorCurso.codigo;
                                tablaAsignacion.Rows[indice]["Curso y profesor"] = ClassDatosProfesorCurso.nombre;
                                actualizarBDAsignacion();
                                MessageBox.Show("Datos actualizados con exito");
                                restablecer();
                            }
                            else
                            {
                                MessageBox.Show("Ya hay un delegado, intente nuevamente");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Alumno ya esta asignado al curso, ingrese un registro diferente");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un profesor y curso en la tabla");
                        textBoxProfesorCurso.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione a un alumno en la tabla");
                    textBoxAlumno.Focus();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fecha menor a la actual");
                dateTimePickerFAsign.Focus();
            }

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar el registro",
                               "Aviso",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Error) == DialogResult.Yes)
            {
                tablaAsignacion.Rows[indice]["Estado"] = 0;
                actualizarBDAsignacion();
                MessageBox.Show("Registro eliminado");
                restablecer();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            restablecer();
        }
        
    }
}
