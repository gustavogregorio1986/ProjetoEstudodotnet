using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PorjetoEstudo.Dominio.Dominio
{
    public class Produto
    {
        [Key]
        public int IdProduto { get; set; }

        public string NomeProduto { get; set; }

        public string Descricao { get; set; }

        public List<Loja> Lojas { get; set; }

        public List<Pagamento> Pagamentos { get; set; }
    }
}
