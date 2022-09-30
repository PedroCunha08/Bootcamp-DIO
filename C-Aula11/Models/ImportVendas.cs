using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace C_Aula11.Models
{
    public class ImportVendas
    {
        [JsonProperty("_Id")]
        public int       Id      { get; set;  }
        [JsonProperty("_Produto")]
        public string    Produto { get; set;  }
        [JsonProperty("_Preco")]
        public decimal   Preco   { get; set;  }
        [JsonProperty("__DataVenda")]
        public DateTime  DataVenda { get; set; }
    }
}