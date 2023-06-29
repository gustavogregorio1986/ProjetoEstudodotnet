using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PorjetoEstudo.Dominio.Dominio
{
    public class Pessoa
    {
        [Key]
        public int IdPessoa { get; set; }

        public string NomePessoa { get; set; }

        public string EmailPessoa { get; set; }

        public string Cpf { get; set; }

        public string Telefone { get; set; }

        
        public virtual Endereco Endereco { get; set; }

        
        public virtual Loja Loja { get; set; }
    }
}
