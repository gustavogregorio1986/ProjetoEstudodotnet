using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PorjetoEstudo.Dominio.Dominio
{
    public class Loja
    {
        [Key]
        public int IdLoja { get; set; }

        public string NomeLoja { get; set; }

        public string Cnpj { get; set; }

        public virtual Pessoa Pessoa { get; set; }

        [ForeignKey("Pessoa")]
        public int Id_Pessoa { get; set; }

        public virtual List<Produto> Produtos { get; set; }


    }
}
