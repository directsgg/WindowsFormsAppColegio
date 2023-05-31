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
    public partial class FormReporteProfesor : Form
    {
        public FormReporteProfesor()
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
        
        private void FormReporteProfesor_Load(object sender, EventArgs e)
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
            tablaProfesorCurso.Columns.Add("Codigo asignacion");
            tablaProfesorCurso.Columns.Add("Fecha asignación");
            tablaProfesorCurso.Columns.Add("DPIProfesor");
            tablaProfesorCurso.Columns.Add("Codigo curso");
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

                if (ClassSeleccionProfesor.DPI ==  datos[2])
                {

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
            }
            leer.Close();

            vistaTablaProfesorCurso = new DataView(tablaProfesorCurso);
            vistaTablaProfesorCurso.RowFilter = "Estado > 0";

            dataGridViewProfesorCurso.DataSource = vistaTablaProfesorCurso;
            dataGridViewProfesorCurso.Columns["DPIProfesor"].Visible = false;
            dataGridViewProfesorCurso.Columns["CodigoCiclo"].Visible = false;
            dataGridViewProfesorCurso.Columns["Estado"].Visible = false;
        }
    }
}
