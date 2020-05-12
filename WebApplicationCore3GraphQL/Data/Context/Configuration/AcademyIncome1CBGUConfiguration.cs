using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Models;

namespace Data.Context.Configuration
{
    public class AcademyIncome1CBGUConfiguration : IEntityTypeConfiguration<AcademyIncome1CBGU>
    {
        public void Configure(EntityTypeBuilder<AcademyIncome1CBGU> builder)
        {
            builder.Property(a => a.AcademyСategory).IsRequired();
            builder.Property(a => a.KindOfActivityСategory).IsRequired();
            builder.Property(a => a.BudgetSPСategory).IsRequired();
            builder.Property(a => a.BudgetIndicator).IsRequired();
            builder.Property(a => a.EstimateIndicator).IsRequired();
            builder.Property(a => a.CashIncomeIndicator).IsRequired();
            builder.Property(a => a.DifferenceFromEstimateIndicator).IsRequired();
            builder.Property(a => a.FormationDateReport).IsRequired();
            builder.Property(a => a.ReportDate).IsRequired();


        }
    }
}
