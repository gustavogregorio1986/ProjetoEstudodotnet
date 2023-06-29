using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PorjetoEstudo.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudo.Infraestrutura.Mapping
{
    public class ProdutoMapping
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(pr => pr.IdProduto);
            builder.Property(pr => pr.IdProduto).IsRequired();
            builder.Property(pr => pr.NomeProduto).IsRequired();
            builder.Property(pr => pr.Descricao).IsRequired();
            builder.HasMany(pr => pr.Pagamentos).WithMany(pa => pa.Produtos);
        }
    }
}
