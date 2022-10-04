using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Venda
    {
        public Venda(int id, string produto, decimal preço)
        {
            Id = id;
            Produto = produto;
            Preço = preço;
        }
        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Preço { get; set; }
    }
}