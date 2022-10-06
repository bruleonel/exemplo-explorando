using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExemploExplorando.Models
{
    public class Venda
    {
        public int Id { get; set; }

        //quando o cliente usar um nome diferente do parametro, para não quebrar regras de convenção você pode usar:
        [JsonProperty("Nome_Produto")]
        public string Produto { get; set; }
        public decimal Preço { get; set; }
        public DateTime DataVenda { get; set; }

        //Propriedade pode ser nula
        public decimal? Desconto { get; set; }
    }
}