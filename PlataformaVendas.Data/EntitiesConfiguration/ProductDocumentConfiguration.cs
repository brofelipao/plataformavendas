using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlataformaVendas.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaVendas.Data.EntitiesConfiguration
{
    public class ProductDocumentConfiguration : IEntityTypeConfiguration<ProductDocument>
    {
        public void Configure(EntityTypeBuilder<ProductDocument> builder)
        {
            builder.HasKey(pf => new { pf.ProductId, pf.FileId });
            builder.HasOne(pf => pf.Product).WithMany(pf => pf.Documents).HasForeignKey(pf => pf.ProductId);
            builder.HasOne(pf => pf.File).WithMany(pf => pf.Products).HasForeignKey(pf => pf.FileId);
        }
    }
}
