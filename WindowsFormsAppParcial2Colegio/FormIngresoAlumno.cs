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
    public partial class FormIngresoAlumno : Form
    {
        public FormIngresoAlumno()
        {
            InitializeComponent();
        }

        DataTable tablaAlumno = new DataTable();
        DataView vistaTablaAlumno;
        DataTable tablaDepartamento = new DataTable();
        DataTable tablaMunicipio = new DataTable();
        DataTable tablaMunGlobal = new DataTable();
        string ubcAlumno = "Archivos/Alumno.txt";
        string ubcDepartamento = "Archivos/Departamento.txt";
        string ubcMunicipio = "Archivos/Municipio.txt";
        int indice = -1;

        private void FormIngresoAlumno_Load(object sender, EventArgs e)
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

            //agregar columnas a la tabla municipio
            tablaMunicipio.Columns.Add("codigo");
            tablaMunicipio.Columns.Add("municipio");
            comboBoxMunicipio.DataSource = tablaMunicipio;
            comboBoxMunicipio.DisplayMember = "municipio";
            comboBoxMunicipio.ValueMember = "codigo";

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
            comboBoxDepartamento.DataSource = tablaDepartamento;
            comboBoxDepartamento.DisplayMember = "departamento";
            comboBoxDepartamento.ValueMember = "codigo";
            comboBoxDepartamento.SelectedIndex = -1;

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

        private void comboBoxDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                tablaMunicipio.Rows.Clear();
                StreamReader leer = new StreamReader(ubcMunicipio);
                while (!leer.EndOfStream)
                {
                    string[] datos = leer.ReadLine().Split(',');
                    if (datos[2] == comboBoxDepartamento.SelectedValue.ToString())
                    {
                        tablaMunicipio.Rows.Add(datos[0], datos[1]);
                    }
                }
                leer.Close();
            }
            catch (Exception)
            {

            }
        }

        private void restablecer()
        {
            textBoxCarne.Clear();
            textBoxNombre.Clear();
            textBoxApellido.Clear();
            textBoxCarne.Focus();

            buttonGuardar.Enabled = true;
            buttonEditar.Enabled = false;
            buttonBorrar.Enabled = false;
            textBoxCarne.Enabled = true;
            dataGridViewAlumno.Enabled = true;

            tablaMunicipio.Rows.Clear();
            comboBoxDepartamento.SelectedIndex = -1;

            indice = -1;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string carne = textBoxCarne.Text;
            string nombre = textBoxNombre.Text;
            string apellido = textBoxApellido.Text;
            DateTime fAct = DateTime.Now;
            string fNacString = dateTimePickerFNac.Text;
            DateTime fNacDateTime = DateTime.ParseExact(fNacString, "dd/MM/yyyy", null);

            if (carne.Length == 10)
            {
                if (!string.IsNullOrEmpty(nombre))
                {
                    if (!string.IsNullOrEmpty(apellido))
                    {
                        if (comboBoxDepartamento.SelectedIndex != -1)
                        {
                            string codMunicipio = comboBoxMunicipio.SelectedValue.ToString();
                            if (fAct >= fNacDateTime)
                            {
                                bool existeCarne = false;
                                foreach (DataRow filaAlumno in tablaAlumno.Rows)
                                {
                                    if (filaAlumno["Carne"].ToString() == carne)
                                    {
                                        existeCarne = true;
                                        break;
                                    }
                                }
                                if (!existeCarne)
                                {
                                    string municipio = comboBoxMunicipio.Text;
                                    string departamento = comboBoxDepartamento.Text;
                                    tablaAlumno.Rows.Add(carne, nombre, apellido, fNacString, municipio, departamento, 1);
                                    StreamWriter escribir = new StreamWriter(ubcAlumno, true);
                                    string linea = carne + "," +
                                                   nombre + "," +
                                                   apellido + "," +
                                                   fNacString + "," +
                                                   codMunicipio + "," +
                                                   1;
                                    escribir.WriteLine(linea);
                                    escribir.Close();
                                    restablecer();
                                }
                                else MessageBox.Show("Carné ya existe, intente nuevamente",
                                                     "Operacion invalida",
                                                     MessageBoxButtons.OK,
                                                     MessageBoxIcon.Warning);
                            }
                            else { MessageBox.Show("Seleccione una fecha menor a la actual"); dateTimePickerFNac.Focus(); }
                        }
                        else { MessageBox.Show("Seleccione un departamento"); comboBoxDepartamento.Focus(); }
                    }
                    else { MessageBox.Show("Campo apellido esta vacio, intente nuevamente"); textBoxApellido.Focus(); }
                }
                else { MessageBox.Show("Campo nombre esta vacio, intente nuevamente"); textBoxNombre.Focus(); }
            }
            else { MessageBox.Show("Carné debe contener 10 digitos, intente nuevamente"); textBoxCarne.Focus(); }

        }

        private void dataGridViewAlumno_DoubleClick(object sender, EventArgs e)
        {
            textBoxCarne.Text = dataGridViewAlumno.CurrentRow.Cells["Carne"].Value.ToString();
            textBoxNombre.Text = dataGridViewAlumno.CurrentRow.Cells["Nombre"].Value.ToString();
            textBoxApellido.Text = dataGridViewAlumno.CurrentRow.Cells["Apellido"].Value.ToString();
            dateTimePickerFNac.Text = dataGridViewAlumno.CurrentRow.Cells["Fecha Nacimiento"].Value.ToString();
            int codMunicipio = 0, codDepartamento = 0;

            foreach (DataRow filaMunicipio in tablaMunGlobal.Rows)
            {
                if (filaMunicipio["municipio"].ToString() == dataGridViewAlumno.CurrentRow.Cells["Municipio"].Value.ToString())
                {
                    codMunicipio = Convert.ToInt32(filaMunicipio["codigo"]);
                    codDepartamento = Convert.ToInt32(filaMunicipio["codDepartamento"]);
                    break;
                }
            }
            comboBoxDepartamento.SelectedValue = codDepartamento;
            comboBoxMunicipio.SelectedValue = codMunicipio;

            textBoxCarne.Enabled = false;
            buttonGuardar.Enabled = false;
            buttonEditar.Enabled = true;
            buttonBorrar.Enabled = true;
            dataGridViewAlumno.Enabled = false;

            for (int i = 0; i < tablaAlumno.Rows.Count; i++)
            {
                if (tablaAlumno.Rows[i]["Carne"].ToString() ==
                    dataGridViewAlumno.CurrentRow.Cells["Carne"].Value.ToString())
                {
                    indice = i;
                    break;
                }
            }
            textBoxNombre.Focus();

            if (indice == -1)
            {
                MessageBox.Show("Ocurrio un error inesperado, intente de nuevo");
                restablecer();
            }
            //indice = dataGridViewProfesor.CurrentRow.Index;
        }

        private void actualizarBDAlumno()
        {
            StreamWriter escribir = new StreamWriter(ubcAlumno);
            foreach (DataRow filaAlumno in tablaAlumno.Rows)
            {
                string codMunicipio = "";
                foreach (DataRow filaMunicipio in tablaMunGlobal.Rows)
                {
                    if (filaMunicipio["municipio"].ToString() == filaAlumno["Municipio"].ToString())
                    {
                        codMunicipio = filaMunicipio["codigo"].ToString();
                        break;
                    }
                }
                string linea = filaAlumno["Carne"] + "," +
                               filaAlumno["Nombre"] + "," +
                               filaAlumno["Apellido"] + "," +
                               filaAlumno["Fecha Nacimiento"] + "," +
                               codMunicipio + "," +
                               filaAlumno["Estado"];
                escribir.WriteLine(linea);
            }
            escribir.Close();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            string apellido = textBoxApellido.Text;
            DateTime fAct = DateTime.Now;
            string fNacString = dateTimePickerFNac.Text;
            DateTime fNacDateTime = DateTime.ParseExact(fNacString, "dd/MM/yyyy", null);

            if (!string.IsNullOrEmpty(nombre))
            {
                if (!string.IsNullOrEmpty(apellido))
                {
                    if (comboBoxDepartamento.SelectedIndex != -1)
                    {
                        string codMunicipio = comboBoxMunicipio.SelectedValue.ToString();
                        if (fAct >= fNacDateTime)
                        {

                            string municipio = comboBoxMunicipio.Text;
                            string departamento = comboBoxDepartamento.Text;
                            
                            tablaAlumno.Rows[indice]["Nombre"] = nombre;
                            tablaAlumno.Rows[indice]["Apellido"] = apellido;
                            tablaAlumno.Rows[indice]["Fecha Nacimiento"] = fNacString;
                            tablaAlumno.Rows[indice]["Municipio"] = municipio;
                            tablaAlumno.Rows[indice]["Departamento"] = departamento;

                            actualizarBDAlumno();
                            MessageBox.Show("Datos actualizados con exito");
                            restablecer();
                        }
                        else { MessageBox.Show("Seleccione una fecha menor a la actual"); dateTimePickerFNac.Focus(); }
                    }
                    else { MessageBox.Show("Seleccione un departamento"); comboBoxDepartamento.Focus(); }
                }
                else { MessageBox.Show("Campo apellido esta vacio, intente nuevamente"); textBoxApellido.Focus(); }
            }
            else { MessageBox.Show("Campo nombre esta vacio, intente nuevamente"); textBoxNombre.Focus(); }

        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar el registro",
                               "Aviso",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Error) == DialogResult.Yes)
            {
                tablaAlumno.Rows[indice]["Estado"] = 0;
                actualizarBDAlumno();
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
