using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimpleCrud.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCrud.Persistence.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(m => m.Id).ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(m => m.Name).IsRequired().HasMaxLength(500);
            builder.Property(m => m.Barcode).IsRequired().HasMaxLength(50);
            builder.Property(m => m.Description).IsRequired().HasMaxLength(2000);
            builder.Property(m => m.BuyingPrice).IsRequired();
            builder.Property(m => m.ExpireDate).IsRequired().HasMaxLength(10); ;
            builder.ToTable("Products", "dbo");
        }
    }
}