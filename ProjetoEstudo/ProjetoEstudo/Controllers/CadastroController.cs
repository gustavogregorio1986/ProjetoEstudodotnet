using Microsoft.AspNetCore.Mvc;
using ProjetoEstudo.Servico.Servico.Interface;

namespace ProjetoEstudo.Controllers
{
    public class CadastroController : Controller
    {
        private IPessoaServico pessoaServico;
        private IEnderecoServico enderecoServico;
        private ILojaServico lojaServico;
        private IProdutoServico produtoServico;
        private IPagamentoServico pagamentoServico;



        [HttpPost]
        public IActionResult Cadastrar()
        {

            return View();
        }
    }
}
