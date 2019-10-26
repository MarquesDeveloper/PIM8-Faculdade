using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Asp.NETMVCCRUD.Models;

namespace Asp.NETMVCCRUD.dao
{
    public class AtividadeDAO
    {

        

        public List<Atividade> findALL()
        {
            string query = "select * from Atividade";

            return null; 
        }

        public Atividade find(int id) 
        {
            string query = "select * from Atividade where id = " + id;

            return null;
        }

        public void save(Atividade atividade) {

            string query = "insert into Ativadade (nome, tipo, dataLimite) values ('" + atividade.Nome + "', '" + atividade.Tipo + "', '" + atividade.DataLimite + "')";

            
        }

        public void update(Atividade atividade) { }

        public void delete(int id)
        {
            string query = "select * from Atividade where id = " + id;

        } 
    }
}