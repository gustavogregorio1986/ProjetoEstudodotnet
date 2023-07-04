using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PorjetoEstudo.Dominio.Dominio;
using ProjetoEstudo.Infraestrutura.DTO;
using ProjetoEstudo.Servico.Servico.Interface;

namespace ProjetoEstudo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LojaController : ControllerBase
    {
        private ILojaServico lojaServico;


        public LojaController(ILojaServico lojaServico)
        {
            this.lojaServico = lojaServico;
        }

        [HttpPost]
        public JsonResult CadastrarLoja([FromBody] LojaDTO lojaDTO)
        {
            var loja = new Loja()
            { 
                NomeLoja = lojaDTO.NomeLoja,
                Cnpj = lojaDTO.Cnpj
            };

            lojaServico.Adicionar(lojaDTO);

            return new JsonResult(lojaDTO);
        }
    }
}
