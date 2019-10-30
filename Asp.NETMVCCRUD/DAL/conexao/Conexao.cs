using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace Asp.NETMVCCRUD.dao.conexao
{
    public class Conexao
    { 
        public static OleDbConnection GetConexao()
        {
            OleDbConnection conn = null;
            string connectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\BRENDA\Desktop\Repositorio\PIM8-Faculdade\PIM8-Faculdade\Asp.NETMVCCRUD\obj\Debug\atividade.mdb";
            conn = new OleDbConnection(connectionString);

            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;

        }

        public static void FecharConexao(OleDbConnection conn)
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }

    
}
    