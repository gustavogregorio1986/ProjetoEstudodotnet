using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PorjetoEstudo.Dominio.Dominio
{
    public class Loja
    {
        public int IdLoja { get; set; }

        public string NomeLoja { get; set; }

        public string Cnpj { get; set; }

        public Pessoa Pessoa { get; set; }

        public virtual List<Produto> Produtos { get; set; }
    }
}
