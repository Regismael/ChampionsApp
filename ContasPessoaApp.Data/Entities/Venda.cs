using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampionsApp.Data.Entities
{
    public class Venda
    {
        public DateTime DataHora { get; set; }
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public decimal ValorUnitario { get; set; }
        public int ClienteId { get; set; }
    }
}
