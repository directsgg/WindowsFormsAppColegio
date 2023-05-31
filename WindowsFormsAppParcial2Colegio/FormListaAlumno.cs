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
    public partial class FormListaAlumno : Form
    {
        public FormListaAlumno()
        {
            InitializeComponent();
        }

        DataTable tablaAlumno = new DataTable();
        DataView vistaTablaAlumno;
        DataTable tablaDepartamento = new DataTable();
        DataTable tablaMunGlobal = new DataTable();
        string ubcAlumno = "Archivos/Alumno.txt";
        string ubcDepartamento = "Archivos/Departamento.txt";
        string ubcMunicipio = "Archivos/Municipio.txt";

        private void FormListaAlumno_Load(object sender, EventArgs e)
        {
            //agregar columnas a la tabla alumno
            tablaAlumno.Columns.Add("Carne");
            tablaAlumno.Columns.Add("Nombre");
            tablaAlumno.Columns.Add("Apellido");
            tablaAlumno.Columns.Add("Fecha Nacimiento");
            tablaAlumno.Columns.Add("Municipio");
            tablaAlumno.Columns.Add("Departamento");
            tablaAlumno.Columns.Add("Estado", typeof(int));

            //agregar columnas a la tabla departamento
            tablaDepartamento.Columns.Add("codigo");
            tablaDepartamento.Columns.Add("departamento");

            //agregar columnas a la tabla municipio global
            tablaMunGlobal.Columns.Add("codigo");
            tablaMunGlobal.Columns.Add("municipio");
            tablaMunGlobal.Columns.Add("codDepartamento");

            
            //agregar filas a la tabla municipio global
            StreamReader leer = new StreamReader(ubcMunicipio);
            while (!leer.EndOfStream)
            {
                string[] datos = leer.ReadLine().Split(',');
                tablaMunGlobal.Rows.Add(datos);
            }
            leer.Close();

            //agregar filas a la tabla departamento
            leer = new StreamReader(ubcDepartamento);
            while (!leer.EndOfStream)
            {
                string[] datos = leer.ReadLine().Split(',');
                tablaDepartamento.Rows.Add(datos);
            }
            leer.Close();

            //agregar filas a la tabla alumno
            leer = new StreamReader(ubcAlumno);
            while (!leer.EndOfStream)
            {
                string[] datos = leer.ReadLine().Split(',');
                string municipio = "", departamento = "";
                foreach (DataRow filaMun in tablaMunGlobal.Rows)
                {
                    if (filaMun[0].ToString() == datos[4])
                    {
                        municipio = filaMun[1].ToString();
                        foreach (DataRow filaDep in tablaDepartamento.Rows)
                        {
                            if (filaDep[0].ToString() == filaMun[2].ToString())
                            {
                                departamento = filaDep[1].ToString();
                                break;
                            }
                        }
                        break;
                    }
                }
                tablaAlumno.Rows.Add(datos[0], datos[1], datos[2],
                                     datos[3], municipio, departamento, datos[5]);
            }
            leer.Close();
            vistaTablaAlumno = new DataView(tablaAlumno);
            vistaTablaAlumno.RowFilter = "Estado > 0";

            dataGridViewAlumno.DataSource = vistaTablaAlumno;
            dataGridViewAlumno.Columns["Estado"].Visible = false;
        }

        private void dataGridViewAlumno_Click(object sender, EventArgs e)
        {
            ClassSeleccionAlumno.carne = dataGridViewAlumno.CurrentRow.Cells["Carne"].Value.ToString();
        }

        private void buttonVerCursosAsign_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ClassSeleccionAlumno.carne))
            {
                FormReporteAlumno formReporteAlumno = new FormReporteAlumno();
                formReporteAlumno.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione a un alumno para ver los cursos asignados");
            }
        }
    }
}
