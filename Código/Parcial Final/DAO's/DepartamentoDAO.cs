using System;
using System.Collections.Generic;
using System.Data;

namespace Parcial_Final
{
    public class DepartamentoDAO
    {
        public static List<Departamento> getLista()
        {
            string sql = "SELECT * FROM \"departamento\"";
            Conexion.IProxy proxy = new Conexion.Proxy();
            DataTable dt = proxy.IrealizarConsulta(sql);
            List<Departamento> lista = new List<Departamento>();
            foreach (DataRow fila in dt.Rows)
            {
                Departamento u = new Departamento();
                u.iddepartamento = Convert.ToInt32(fila[0].ToString());
                u.nombre = fila[1].ToString();
                u.ubicacion = fila[2].ToString();
                lista.Add(u);
            }
            return lista;
        }
    }
}