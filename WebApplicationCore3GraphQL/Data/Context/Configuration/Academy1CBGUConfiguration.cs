using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using WebApplicationCore3GraphQL.Infra.Data.Models;

namespace Data.Context.Configuration
{
    public class Academy1CBGUConfiguration : IEntityTypeConfiguration<Academy1CBGU>
    {
        public void Configure(EntityTypeBuilder<Academy1CBGU> builder)
        {
            builder.Property(a => a.Name).IsRequired();
        }
    }
}
