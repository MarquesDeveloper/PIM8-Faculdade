using Asp.NETMVCCRUD.Models;

namespace Asp.NETMVCCRUD.dao
{
    public class AtividadeDAO
    {
        public int Id { set; get; }
        public string Nome { set; get; }
        public string Tipo { set; get; }
        public string DataLimite { set; get; }


        public AtividadeDAO() { }

        public AtividadeDAO(Atividade atividade) {
            Id = atividade.Id;
            Nome = atividade.Nome;
            DataLimite = atividade.DataLimite.ToString();
        }
    }
}