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
        private ILojaServico _lojaServico;


        public LojaController(ILojaServico lojaServico)
        {
            this._lojaServico = lojaServico;
        }

        [HttpPost]
        public JsonResult CadastrarLoja([FromBody] LojaDTO lojaDTO)
        {
            lojaDTO = new LojaDTO();
            var loja = new Loja()
            { 
                NomeLoja = lojaDTO.NomeLoja,
                Cnpj = lojaDTO.Cnpj
            };

            _lojaServico.Adicionar(lojaDTO);

            return new JsonResult(lojaDTO);
        }
    }
}
