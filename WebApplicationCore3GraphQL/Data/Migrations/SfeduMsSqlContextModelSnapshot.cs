﻿// <auto-generated />
using System;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(SfeduMsSqlContext))]
    partial class SfeduMsSqlContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Models.Academy1CBGU", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Academy1CBGUs");
                });

            modelBuilder.Entity("Domain.Models.AcademyIncome1CBGU", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AcademyСategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("BudgetIndicator")
                        .HasColumnType("float");

                    b.Property<string>("BudgetSPСategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("CashIncomeIndicator")
                        .HasColumnType("float");

                    b.Property<double>("DifferenceFromEstimateIndicator")
                        .HasColumnType("float");

                    b.Property<double>("EstimateIndicator")
                        .HasColumnType("float");

                    b.Property<DateTime>("FormationDateReport")
                        .HasColumnType("datetime2");

                    b.Property<string>("KindOfActivityСategory")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReportDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ReportPeriodEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ReportPeriodStartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("AcademyIncome1CBGUs");
                });
#pragma warning restore 612, 618
        }
    }
}