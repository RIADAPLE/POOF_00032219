using System;
using System.Collections.Generic;
using System.Data;

namespace Parcial_Final
{
    public class RegistroDAO
    {
        public static List<Registro> getLista(string sql)
        {
            //string sql = "SELECT * FROM \"registro\"";
            Conexion.IProxy proxy = new Conexion.Proxy();
            DataTable dt = proxy.IrealizarConsulta(sql);
            List<Registro> lista = new List<Registro>();
            foreach (DataRow fila in dt.Rows)
            {
                Registro u = new Registro();
                u.idregistro = Convert.ToInt32(fila[0].ToString());
                u.idusuario = Convert.ToInt32(fila[1].ToString());
                u.entrada = Convert.ToBoolean(fila[2].ToString());
                u.temperatura = Convert.ToDouble(fila[3].ToString());
                u.fechayhora = fila[4].ToString();
                lista.Add(u);
            }
            return lista;
        }
    }
}