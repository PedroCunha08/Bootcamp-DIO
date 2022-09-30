using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace C_Aula11.Models
{
    public class Vendas
    {
        public Vendas(int id, string produto, decimal preco, DateTime dataVenda)
        {
            Id        = id;
            Produto   = produto;
            Preco     = preco;
            dataVenda = dataVenda;

        }
        public int       Id      { get; set;  }
        public string    Produto { get; set;  }
        public decimal   Preco   { get; set;  }
        public DateTime  DataVenda { get; set; }
    }
}