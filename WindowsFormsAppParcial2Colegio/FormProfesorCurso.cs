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
    public partial class FormProfesorCurso : Form
    {
        public FormProfesorCurso()
        {
            InitializeComponent();
        }

        DataTable tablaProfesorCurso = new DataTable();
        DataView vistaTablaProfesorCurso;
        DataTable tablaProfesor = new DataTable();
        DataTable tablaCurso = new DataTable();
        DataTable tablaCiclo = new DataTable();

        string ubcCiclo = "Archivos/Ciclo.txt";
        string ubcCurso = "Archivos/Curso.txt";
        string ubcProfesorCurso = "Archivos/Profesor_Curso.txt";
        string ubcProfesor = "Archivos/Profesor.txt";
        int indice = -1;

        private void FormProfesorCurso_Load(object sender, EventArgs e)
        {
            //agregar columnas a la tabla profesor
            tablaProfesor.Columns.Add("DPI");
            tablaProfesor.Columns.Add("Nombre y Apellido");
            tablaProfesor.Columns.Add("Direccion");
            tablaProfesor.Columns.Add("Telefono");
            tablaProfesor.Columns.Add("Municipio");
            tablaProfesor.Columns.Add("Estado", typeof(int));

            //agregar filas a la tabla profesor
            StreamReader leer = new StreamReader(ubcProfesor);
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
            tablaProfesorCurso.Columns.Add("Estado", typeof(int));
            
            //agregar filas a la tabla profesor curso
            leer = new StreamReader(ubcProfesorCurso);
            while (!leer.EndOfStream)
            {
                string[] datos = leer.ReadLine().Split(',');
                string nombreProfesor = "", nombreCurso = "", nombreCiclo = "";
                foreach(DataRow filaProfesor in tablaProfesor.Rows)
                {
                    if(filaProfesor["DPI"].ToString() == datos[2])
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

                foreach(DataRow filaCiclo in tablaCiclo.Rows)
                {
                    if(filaCiclo["Codigo"].ToString() == datos[4])
                    {
                        nombreCiclo = filaCiclo["Nombre ciclo"].ToString();
                        break;
                    }
                }
                tablaProfesorCurso.Rows.Add(datos[0], datos[1], datos[2], datos[3], datos[4],
                    nombreProfesor, nombreCurso, nombreCiclo, datos[5]);
            }
            leer.Close();
            
            vistaTablaProfesorCurso = new DataView(tablaProfesorCurso);
            vistaTablaProfesorCurso.RowFilter = "Estado > 0";

            dataGridViewProfesorCurso.DataSource = vistaTablaProfesorCurso;

            dataGridViewProfesorCurso.Columns["DPIProfesor"].Visible = false;
            dataGridViewProfesorCurso.Columns["CodigoCurso"].Visible = false;
            dataGridViewProfesorCurso.Columns["CodigoCiclo"].Visible = false;
            dataGridViewProfesorCurso.Columns["Estado"].Visible = false;
        }

        private void textBoxProfesor_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormModalProfesor formModalProfesor = new FormModalProfesor();
            formModalProfesor.ShowDialog();
            e.KeyChar = Convert.ToChar(13);
            textBoxProfesor.Text = ClassDatosProfesor.nombre;
        }

        private void textBoxCurso_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormModalIngresoCurso formModalIngresoCurso = new FormModalIngresoCurso();
            formModalIngresoCurso.ShowDialog();
            e.KeyChar = Convert.ToChar(13);
            textBoxCurso.Text = ClassDatosCurso.nombre;
        }

        private void textBoxCiclo_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormModalIngresoCiclo formModalIngresoCiclo = new FormModalIngresoCiclo();
            formModalIngresoCiclo.ShowDialog();
            e.KeyChar = Convert.ToChar(13);
            textBoxCiclo.Text = ClassDatosCiclo.nombre;
        }

        private void restablecer()
        {
            textBoxProfesor.Clear();
            textBoxCurso.Clear();
            textBoxCiclo.Clear();
            dateTimePickerFAsign.Focus();

            buttonGuardar.Enabled = true;
            buttonEditar.Enabled = false;
            buttonEliminar.Enabled = false;
            dataGridViewProfesorCurso.Enabled = true;

            indice = -1;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string profesor = textBoxProfesor.Text;
            string curso = textBoxCurso.Text;
            string ciclo = textBoxCiclo.Text;
            DateTime fAct = DateTime.Now;
            string fAsignString = dateTimePickerFAsign.Text;
            DateTime fAsignDateTime = DateTime.ParseExact(fAsignString, "dd/MM/yyyy", null);

            if (fAct >= fAsignDateTime)
            {
                if (!string.IsNullOrEmpty(profesor))
                {
                    if (!string.IsNullOrEmpty(curso))
                    {
                        if (!string.IsNullOrEmpty(ciclo))
                        {
                            bool asignacionExiste = false;

                            foreach (DataRow filaProfesorCurso in tablaProfesorCurso.Rows)
                            {
                                if(filaProfesorCurso["CodigoCurso"].ToString() == ClassDatosCurso.codigoCurso &&
                                    filaProfesorCurso["CodigoCiclo"].ToString() == ClassDatosCiclo.codigoCiclo &&
                                    filaProfesorCurso["Estado"].ToString() == "1")
                                {
                                    asignacionExiste = true;
                                 
                                }
                            }

                            if (!asignacionExiste)
                            {

                                string codProfCurso = (1000 + tablaProfesorCurso.Rows.Count).ToString() ;
                                tablaProfesorCurso.Rows.Add(codProfCurso, fAsignString,
                                    ClassDatosProfesor.DPIProfesor, ClassDatosCurso.codigoCurso,
                                    ClassDatosCiclo.codigoCiclo, ClassDatosProfesor.nombre, ClassDatosCurso.nombre, ClassDatosCiclo.nombre, 1);
                                StreamWriter escribir = new StreamWriter(ubcProfesorCurso, true);
                                string linea = codProfCurso + "," +
                                               fAsignString + "," +
                                               ClassDatosProfesor.DPIProfesor + "," +
                                               ClassDatosCurso.codigoCurso + "," +
                                               ClassDatosCiclo.codigoCiclo + "," +
                                               1;
                                escribir.WriteLine(linea);
                                escribir.Close();
                                restablecer();
                            }
                            else
                            {
                                MessageBox.Show("Intente asignar otro curso u otro ciclo", "Asignacion ya existe",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Seleccione un ciclo en la tabla");
                            textBoxCiclo.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un curso en la tabla");
                        textBoxCurso.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione a un profesor en la tabla");
                    textBoxProfesor.Focus();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fecha menor a la actual");
                dateTimePickerFAsign.Focus();
            }
        }

        private void dataGridViewProfesorCurso_DoubleClick(object sender, EventArgs e)
        {
            dateTimePickerFAsign.Text = dataGridViewProfesorCurso.CurrentRow.Cells["Fecha asignación"].Value.ToString();
            textBoxProfesor.Text = dataGridViewProfesorCurso.CurrentRow.Cells["Profesor"].Value.ToString();
            textBoxCurso.Text = dataGridViewProfesorCurso.CurrentRow.Cells["Curso"].Value.ToString();
            textBoxCiclo.Text = dataGridViewProfesorCurso.CurrentRow.Cells["Ciclo"].Value.ToString();
            ClassDatosProfesor.DPIProfesor = dataGridViewProfesorCurso.CurrentRow.Cells["DPIProfesor"].Value.ToString();
            ClassDatosProfesor.nombre = dataGridViewProfesorCurso.CurrentRow.Cells["Profesor"].Value.ToString();
            ClassDatosCurso.codigoCurso = dataGridViewProfesorCurso.CurrentRow.Cells["CodigoCurso"].Value.ToString();
            ClassDatosCurso.nombre = dataGridViewProfesorCurso.CurrentRow.Cells["Curso"].Value.ToString();
            ClassDatosCiclo.codigoCiclo = dataGridViewProfesorCurso.CurrentRow.Cells["CodigoCiclo"].Value.ToString();
            ClassDatosCiclo.nombre = dataGridViewProfesorCurso.CurrentRow.Cells["Ciclo"].Value.ToString();
            
            dateTimePickerFAsign.Focus();

            buttonGuardar.Enabled = false;
            buttonEditar.Enabled = true;
            buttonEliminar.Enabled = true;
            dataGridViewProfesorCurso.Enabled = false;

            for (int i = 0; i < tablaProfesorCurso.Rows.Count; i++)
            {
                if (tablaProfesorCurso.Rows[i]["Codigo"].ToString() ==
                    dataGridViewProfesorCurso.CurrentRow.Cells["Codigo"].Value.ToString())
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
            //indice = dataGridViewProfesor.CurrentRow.Index;

        }

        private void actualizarBDProfesorCurso()
        {
            StreamWriter escribir = new StreamWriter(ubcProfesorCurso);
            foreach (DataRow filaProfesorCurso in tablaProfesorCurso.Rows)
            {
                string linea = filaProfesorCurso["Codigo"] + "," +
                               filaProfesorCurso["Fecha asignación"] + "," +
                               filaProfesorCurso["DPIProfesor"] + "," +
                               filaProfesorCurso["CodigoCurso"] + "," +
                               filaProfesorCurso["CodigoCiclo"] + "," +
                               filaProfesorCurso["Estado"];
                escribir.WriteLine(linea);
            }
            escribir.Close();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            string profesor = textBoxProfesor.Text;
            string curso = textBoxCurso.Text;
            string ciclo = textBoxCiclo.Text;
            DateTime fAct = DateTime.Now;
            string fAsignString = dateTimePickerFAsign.Text;
            DateTime fAsignDateTime = DateTime.ParseExact(fAsignString, "dd/MM/yyyy", null);

            if (fAct >= fAsignDateTime)
            {
                if (!string.IsNullOrEmpty(profesor))
                {
                    if (!string.IsNullOrEmpty(curso))
                    {
                        if (!string.IsNullOrEmpty(ciclo))
                        {
                            bool asignacionExiste = false;

                            foreach (DataRow filaProfesorCurso in tablaProfesorCurso.Rows)
                            {
                                if (filaProfesorCurso["CodigoCurso"].ToString() == ClassDatosCurso.codigoCurso &&
                                    filaProfesorCurso["CodigoCiclo"].ToString() == ClassDatosCiclo.codigoCiclo &&
                                    filaProfesorCurso["Codigo"].ToString() != dataGridViewProfesorCurso.CurrentRow.Cells["Codigo"].Value.ToString() &&
                                    filaProfesorCurso["Estado"].ToString() == "1")
                                {
                                    asignacionExiste = true;
                                }
                            }

                            if (!asignacionExiste)
                            {
                                tablaProfesorCurso.Rows[indice]["Fecha asignación"] = fAsignString;
                                tablaProfesorCurso.Rows[indice]["DPIProfesor"] = ClassDatosProfesor.DPIProfesor;
                                tablaProfesorCurso.Rows[indice]["CodigoCurso"] = ClassDatosCurso.codigoCurso;
                                tablaProfesorCurso.Rows[indice]["CodigoCiclo"] = ClassDatosCiclo.codigoCiclo;
                                tablaProfesorCurso.Rows[indice]["Profesor"] = ClassDatosProfesor.nombre;
                                tablaProfesorCurso.Rows[indice]["Curso"] = ClassDatosCurso.nombre;
                                tablaProfesorCurso.Rows[indice]["Ciclo"] = ClassDatosCiclo.nombre;

                                actualizarBDProfesorCurso();
                                MessageBox.Show("Datos actualizados con exito");
                                restablecer();
                            }
                            else
                            {
                                MessageBox.Show("Intente asignar otro curso u otro ciclo", "Asignacion ya existe",
                                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Seleccione un ciclo en la tabla");
                            textBoxCiclo.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un curso en la tabla");
                        textBoxCurso.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione a un profesor en la tabla");
                    textBoxProfesor.Focus();
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
                tablaProfesorCurso.Rows[indice]["Estado"] = 0;
                actualizarBDProfesorCurso();
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
