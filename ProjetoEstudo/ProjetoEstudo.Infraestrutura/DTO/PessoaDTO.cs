using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudo.Infraestrutura.DTO
{
    public class PessoaDTO
    {
        public int IdPessoa { get; set; }

        public string NomePessoa { get; set; }

        public string EmailPessoa { get; set; }

        public string Cpf { get; set; }

        public string Telefone { get; set; }
    }
}
