using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PorjetoEstudo.Dominio.Dominio;
using ProjetoEstudo.Infraestrutura.DTO;
using ProjetoEstudo.Servico.Servico.Interface;

namespace ProjetoEstudo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        private IPessoaServico _pessoaServico;

        public PessoaController(IPessoaServico pessoaServico)
        {
            this._pessoaServico = pessoaServico;
        }

        [HttpPost]
        public JsonResult CadastrarPessoa([FromBody] PessoaDTO pessoaDTO)
        {
            var pessoa = new Pessoa()
            { 
                 NomePessoa = pessoaDTO.NomePessoa,
                 EmailPessoa = pessoaDTO.EmailPessoa,
                 Cpf = pessoaDTO.Cpf,
                 Telefone = pessoaDTO.Telefone
            };

            _pessoaServico.Adicionar(pessoaDTO);

            return new JsonResult(pessoaDTO);
        }
    }
}
