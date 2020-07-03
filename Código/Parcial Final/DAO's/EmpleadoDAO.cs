using System;
using System.Collections.Generic;
using System.Data;

namespace Parcial_Final
{
    public class EmpleadoDAO
    {
        public static List<Empleado> getLista()
        {
            string sql = "SELECT * FROM \"usuario\"";

            Conexion.IProxy proxy = new Conexion.Proxy();
            DataTable dt = proxy.IrealizarConsulta(sql);
            List<Empleado> lista = new List<Empleado>();
            foreach (DataRow fila in dt.Rows)
            {
                Empleado u = new Empleado();
                u.idusuario = Convert.ToInt32(fila[0].ToString());
                u.iddepartamento = Convert.ToInt32(fila[1].ToString());
                u.contraseña = fila[2].ToString();
                u.nombre = fila[3].ToString();
                u.apellido = fila[4].ToString();
                u.dui = fila[5].ToString();
                u.fechanacimiento = fila[6].ToString();
                lista.Add(u);
            }
            return lista;
        }
    }
}