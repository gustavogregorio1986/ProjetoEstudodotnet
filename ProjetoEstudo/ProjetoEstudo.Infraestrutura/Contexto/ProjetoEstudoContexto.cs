using Microsoft.EntityFrameworkCore;
using PorjetoEstudo.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudo.Infraestrutura.Contexto
{
    public class ProjetoEstudoContexto : DbContext
    {
        public ProjetoEstudoContexto(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Pessoa> Pessoas { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Loja> Lojas { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Pagamento> Pagamentos { get; set; }
    }
}
