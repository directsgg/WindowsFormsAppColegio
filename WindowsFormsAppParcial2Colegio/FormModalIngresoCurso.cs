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
    public partial class FormModalIngresoCurso : Form
    {
        public FormModalIngresoCurso()
        {
            InitializeComponent();
        }

        DataTable tablaCurso = new DataTable();
        DataView vistaTablaCurso;
        string ubcCurso = "Archivos/Curso.txt";
        
        private void FormModalIngresoCurso_Load(object sender, EventArgs e)
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

        private void dataGridViewCurso_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridViewCurso.Rows.Count != 0)
            {
                ClassDatosCurso.codigoCurso = dataGridViewCurso.CurrentRow.Cells["Codigo"].Value.ToString();
                ClassDatosCurso.nombre = dataGridViewCurso.CurrentRow.Cells["Nombre"].Value.ToString();
                this.Close();
            }
        }

        private void restablecer()
        {
            textBoxCurso.Clear();
            textBoxCurso.Focus();
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

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            restablecer();
        }
    }
}
