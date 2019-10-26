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
            return dao.findALL();
        }

        public void save(Atividade atividade)
        {
            dao.save(atividade);   
        }

        public void update(Atividade atividade)
        {
            dao.update(atividade);
        }

        public void delete(int id)
        {
            dao.delete(id);
        }

        public Atividade find(int id)
        {
           return  dao.find(id);
        }

        public List<AtividadeDTO> getListDTO() {
            List<AtividadeDTO> dto = new List<AtividadeDTO>();

            getList().ForEach(x => dto.Add(new AtividadeDTO(x)));

            return dto;
                
        }
    }
}