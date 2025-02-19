﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StockData.Infrastructure.DbContexts;

#nullable disable

namespace StockData.Worker.Migrations
{
    [DbContext(typeof(TrainingDbContext))]
    partial class TrainingDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("StockData.Infrastructure.Entities.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TradeCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("StockData.Infrastructure.Entities.StockPrice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Change")
                        .HasColumnType("float");

                    b.Property<double>("ClosePrice")
                        .HasColumnType("float");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("High")
                        .HasColumnType("float");

                    b.Property<double>("LastTradingPrice")
                        .HasColumnType("float");

                    b.Property<double>("Low")
                        .HasColumnType("float");

                    b.Property<DateTime>("StockDateTime")
                        .HasColumnType("datetime2");

                    b.Property<double>("Trade")
                        .HasColumnType("float");

                    b.Property<double>("Value")
                        .HasColumnType("float");

                    b.Property<double>("Volume")
                        .HasColumnType("float");

                    b.Property<double>("YesterdayClosePrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("StockPrices");
                });

            modelBuilder.Entity("StockData.Infrastructure.Entities.StockPrice", b =>
                {
                    b.HasOne("StockData.Infrastructure.Entities.Company", "Company")
                        .WithMany("StockPrices")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("StockData.Infrastructure.Entities.Company", b =>
                {
                    b.Navigation("StockPrices");
                });
#pragma warning restore 612, 618
        }
    }
}
