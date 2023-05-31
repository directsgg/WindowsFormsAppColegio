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
    public partial class FormModalProfesor : Form
    {
        public FormModalProfesor()
        {
            InitializeComponent();
        }

        DataTable tablaProfesor = new DataTable();
        DataView vistaTablaProfesor;
        DataTable tablaDepartamento = new DataTable();
        DataTable tablaMunGlobal = new DataTable();
        string ubcProfesor = "Archivos/Profesor.txt";
        string ubcDepartamento = "Archivos/Departamento.txt";
        string ubcMunicipio = "Archivos/Municipio.txt";

        private void FormModalProfesor_Load(object sender, EventArgs e)
        {
            //agregar columnas a la tabla profesor
            tablaProfesor.Columns.Add("DPI");
            tablaProfesor.Columns.Add("Nombre y Apellido");
            tablaProfesor.Columns.Add("Direccion");
            tablaProfesor.Columns.Add("Telefono");
            tablaProfesor.Columns.Add("Municipio");
            tablaProfesor.Columns.Add("Departamento");
            tablaProfesor.Columns.Add("Estado", typeof(int));
            //tablaProfesor.DefaultView.RowFilter.


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

            //agregar filas a la tabla profesor
            leer = new StreamReader(ubcProfesor);
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
                tablaProfesor.Rows.Add(datos[0], datos[1], datos[2],
                                       datos[3], municipio, departamento, datos[5]);
            }
            leer.Close();
            vistaTablaProfesor = new DataView(tablaProfesor);
            vistaTablaProfesor.RowFilter = "Estado > 0";

            dataGridViewProfesor.DataSource = vistaTablaProfesor;
            dataGridViewProfesor.Columns["Estado"].Visible = false;

        }

        private void dataGridViewProfesor_DoubleClick(object sender, EventArgs e)
        {
            ClassDatosProfesor.DPIProfesor = dataGridViewProfesor.CurrentRow.Cells["DPI"].Value.ToString();
            ClassDatosProfesor.nombre = dataGridViewProfesor.CurrentRow.Cells["Nombre y Apellido"].Value.ToString();
            this.Close();
        }
    }
}
