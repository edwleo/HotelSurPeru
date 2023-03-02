using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL;

namespace BOL
{
    public class Empresa
    {

        DBAccess acceso = new DBAccess();

        public DataTable listasActivos()
        {
            return acceso.getDataFrom("spu_empresas_listar", 1);
        }
    }
}
