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
    public partial class FormIngresoProfesor : Form
    {
        public FormIngresoProfesor()
        {
            InitializeComponent();
        }

        DataTable tablaProfesor = new DataTable();
        DataView vistaTablaProfesor; 
        DataTable tablaDepartamento = new DataTable();
        DataTable tablaMunicipio = new DataTable();
        DataTable tablaMunGlobal = new DataTable();
        string ubcProfesor = "Archivos/Profesor.txt";
        string ubcDepartamento = "Archivos/Departamento.txt";
        string ubcMunicipio = "Archivos/Municipio.txt";
        int indice = -1;

        private void FormIngresoProfesor_Load(object sender, EventArgs e)
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
            textBoxDPI.Clear();
            textBoxNombre.Clear();
            textBoxDireccion.Clear();
            textBoxTelefono.Clear();
            textBoxDPI.Focus();

            buttonGuardar.Enabled = true;
            buttonEditar.Enabled = false;
            buttonBorrar.Enabled = false;
            textBoxDPI.Enabled = true;
            dataGridViewProfesor.Enabled = true;

            tablaMunicipio.Rows.Clear();
            comboBoxDepartamento.SelectedIndex = -1;

            indice = -1;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string DPI = textBoxDPI.Text;
            string nombre = textBoxNombre.Text;
            string direccion = textBoxDireccion.Text;
            string telefono = textBoxTelefono.Text;

            if (!string.IsNullOrEmpty(DPI))
            {
                if (DPI.Length == 13)
                {
                    if (!string.IsNullOrEmpty(nombre))
                    {
                        if (!string.IsNullOrEmpty(direccion))
                        {
                            if (comboBoxDepartamento.SelectedIndex != -1)
                            {
                                string codMunicipio = comboBoxMunicipio.SelectedValue.ToString();
                                if (telefono.Length == 8)
                                {
                                    bool existeDPI = false;
                                    foreach (DataRow filaProfesor in tablaProfesor.Rows)
                                    {
                                        if (filaProfesor["DPI"].ToString() == DPI)
                                        {
                                            existeDPI = true;
                                            break;
                                        }
                                    }
                                    if (!existeDPI)
                                    {
                                        string municipio = comboBoxMunicipio.Text;
                                        string departamento = comboBoxDepartamento.Text;
                                        tablaProfesor.Rows.Add(DPI, nombre, direccion, telefono, municipio, departamento, 1);
                                        StreamWriter escribir = new StreamWriter(ubcProfesor, true);
                                        string linea = DPI + "," +
                                                       nombre + "," +
                                                       direccion + "," +
                                                       telefono + "," +
                                                       codMunicipio + "," +
                                                       1;
                                        escribir.WriteLine(linea);
                                        escribir.Close();
                                        restablecer();
                                    }
                                    else MessageBox.Show("Dpi ya existe, intente nuevamente",
                                                         "Operacion invalida",
                                                         MessageBoxButtons.OK,
                                                         MessageBoxIcon.Warning);
                                }
                                else { MessageBox.Show("Telefono debe contener 8 digitos, intente nuevamente"); textBoxTelefono.Focus(); }
                            }
                            else { MessageBox.Show("Seleccione un departamento"); comboBoxDepartamento.Focus(); }
                        }
                        else { MessageBox.Show("Campo direccion esta vacio, intente nuevamente"); textBoxDireccion.Focus(); }
                    }
                    else { MessageBox.Show("Campo nombre esta vacio, intente nuevamente"); textBoxNombre.Focus(); }
                }
                else { MessageBox.Show("DPI debe contener 13 digitos, intente nuevamente"); textBoxDPI.Focus(); }
            }
            else { MessageBox.Show("Campo DPI esta vacio, intente nuevamente"); textBoxDPI.Focus(); }
        }

        private void dataGridViewProfesor_DoubleClick(object sender, EventArgs e)
        {
            textBoxDPI.Text = dataGridViewProfesor.CurrentRow.Cells["DPI"].Value.ToString();
            textBoxNombre.Text = dataGridViewProfesor.CurrentRow.Cells["Nombre y Apellido"].Value.ToString();
            textBoxDireccion.Text = dataGridViewProfesor.CurrentRow.Cells["Direccion"].Value.ToString();
            textBoxTelefono.Text = dataGridViewProfesor.CurrentRow.Cells["Telefono"].Value.ToString();
            int codMunicipio = 0, codDepartamento = 0;

            foreach (DataRow filaMunicipio in tablaMunGlobal.Rows)
            {
                if (filaMunicipio["municipio"].ToString() == dataGridViewProfesor.CurrentRow.Cells["Municipio"].Value.ToString())
                {
                    codMunicipio = Convert.ToInt32(filaMunicipio["codigo"]);
                    codDepartamento = Convert.ToInt32(filaMunicipio["codDepartamento"]);
                    break;
                }
            }
            comboBoxDepartamento.SelectedValue = codDepartamento;
            comboBoxMunicipio.SelectedValue = codMunicipio;

            textBoxDPI.Enabled = false;
            buttonGuardar.Enabled = false;
            buttonEditar.Enabled = true;
            buttonBorrar.Enabled = true;
            dataGridViewProfesor.Enabled = false;
            
            for(int i = 0; i < tablaProfesor.Rows.Count; i++)
            {
                if(tablaProfesor.Rows[i]["DPI"].ToString() == 
                    dataGridViewProfesor.CurrentRow.Cells["DPI"].Value.ToString())
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

        private void actualizarBDProfesor()
        {
            StreamWriter escribir = new StreamWriter(ubcProfesor);
            foreach (DataRow filaProfesor in tablaProfesor.Rows)
            {
                string codMunicipio = "";
                foreach (DataRow filaMunicipio in tablaMunGlobal.Rows)
                {
                    if (filaMunicipio["municipio"].ToString() == filaProfesor["Municipio"].ToString())
                    {
                        codMunicipio = filaMunicipio["codigo"].ToString();
                        break;
                    }
                }
                string linea = filaProfesor["DPI"] + "," +
                               filaProfesor["Nombre y Apellido"] + "," +
                               filaProfesor["Direccion"] + "," +
                               filaProfesor["Telefono"] + "," +
                               codMunicipio + "," +
                               filaProfesor["Estado"];
                escribir.WriteLine(linea);
            }
            escribir.Close();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            string direccion = textBoxDireccion.Text;
            string telefono = textBoxTelefono.Text;

            if (!string.IsNullOrEmpty(nombre))
            {
                if (!string.IsNullOrEmpty(direccion))
                {
                    if (comboBoxDepartamento.SelectedIndex != -1)
                    {
                        string codMunicipio = comboBoxMunicipio.SelectedValue.ToString();
                        if (telefono.Length == 8)
                        {
                            string municipio = comboBoxMunicipio.Text;
                            string departamento = comboBoxDepartamento.Text;

                            tablaProfesor.Rows[indice]["Nombre y Apellido"] = nombre;
                            tablaProfesor.Rows[indice]["Direccion"] = direccion;
                            tablaProfesor.Rows[indice]["Telefono"] = telefono;
                            tablaProfesor.Rows[indice]["Municipio"] = municipio;
                            tablaProfesor.Rows[indice]["Departamento"] = departamento;

                            actualizarBDProfesor();
                            MessageBox.Show("Datos actualizados con exito");
                            restablecer();
                        }
                        else { MessageBox.Show("Telefono debe contener 8 digitos, intente nuevamente"); textBoxTelefono.Focus(); }
                    }
                    else { MessageBox.Show("Seleccione un departamento"); comboBoxDepartamento.Focus(); }
                }
                else { MessageBox.Show("Campo direccion esta vacio, intente nuevamente"); textBoxDireccion.Focus(); }
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
                tablaProfesor.Rows[indice]["Estado"] = 0;
                actualizarBDProfesor();
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
