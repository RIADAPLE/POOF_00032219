using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Parcial_Final
{
    public partial class Admin : Form
    {
        Conexion.IProxy proxy = new Conexion.Proxy();
        private delegate void MiDelegate();
        private static MiDelegate Invocafunc;
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void Actualizar()
        {
            //Poblar Departamento
            cmbDepartamento.DataSource = null;
            cmbDepartamento.ValueMember = "iddepartamento";
            cmbDepartamento.DisplayMember = "nombre";
            cmbDepartamento.DataSource = DepartamentoDAO.getLista();
            
            //Poblar usuario
            cmbUsuario.DataSource = null;
            cmbUsuario.ValueMember = "idusuario";
            cmbUsuario.DisplayMember = "nombre";
            cmbUsuario.DataSource = EmpleadoDAO.getLista();
            
            //Poblar registros
            string sql = "SELECT * FROM \"registro\"";

            List<Registro> lista = new List<Registro>();

            lista = RegistroDAO.getLista(sql);
            //actualizar dataGrid
            dgvRegistros.DataSource = null;
            dgvRegistros.DataSource = lista;
            
            //Top empresa
            var dt = proxy.IrealizarConsulta("SELECT d.iddepartamento, d.nombre, d.ubicacion, count(u.iddepartamento) as frecuencia FROM \"departamento\" d, \"registro\" r,  \"usuario\" u WHERE r.idusuario = u.idusuario AND d.iddepartamento = u.iddepartamento GROUP BY d.iddepartamento ORDER BY frecuencia DESC LIMIT 1");
            List<Departamento> lista1 = new List<Departamento>();
            foreach (DataRow fila in dt.Rows)
            {
                Departamento u = new Departamento();
                u.iddepartamento = Convert.ToInt32(fila[0].ToString());
                u.nombre = fila[1].ToString();
                u.ubicacion = fila[2].ToString();
                u.frecuencia = Convert.ToInt32(fila[3].ToString());
                lista1.Add(u);
            }
            dgvEmpresa.DataSource = lista1;
            
            //
        }
        private void btnAgreUsu_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("") || txtContraseña.Text.Equals("")|| txtApellido.Text.Equals("") || txtDui.Text.Equals("")
            || txtFecNac.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacios");
            }
            else
            {
                try
                {
                    proxy.IrealizarAccion($"insert into \"usuario\"" +
                                            $"(\"iddepartamento\",\"contraseña\", \"nombre\", \"apellido\", \"dui\", \"fechanacimiento\")" +
                                            $"values ({cmbDepartamento.SelectedValue}, '{txtContraseña.Text}'," +
                                            $"'{txtNombre.Text}','{txtApellido.Text}','{txtDui.Text}', '{txtFecNac.Text}')");
                    MessageBox.Show("Se ha registrado el usuario");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error");
                }
                Actualizar();
            }
        }

        private void btnElimiUsua_Click(object sender, EventArgs e)
        {
            try
            {
                proxy.IrealizarAccion($"DELETE FROM \"usuario\" WHERE \"idusuario\" = {cmbUsuario.SelectedValue}");
                MessageBox.Show("Se ha eliminado el usuario");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
            }
            Actualizar();
        }
        
        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}