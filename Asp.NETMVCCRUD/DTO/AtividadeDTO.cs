using Asp.NETMVCCRUD.Models;

namespace Asp.NETMVCCRUD.dto
{
    public class AtividadeDTO
    {
        public int Id { set; get; }
        public string Nome { set; get; }
        public string Tipo { set; get; }
        public string DataLimite { set; get; }


        public AtividadeDTO() { }

        public AtividadeDTO(Atividade atividade) {
            Id = atividade.Id;
            Nome = atividade.Nome;
            DataLimite = atividade.DataLimite.ToString();
        }
    }
}