﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PorjetoEstudo.Dominio.Dominio;
using ProjetoEstudo.Infraestrutura.DTO;
using ProjetoEstudo.Servico.Servico.Interface;

namespace ProjetoEstudo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PagamentoController : ControllerBase
    {
        private IPagamentoServico pagamentoServico;

        public PagamentoController(IPagamentoServico pagamentoServico)
        {
            this.pagamentoServico = pagamentoServico;
        }

        public JsonResult CadastrarPagamento([FromBody] PagamentoDTO pagamentoDTO)
        {
            var pagamento = new Pagamento()
            { 
                 Preco = pagamentoDTO.Preco,
                 Qtde = pagamentoDTO.Qtde
            };

            return new JsonResult(pagamentoDTO);
        }
    }
}
