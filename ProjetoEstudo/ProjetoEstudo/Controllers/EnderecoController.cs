using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PorjetoEstudo.Dominio.Dominio;
using ProjetoEstudo.Infraestrutura.DTO;
using ProjetoEstudo.Servico.Servico.Interface;

namespace ProjetoEstudo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnderecoController : ControllerBase
    {
        private IEnderecoServico _enderecoServico;

        public EnderecoController(IEnderecoServico enderecoServico)
        {
            this._enderecoServico = enderecoServico;
        }

        [HttpPost]
        public JsonResult CadastrarEndereco([FromBody] EnderecoDTO enderecoDTO)
        {
            var endereco = new Endereco()
            {
                Logradouro = enderecoDTO.Logradouro,
                Complemento = enderecoDTO.Complemento,
                Bairro = enderecoDTO.Bairro,
                Cidade = enderecoDTO.Cidade,
                Estado = enderecoDTO.Estado,
                Cep = enderecoDTO.Cep
            };

            _enderecoServico.Adicionar(enderecoDTO);

            return new JsonResult(enderecoDTO);
        }
    }
}
