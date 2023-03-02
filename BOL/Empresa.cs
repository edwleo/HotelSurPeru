using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;

namespace BOL
{
    public class Empresa
    {

        DBAccess acceso = new DBAccess();

        public DataTable listarActivos()
        {
            return acceso.getDataFrom("spu_empresas_listar", 1);
        }

        public int registrar(string razonsocial, string ruc, string direccion, string telefono, string email)
        {
            int registrosAfectados = 0;

            acceso.conectar();

            SqlCommand sqlCommand = new SqlCommand("spu_empresas_registrar", acceso.getConexion());
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@razonsocial", razonsocial);
            sqlCommand.Parameters.AddWithValue("@ruc", ruc);
            sqlCommand.Parameters.AddWithValue("@direccion", direccion);
            sqlCommand.Parameters.AddWithValue("@telefono", telefono);
            sqlCommand.Parameters.AddWithValue("@email", email);

            registrosAfectados = sqlCommand.ExecuteNonQuery();

            acceso.desconectar();

            return registrosAfectados;
        }
    }
}
