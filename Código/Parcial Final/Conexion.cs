using System;
using System.Data;
using Npgsql;

namespace Parcial_Final
{
    public static class Conexion
    {
        public interface IProxy
        {
            DataTable IrealizarConsulta(string query);
            void IrealizarAccion(string act);
        }

        public class Proxy : IProxy
        {
            public DataTable IrealizarConsulta(string query)
            {
                return ConexionP.realizarConsulta(query);
            }

            public void IrealizarAccion(string act)
            {
                ConexionP.realizarAccion(act);
            }
        }
        private static class ConexionP
        {
            private static string sConection =
                "Server=127.0.0.1;Port=5432;User Id=postgres;Password=carro0707;Database=Final";

            public static DataTable realizarConsulta(string query)
            {
                NpgsqlConnection connection = new NpgsqlConnection(sConection);
                DataSet ds = new DataSet();

                connection.Open();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, connection);
                da.Fill(ds);

                connection.Close();

                return ds.Tables[0];
            }

            public static void realizarAccion(string act)
            {
                NpgsqlConnection connection = new NpgsqlConnection(sConection);

                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(act, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}