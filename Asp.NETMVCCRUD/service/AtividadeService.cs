using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Asp.NETMVCCRUD.Models;
using Asp.NETMVCCRUD.dto;
using Asp.NETMVCCRUD.dao;

namespace Asp.NETMVCCRUD.service
{
    public class AtividadeService
    {
        AtividadeDAO dao = new AtividadeDAO();

        public List<Atividade> getList()
        {
            return dao.Findall();
        }

        public void save(int Id, string Nome, string Tipo, DateTime DataLimite)
        {
            dao.Save(Nome,Tipo,DataLimite);
        }

        public void update(string Nome, string Tipo, DateTime Datalimite)
        {

            return dao.Update();
        }

        public void delete(int id)
        {
            dao.Delete(id);
        }

        public Atividade find(int id)
        {
           return  dao.Find(id);
        }

        public List<AtividadeDTO> getListDTO() {
            List<AtividadeDTO> dto = new List<AtividadeDTO>();

            getList().ForEach(x => dto.Add(new AtividadeDTO(x)));

            return dto;
                
        }
    }
}