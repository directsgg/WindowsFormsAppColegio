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
    public partial class FormIngresoCurso : Form
    {
        public FormIngresoCurso()
        {
            InitializeComponent();
        }

        DataTable tablaCurso = new DataTable();
        DataView vistaTablaCurso;
        string ubcCurso = "Archivos/Curso.txt";
        int indice = -1;

        private void FormIngresoCurso_Load(object sender, EventArgs e)
        {
            //agregar columnas a la tabla curso
            tablaCurso.Columns.Add("Codigo");
            tablaCurso.Columns.Add("Nombre");
            tablaCurso.Columns.Add("Estado");

            //agregar filas a la tabla curso
            StreamReader leer = new StreamReader(ubcCurso);
            while (!leer.EndOfStream)
            {
                string[] datos = leer.ReadLine().Split(',');

                tablaCurso.Rows.Add(datos);
            }
            leer.Close();
            vistaTablaCurso = new DataView(tablaCurso);
            vistaTablaCurso.RowFilter = "Estado > 0";

            dataGridViewCurso.DataSource = vistaTablaCurso;
            dataGridViewCurso.Columns["Estado"].Visible = false;

        }

        private void restablecer()
        {
            textBoxCurso.Clear();
            textBoxCurso.Focus();

            buttonGuardar.Enabled = true;
            buttonEditar.Enabled = false;
            buttonBorrar.Enabled = false;
            dataGridViewCurso.Enabled = true;

            indice = -1;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string curso = textBoxCurso.Text;
            if (!string.IsNullOrEmpty(curso))
            {
                string codigoCurso = (1000 + tablaCurso.Rows.Count).ToString();
                tablaCurso.Rows.Add(codigoCurso, curso, 1);
                StreamWriter escribir = new StreamWriter(ubcCurso, true);
                string linea = codigoCurso + "," +
                               curso + "," +
                               1;
                escribir.WriteLine(linea);
                escribir.Close();
                restablecer();
            }
            else
            {
                MessageBox.Show("Campo nombre curso esta vacio, intente nuevamente");
                textBoxCurso.Focus();
            }
        }

        private void dataGridViewCurso_DoubleClick(object sender, EventArgs e)
        {
            textBoxCurso.Text = dataGridViewCurso.CurrentRow.Cells["Nombre"].Value.ToString();
            textBoxCurso.Focus();

            buttonGuardar.Enabled = false;
            buttonEditar.Enabled = true;
            buttonBorrar.Enabled = true;
            dataGridViewCurso.Enabled = false;

            for (int i = 0; i < tablaCurso.Rows.Count; i++)
            {
                if (tablaCurso.Rows[i]["Codigo"].ToString() ==
                    dataGridViewCurso.CurrentRow.Cells["Codigo"].Value.ToString())
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

        private void actualizarBDCurso()
        {
            StreamWriter escribir = new StreamWriter(ubcCurso);
            foreach (DataRow filaCurso in tablaCurso.Rows)
            {
                string linea = filaCurso["Codigo"] + "," +
                               filaCurso["Nombre"] + "," +
                               filaCurso["Estado"];
                escribir.WriteLine(linea);
            }
            escribir.Close();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            string curso = textBoxCurso.Text;
            if (!string.IsNullOrEmpty(curso))
            {
                tablaCurso.Rows[indice]["Nombre"] = curso;
                actualizarBDCurso();
                MessageBox.Show("Dato actualizado con exito");
                restablecer();
            }
            else
            {
                MessageBox.Show("Campo nombre curso esta vacio, intente nuevamente");
                textBoxCurso.Focus();
            }
        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar el registro",
                               "Aviso",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Error) == DialogResult.Yes)
            {
                tablaCurso.Rows[indice]["Estado"] = 0;
                actualizarBDCurso();
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
