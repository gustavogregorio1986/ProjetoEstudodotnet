using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudo.Infraestrutura.DTO
{
    public class PagamentoDTO
    {
        public int IdPagamento { get; set; }

        public decimal Preco { get; set; }

        public int Qtde { get; set; }
    }
}
