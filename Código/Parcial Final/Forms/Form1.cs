using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (cmbTipoUsuario.Text.Equals("Vigilante"))
            {
                Vigilante vigilante = new Vigilante();
                vigilante.Show();
                this.Hide();
            }
            else if(cmbTipoUsuario.Text.Equals("Empleado"))
            {
                InicioSesion ventana = new InicioSesion();
                ventana.Show();
                this.Hide(); 
            }
            else
            {
                Admin ventana2 = new Admin();
                ventana2.Show();
                this.Hide();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}