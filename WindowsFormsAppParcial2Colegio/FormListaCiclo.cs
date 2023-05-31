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
    public partial class FormListaCiclo : Form
    {
        public FormListaCiclo()
        {
            InitializeComponent();
        }

        DataTable tablaCiclo = new DataTable();
        string ubcCiclo = "Archivos/Ciclo.txt";

        private void FormListaCiclo_Load(object sender, EventArgs e)
        {
            //agregar columnas a la tabla ciclo
            tablaCiclo.Columns.Add("Codigo");
            tablaCiclo.Columns.Add("Nombre ciclo");
            tablaCiclo.Columns.Add("Estado");

            //agregar filas a la tabla ciclo
            StreamReader leer = new StreamReader(ubcCiclo);
            while (!leer.EndOfStream)
            {
                string[] datos = leer.ReadLine().Split(',');

                tablaCiclo.Rows.Add(datos);
            }
            leer.Close();

            dataGridViewCiclo.DataSource = tablaCiclo;

        }

        private void dataGridViewCiclo_Click(object sender, EventArgs e)
        {
            ClassSeleccionCiclo.codigo = dataGridViewCiclo.CurrentRow.Cells["Codigo"].Value.ToString();
        }

        private void buttonVerCursosAsign_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(ClassSeleccionCiclo.codigo))
            {
                FormReporteCiclo formReporteCiclo = new FormReporteCiclo();
                formReporteCiclo.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione un ciclo para ver los cursos");
            }
        }
    }
}
