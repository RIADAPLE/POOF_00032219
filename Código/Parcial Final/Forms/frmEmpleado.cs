using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Parcial_Final
{
    public partial class frmEmpleado : Form
    {
        private Empleado u;
        public frmEmpleado(Empleado p)
        {
            u = p;
            
            InitializeComponent();
            
            string sql = "SELECT * FROM \"registro\""+
                $"WHERE idusuario = {u.idusuario}";

            List<Registro> lista = new List<Registro>();

            lista = RegistroDAO.getLista(sql);
            //actualizar dataGrid
            dgvEmpleado.DataSource = null;
            dgvEmpleado.DataSource = lista;
        }


        private void frmEmpleado_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}