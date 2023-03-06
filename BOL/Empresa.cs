using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;
using ENTITIES;

namespace BOL
{
    public class Empresa
    {

        DBAccess acceso = new DBAccess();

        public DataTable listarActivos()
        {
            return acceso.getDataFrom("spu_empresas_listar", 1);
        }

        /// <summary>
        /// Este método agrega una nueva empresa en la base de datos, retorna un valor superior a 0 cuando se concreta la tarea.
        /// </summary>
        /// <param name="entidad"></param>
        /// <returns>int</returns>
        public int registrar(EEmpresa entidad)
        {
            int registrosAfectados = 0;

            acceso.conectar();

            SqlCommand sqlCommand = new SqlCommand("spu_empresas_registrar", acceso.getConexion());
            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@razonsocial", entidad.razonSocial);
            sqlCommand.Parameters.AddWithValue("@ruc", entidad.ruc);
            sqlCommand.Parameters.AddWithValue("@direccion", entidad.direccion);
            sqlCommand.Parameters.AddWithValue("@telefono", entidad.telefono);
            sqlCommand.Parameters.AddWithValue("@email", entidad.email);

            registrosAfectados = sqlCommand.ExecuteNonQuery();

            acceso.desconectar();

            return registrosAfectados;
        }
    }
}
