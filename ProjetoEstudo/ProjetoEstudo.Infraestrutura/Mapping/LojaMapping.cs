using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PorjetoEstudo.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudo.Infraestrutura.Mapping
{
    public class LojaMapping
    {
        public void Configure(EntityTypeBuilder<Loja> builder)
        {
            builder.HasKey(l => l.IdLoja);
            builder.Property(l => l.IdLoja).IsRequired();
            builder.Property(l => l.NomeLoja).IsRequired();
            builder.Property(l => l.Cnpj).IsRequired();
            builder.HasMany(l => l.Produtos).WithMany(pr => pr.Lojas);
        }
    }
}
