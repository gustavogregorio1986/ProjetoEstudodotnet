using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorjetoEstudo.Dominio.Dominio
{
    public class Pagamento
    {
        public int IdPagamento { get; set; }

        public decimal Preco { get; set; }

        public int Qtde { get; set; }

        public List<Produto> Produtos { get; set; }
    }
}
