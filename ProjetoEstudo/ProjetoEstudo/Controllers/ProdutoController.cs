using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PorjetoEstudo.Dominio.Dominio;
using ProjetoEstudo.Infraestrutura.DTO;
using ProjetoEstudo.Servico.Servico.Interface;

namespace ProjetoEstudo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private IProdutoServico produtoServico;

        public ProdutoController(IProdutoServico produtoServico)
        {
            this.produtoServico = produtoServico;
        }

        [HttpPost]
        public JsonResult CadastraProduto([FromBody] ProdutoDTO produtoDTO)
        {
            var produto = new Produto()
            { 
                NomeProduto = produtoDTO.NomeProduto,
                Descricao = produtoDTO.Descricao
            };

            produtoServico.Adicionar(produtoDTO);

            return new JsonResult(produtoDTO);
        }
    }
}
