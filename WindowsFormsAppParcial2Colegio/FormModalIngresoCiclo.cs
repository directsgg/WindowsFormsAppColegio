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
    public partial class FormModalIngresoCiclo : Form
    {
        public FormModalIngresoCiclo()
        {
            InitializeComponent();
        }

        DataTable tablaCiclo = new DataTable();
        DataView vistaTablaCiclo;
        string ubcCiclo = "Archivos/Ciclo.txt";

        private void FormModalIngresoCiclo_Load(object sender, EventArgs e)
        {
            //agregar columnas a la tabla ciclo
            tablaCiclo.Columns.Add("Codigo");
            tablaCiclo.Columns.Add("Nombre ciclo");
            tablaCiclo.Columns.Add("Estado", typeof(int));

            //agregar filas a la tabla ciclo
            StreamReader leer = new StreamReader(ubcCiclo);
            while (!leer.EndOfStream)
            {
                string[] datos = leer.ReadLine().Split(',');

                tablaCiclo.Rows.Add(datos);
            }
            leer.Close();
            vistaTablaCiclo = new DataView(tablaCiclo);
            vistaTablaCiclo.RowFilter = "Estado > 0";

            dataGridViewCiclo.DataSource = vistaTablaCiclo;
            dataGridViewCiclo.Columns["Estado"].Visible = false;
        }

        private void dataGridViewCiclo_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewCiclo.Rows.Count != 0)
            {
                ClassDatosCiclo.codigoCiclo = dataGridViewCiclo.CurrentRow.Cells["Codigo"].Value.ToString();
                ClassDatosCiclo.nombre = dataGridViewCiclo.CurrentRow.Cells["Nombre ciclo"].Value.ToString();
                this.Close();
            }
        }

        private void restablecer()
        {
            textBoxCiclo.Clear();
            textBoxCiclo.Focus();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string ciclo = textBoxCiclo.Text;
            if (!string.IsNullOrEmpty(ciclo))
            {
                string codigoCiclo = (100 + tablaCiclo.Rows.Count).ToString();
                tablaCiclo.Rows.Add(codigoCiclo, ciclo, 1);
                StreamWriter escribir = new StreamWriter(ubcCiclo, true);
                string linea = codigoCiclo + "," +
                               ciclo + "," +
                               1;
                escribir.WriteLine(linea);
                escribir.Close();
                restablecer();
            }
            else
            {
                MessageBox.Show("Campo nombre ciclo esta vacio, intente nuevamente");
                textBoxCiclo.Focus();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            restablecer();
        }
    }
}
