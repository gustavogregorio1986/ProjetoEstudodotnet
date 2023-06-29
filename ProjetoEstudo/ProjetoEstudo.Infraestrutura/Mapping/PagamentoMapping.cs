using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PorjetoEstudo.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEstudo.Infraestrutura.Mapping
{
    public class PagamentoMapping
    {
        public void Configure(EntityTypeBuilder<Pagamento> builder)
        {
            builder.HasKey(pa => pa.IdPagamento);
            builder.Property(p => p.IdPagamento).IsRequired();
            builder.Property(p => p.Preco).IsRequired();
            builder.Property(p => p.Qtde).IsRequired();
        }
    }
}
