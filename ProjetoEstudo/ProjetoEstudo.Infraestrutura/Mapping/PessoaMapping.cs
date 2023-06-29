using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PorjetoEstudo.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudo.Infraestrutura.Mapping
{
    public class PessoaMapping
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.HasKey(p => p.IdPessoa);
            builder.Property(p => p.IdPessoa).IsRequired();
            builder.Property(p => p.NomePessoa).IsRequired();
            builder.Property(p => p.EmailPessoa).IsRequired();
            builder.Property(p => p.Cpf).IsRequired();
            builder.Property(p => p.Telefone).IsRequired();
            builder.HasOne(p => p.Loja).WithOne(l => l.Pessoa);
        }
    }
}
