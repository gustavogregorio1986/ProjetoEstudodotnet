using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PorjetoEstudo.Dominio.Dominio;
using ProjetoEstudo.Infraestrutura.DTO;

namespace ProjetoEstudo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        public JsonResult CadastraProduto([FromBody] ProdutoDTO produtoDTO)
        {
            var produto = new Produto()
            { 
                NomeProduto = produtoDTO.NomeProduto,
                Descricao = produtoDTO.Descricao
            };

            return new JsonResult(produtoDTO);
        }
    }
}
