using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using Asp.NETMVCCRUD.dao.conexao;
using Asp.NETMVCCRUD.Models;

namespace Asp.NETMVCCRUD.dao
{
    public class AtividadeDAO:Conexao
    {


        public List<Atividade> Findall()
        {
            string query = "SELECT Id, Nome , Tipo , DataLimite FROM atividade ORDER BY Id";
            OleDbDataReader reader = null;
            OleDbConnection conn = null;
            Atividade a = null;
            List<Atividade> list = new List<Atividade>();
            try
            {
                conn = GetConexao();
                OleDbCommand cmd = new OleDbCommand(query, conn);
                while (reader.Read())
                {
                    a = new Atividade();
                    a.Id = (int)reader["Id"];
                    a.Nome = reader["Nome"].ToString();
                    a.Tipo = reader["Tipo"].ToString();
                   
                    list.Add(a);
                }



            } catch (Exception e)
            {
                throw e;

            }
            finally
            {
                if (conn!=null)
                {
                    conn.Close();
                }
            }

            return list;
        }

        public Atividade Find(int id)
        {
            string query = "SELECT Id, Nome, Tipo, DataLimite FROM Pessoa WHERE Id=@Id";
            OleDbDataReader reader = null;
            OleDbConnection conn = null;
            Atividade a = null;

            try
            {
                conn = GetConexao();
                OleDbCommand cmd = new OleDbCommand(query, conn);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        a = new Atividade();
                        a.Id = (int)reader["Id"];
                        a.Nome = reader["Nome"].ToString();
                        a.Tipo= reader["Tipo"].ToString();
                        
                      
                    }
                }

                reader.Close();
                FecharConexao(conn);
                return a;



            } catch (Exception e)
            {

                throw e;
            }

            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }

            }





        }

     
        public bool Save(string Nome, string Tipo, DateTime DataLimite ) {

            string query = "INSERT INTO atividade (Nome,Atividade,Tipo, DataLimite) VALUES (@Nome, @Atividade, @Tipo,@DataLimite)";
            OleDbDataReader reader = null;
            OleDbConnection conn = null;

            try
            {
                conn = GetConexao();


                OleDbCommand cmd = new OleDbCommand(query, conn);
                reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    return true;
                }
                FecharConexao(conn);
            }
            catch(Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            return true;
        }
        

        public bool Update(int Id, string Nome, string Tipo, DateTime DataLimite) {

            string query = "UPDATE atividade SET Nome=@Nome, Tipo=@Email, DataLimite=@Cidade WHERE Id=@Id";

            OleDbDataReader reader = null;
            OleDbConnection conn = null;
            try
            {

                conn = GetConexao();

                OleDbCommand cmd = new OleDbCommand(query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    return true;
                }
                FecharConexao(conn);
            }

            catch(Exception ex)
            {

                throw ex;
            }

            finally
            {
                if (conn != null)
                {

                    conn.Close();
                }
            }
            return true;

        }

        public bool Delete(int id)
        {
            string query = "DELETE atividade Where Id=@Id";

            OleDbDataReader reader = null;
            OleDbConnection conn = null;
            try
            {

                conn = GetConexao();

                OleDbCommand cmd = new OleDbCommand(query, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    return true;
                }
                FecharConexao(conn);
            }

            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                if (conn != null)
                {

                    conn.Close();
                }
            }
            return true;

        }



    }
}
