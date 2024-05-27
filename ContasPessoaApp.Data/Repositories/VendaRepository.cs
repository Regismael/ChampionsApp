using ChampionsApp.Data.Entities;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampionsApp.Data.Repositories
{
    public class VendaRepository
    {
        private string _connectionString = "";

        public List<Venda> GetAll()
        {
            using(var connection = new SqlConnection(_connectionString))
            {
                return connection.Query<Venda>(@"
               SELECT 
               ve.Id, 
               ve.DataHora,
               ve.ClienteId,
               vi.ProdutoId, 
               vi.ValorUnitario
               FROM Vendas.Venda ve
               JOIN Vendas.VendaItem vi ON ve.Id = vi.VendaId
               WHERE vi.ProdutoId = 4 
               AND ve.DataHora >= '2024-01-01'
               ").ToList();
                

            }
        }

    }
}
