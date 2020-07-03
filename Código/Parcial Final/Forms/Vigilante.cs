using System;
using System.Windows.Forms;

namespace Parcial_Final
{
    public partial class Vigilante : Form
    {
        Conexion.IProxy proxy = new Conexion.Proxy();
        public Vigilante()
        {
            InitializeComponent();
        }

        private void Vigilante_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void Actualizar()
        {
            //Combo box de entrada
            cmbUsuarioE.DataSource = null;
            cmbUsuarioE.ValueMember = "idusuario";
            cmbUsuarioE.DisplayMember = "nombre";
            cmbUsuarioE.DataSource = EmpleadoDAO.getLista();
            
            //Combo box de salida
            cmbUsuarioS.DataSource = null;
            cmbUsuarioS.ValueMember = "idusuario";
            cmbUsuarioS.DisplayMember = "nombre";
            cmbUsuarioS.DataSource = EmpleadoDAO.getLista();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtTemperaturaT.Text.Equals("") || txtFecYHoraE.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacios");
            }
            else
            {
                try
                {
                    proxy.IrealizarAccion($"insert into \"registro\"" +
                                            $"(\"idusuario\",\"entrada\", \"temperatura\",\"fechayhora\")" +
                                            $"values ({cmbUsuarioE.SelectedValue}, True, {txtTemperaturaT.Text},'{txtFecYHoraE.Text}')");
                    MessageBox.Show("Se ha hecho el registro");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
            Actualizar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (txtTemperaturaS.Text.Equals("") || txtFecYHoraS.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacios");
            }
            else
            {
                try
                {
                    
                    proxy.IrealizarAccion($"insert into \"registro\"" +
                                            $"(\"idusuario\",\"entrada\", \"temperatura\",\"fechayhora\")" +
                                            $"values ({cmbUsuarioS.SelectedValue}, False, {txtTemperaturaS.Text},'{txtFecYHoraS.Text}')");
                    MessageBox.Show("Se ha hecho el registro");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
            }
            Actualizar();
        }


        private void Vigilante_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}