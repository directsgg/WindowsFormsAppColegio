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
    public partial class FormIngresoCiclo : Form
    {
        public FormIngresoCiclo()
        {
            InitializeComponent();
        }

        DataTable tablaCiclo = new DataTable();
        DataView vistaTablaCiclo;
        string ubcCiclo = "Archivos/Ciclo.txt";
        int indice = -1;

        private void FormIngresoCiclo_Load(object sender, EventArgs e)
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

        private void restablecer()
        {
            textBoxCiclo.Clear();
            textBoxCiclo.Focus();

            buttonGuardar.Enabled = true;
            buttonEditar.Enabled = false;
            buttonBorrar.Enabled = false;
            dataGridViewCiclo.Enabled = true;

            indice = -1;
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

        private void dataGridViewCiclo_DoubleClick(object sender, EventArgs e)
        {
            textBoxCiclo.Text = dataGridViewCiclo.CurrentRow.Cells["Nombre ciclo"].Value.ToString();
            textBoxCiclo.Focus();

            buttonGuardar.Enabled = false;
            buttonEditar.Enabled = true;
            buttonBorrar.Enabled = true;
            dataGridViewCiclo.Enabled = false;

            for (int i = 0; i < tablaCiclo.Rows.Count; i++)
            {
                if (tablaCiclo.Rows[i]["Codigo"].ToString() ==
                    dataGridViewCiclo.CurrentRow.Cells["Codigo"].Value.ToString())
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

        private void actualizarBDCiclo()
        {
            StreamWriter escribir = new StreamWriter(ubcCiclo);
            foreach (DataRow filaCiclo in tablaCiclo.Rows)
            {
                string linea = filaCiclo["Codigo"] + "," +
                               filaCiclo["Nombre ciclo"] + "," +
                               filaCiclo["Estado"];
                escribir.WriteLine(linea);
            }
            escribir.Close();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            string ciclo = textBoxCiclo.Text;
            if (!string.IsNullOrEmpty(ciclo))
            {
                tablaCiclo.Rows[indice]["Nombre ciclo"] = ciclo;
                actualizarBDCiclo();
                MessageBox.Show("Dato actualizado con exito");
                restablecer();
               
            }
            else
            {
                MessageBox.Show("Campo nombre ciclo esta vacio, intente nuevamente");
                textBoxCiclo.Focus();
            }
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar el registro",
                               "Aviso",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Error) == DialogResult.Yes)
            {
                tablaCiclo.Rows[indice]["Estado"] = 0;
                actualizarBDCiclo();
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
