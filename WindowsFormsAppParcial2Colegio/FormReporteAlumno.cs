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
    public partial class FormReporteAlumno : Form
    {
        public FormReporteAlumno()
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
        
        string ubcCiclo = "Archivos/Ciclo.txt";
        string ubcCurso = "Archivos/Curso.txt";
        string ubcProfesorCurso = "Archivos/Profesor_Curso.txt";
        string ubcProfesor = "Archivos/Profesor.txt";
        string ubcAlumno = "Archivos/Alumno.txt";
        string ubcAsignacion = "Archivos/Asignacion.txt";
        
        private void FormReporteAlumno_Load(object sender, EventArgs e)
        {
            
            //agregar columnas a la tabla alumno
            tablaAlumno.Columns.Add("Carne");
            tablaAlumno.Columns.Add("Nombre");
            tablaAlumno.Columns.Add("Apellido");
            tablaAlumno.Columns.Add("Fecha Nacimiento");
            tablaAlumno.Columns.Add("Municipio");
            tablaAlumno.Columns.Add("Estado", typeof(int));

            //agregar filas a la tabla alumno
            StreamReader leer = new StreamReader(ubcAlumno);
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
                    nombreProfesor, nombreCurso, nombreCiclo);
            }
            leer.Close();


            //agregar columnas a la tabla asignacion
            tablaAsignacion.Columns.Add("Codigo");
            tablaAsignacion.Columns.Add("Fecha asignación");
            tablaAsignacion.Columns.Add("Carné");
            tablaAsignacion.Columns.Add("Alumno");
            tablaAsignacion.Columns.Add("Codigo profesor curso");
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
                if (ClassSeleccionAlumno.carne == datos[2])
                {
                    string nombreAlumno = "", profesorCurso = "";
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
                    
                    tablaAsignacion.Rows.Add(datos[0], datos[1], datos[2], nombreAlumno, 
                        datos[4], profesorCurso, datos[5], datos[6], datos[7], datos[8], datos[9]);
                }
            }
            leer.Close();

            vistaTablaAsignacion = new DataView(tablaAsignacion);
            vistaTablaAsignacion.RowFilter = "Estado > 0";

            dataGridViewAsignacion.DataSource = vistaTablaAsignacion;
            //dataGridViewAsignacion.Columns["Codigo profesor curso"].Visible = false;
            dataGridViewAsignacion.Columns["Curso y profesor"].Width = 200;
            dataGridViewAsignacion.Columns["Estado"].Visible = false;
        }
    }
}
