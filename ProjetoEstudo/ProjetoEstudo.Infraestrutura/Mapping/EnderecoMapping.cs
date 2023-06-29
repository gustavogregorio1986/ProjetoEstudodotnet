using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PorjetoEstudo.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudo.Infraestrutura.Mapping
{
    public class EnderecoMapping
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(e => e.IdEndereco).IsClustered();
            builder.Property(e => e.IdEndereco).IsRequired();
            builder.Property(e => e.Logradouro).IsRequired();
            builder.Property(e => e.Complemento).IsRequired();
            builder.Property(e => e.Bairro).IsRequired();
            builder.Property(e => e.Cidade).IsRequired();
            builder.Property(e => e.Estado).IsRequired();
            builder.Property(e => e.Cep).IsRequired();
        }
    }
}
