using System;
using System.Windows.Forms;

namespace Parcial_Final
{
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }
        private void poblarControles()
        {
            // Actualizar ComboBox
            cmbUsuario.DataSource = null;
            cmbUsuario.ValueMember = "contraseña";
            cmbUsuario.DisplayMember = "nombre";
            cmbUsuario.DataSource = EmpleadoDAO.getLista();
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {
            poblarControles();
        }

        private void btnIniSes_Click(object sender, EventArgs e)
        {
            
            if (cmbUsuario.SelectedValue.Equals(txtContraseña.Text))
            {
                Empleado u = (Empleado) cmbUsuario.SelectedItem;

                MessageBox.Show("¡Bienvenido!", 
                    "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                frmEmpleado ventana = new frmEmpleado(u);
                ventana.Show();
                this.Hide();
                    
            }
            else
                MessageBox.Show("¡Contraseña incorrecta!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        private void InicioSesion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}