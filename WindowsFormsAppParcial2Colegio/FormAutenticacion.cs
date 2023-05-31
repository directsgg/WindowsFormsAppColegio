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
    public partial class FormAutenticacion : Form
    {
        public FormAutenticacion()
        {
            InitializeComponent();
        }

        string ubcUsuario = "Archivos/Usuario.txt";

        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {
            bool usuarioExiste = false;
            string usuario = textBoxUsuario.Text;
            string contrasenia = textBoxContrasenia.Text;
            StreamReader leer = new StreamReader(ubcUsuario);
            while (!leer.EndOfStream)
            {
                string[] datos = leer.ReadLine().Split(',');
                if(usuario == datos[0] && contrasenia == datos[1])
                {
                    usuarioExiste = true;
                    break;
                }
            }
            leer.Close();

            if (usuarioExiste)
            {
                this.Hide();
                FormPadre formPadre = new FormPadre();
                formPadre.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos, intente nuevamente");
            }
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxContrasenia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                buttonIniciarSesion.PerformClick();
            }
        }
    }
}
