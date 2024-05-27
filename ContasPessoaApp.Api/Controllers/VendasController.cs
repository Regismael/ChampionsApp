using ChampionsApp.Data.Entities;
using ChampionsApp.Data.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChampionsApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendasController : ControllerBase
    {
        private string _mensagem1 = "Há uma variação extrema de preços, com valores que vão de R$89.318,60 até R$332.424,50.\n" +
            "Preços acima de R$100.000 são observados várias vezes, por exemplo, em 03/01/2024 e 04/01/2024, onde o valor chega a R$332.424,50.\n" +
            "\tPossíveis melhorias:\n" +
            "Margem de Lucro: Definir margens de lucro consistentes que permitam variações controladas, evitando aumentos extremos de preço.\n" +
            "Observar a demanda das empresas em determinadas épocas para reduzir a produção dos produtos, se for o caso";
           
        private string _mensagem2 = "Há vários registros de preços exatos, como R$147.860,80 e R$267.955,80. Esses valores exatos e elevados repetidos podem indicar uma configuração padrão ou erro de sistema, ou algum evento específico que justifica a repetição exata desse valor.\n" +
            "\tMonitoramento Contínuo:" +
            "\t*DETALHAMENTO DE PREÇOS*\n Ferramentas de Monitoramento: Implemente ferramentas de monitoramento contínuo para detectar e corrigir imediatamente qualquer inconsistência nos preços.\n" +
            "Manter o monitoramento da necessidade corriqueira da qual as empresas necessitam\n";
        private string _mensagem3 = "Os registros de R$332.424,50 (03/01/2024 e 04/01/2024) são notavelmente altos e ocorrem mais de uma vez, sugerindo uma possível anomalia ou um evento especial que justifica esse preço.\n" +
            "Análise Detalhada de Preços:\n" +
            "\tDESAGREGAÇÃO DE CUSTOS:\n Apresente uma desagregação clara dos componentes do preço, como impostos, taxas de importação, custos de produção, margens de lucro, etc., para justificar os valores elevados.\n" +
            "Observar se alguma determinada empresa solicitadora possue alguma necessidade especial em dias específicos para que haja uma organização pré-estabelecida da produção do produto.\n";

        [HttpGet]
        public IActionResult GetAll()
        {
            var vendas = new VendaRepository();

            try
            {
                var result = vendas.GetAll();

                return StatusCode(200, new
                {
                 
                    result
                });
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet("flutuacao-preco")]
        public IActionResult GetMessage1() 
        {
            var mensagem = _mensagem1;

            return StatusCode(200,mensagem);
        }

        [HttpGet("precos-iguais")]
        public IActionResult GetMessage2()
        {
            var mensagem = _mensagem2;

            return StatusCode(200,mensagem);
        }

        [HttpGet("precos-altos")]
        public IActionResult GetMessage3()
        {
            var mensagem = _mensagem3;

            return StatusCode(200,mensagem);
        }
    }
}
