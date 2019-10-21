using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Asp.NETMVCCRUD.Models;
using Asp.NETMVCCRUD.dto;

namespace Asp.NETMVCCRUD.service
{
    public class AtividadeService
    {
        private static List<Atividade> lista = new List<Atividade>();

        public List<Atividade> getList()
        {
            return AtividadeService.lista;
        }

        public void save(Atividade atividade)
        {
            AtividadeService.lista.Add(atividade);
        }

        public void update(Atividade atividade)
        {
            
        }

        public void delete(int id)
        {
          
        }

        public Atividade find(int id)
        {
            throw new NotImplementedException();
        }

        public List<AtividadeDTO> getListDAO() {
            List<AtividadeDTO> dao = new List<AtividadeDTO>();

            getList().ForEach(x => dao.Add(new AtividadeDTO(x)));

            return dao;
                
        }
    }
}