using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace Asp.NETMVCCRUD.dao.conexao
{
    public class Conexao
    {
        public static OleDbConnection getConexao()
        {

            return null;
        }

        public static void fecharConexao(OleDbConnection conn)
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }

    
}
    