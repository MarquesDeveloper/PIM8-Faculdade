using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Asp.NETMVCCRUD.Models
{
    public class Atividade
    {
        public int Id { set; get; }
        public string Nome { set; get;}
        public string Tipo { set; get; }
        public DateTime DataLimite { set; get; }

       
    }

   
}