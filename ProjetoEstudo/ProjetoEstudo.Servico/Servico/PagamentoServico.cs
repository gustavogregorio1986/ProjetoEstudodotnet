using ProjetoEstudo.Infraestrutura.DTO;
using ProjetoEstudo.Infraestrutura.repositorio.Interface;
using ProjetoEstudo.Servico.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudo.Servico.Servico
{
    public class PagamentoServico : IPagamentoServico
    {
        private readonly IPagamentoRepositorio pagamentoRepositorio;

        public PagamentoServico(IPagamentoRepositorio pagamentoRepositorio)
        {
            this.pagamentoRepositorio = pagamentoRepositorio;
        }

        public void Adiciuonar(PagamentoDTO pagamentoDTO)
        {
            pagamentoRepositorio.Adicionar(pagamentoDTO);
        }
    }
}
