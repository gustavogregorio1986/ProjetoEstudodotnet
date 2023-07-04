using ProjetoEstudo.Infraestrutura.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudo.Servico.Servico.Interface
{
    public interface IPagamentoServico
    {
        void Adicionar(PagamentoDTO pagamentoDTO);
    }
}
