using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PorjetoEstudo.Dominio.Dominio
{
    public class Pagamento
    {
        [Key]
        public int IdPagamento { get; set; }

        public decimal Preco { get; set; }

        public int Qtde { get; set; }

        public List<Produto> Produtos { get; set; }
    }
}
