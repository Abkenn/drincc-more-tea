﻿// <auto-generated />
using System;
using Drincc.DAL.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Drincc.DAL.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220710224042_UpdateTeaFKInSessionNotes")]
    partial class UpdateTeaFKInSessionNotes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Drincc.DAL.Models.SessionNote", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Quantity")
                        .HasColumnType("real");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<long>("TeaId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("TeaId");

                    b.ToTable("SessionNotes", (string)null);
                });

            modelBuilder.Entity("Drincc.DAL.Models.Tea", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"), 1L, 1);

                    b.Property<string>("BrandName")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Cultivar")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("DateBought")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int>("MyRating")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<int?>("NumberOfReviews")
                        .HasColumnType("int");

                    b.Property<string>("Oxidation")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PlaceOfOrigin")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<float>("QuantityInGrams")
                        .HasColumnType("real");

                    b.Property<string>("Rating")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Roast")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nvarchar(6)");

                    b.Property<string>("VendorName")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("YearOfProduction")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Teas", (string)null);
                });

            modelBuilder.Entity("Drincc.DAL.Models.SessionNote", b =>
                {
                    b.HasOne("Drincc.DAL.Models.Tea", "Tea")
                        .WithMany("SessionNotes")
                        .HasForeignKey("TeaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tea");
                });

            modelBuilder.Entity("Drincc.DAL.Models.Tea", b =>
                {
                    b.OwnsOne("Drincc.DAL.Models.PriceDetails", "PriceDetails", b1 =>
                        {
                            b1.Property<long>("TeaId")
                                .HasColumnType("bigint");

                            b1.Property<decimal>("AddedTaxesPerUSD")
                                .HasColumnType("decimal(18,2)")
                                .HasColumnName("AddedTaxesPerUSD");

                            b1.Property<decimal>("CnyТоBgn")
                                .HasColumnType("decimal(18,2)")
                                .HasColumnName("CnyТоBgn");

                            b1.Property<string>("CurrencyBought")
                                .IsRequired()
                                .HasMaxLength(3)
                                .HasColumnType("nvarchar(3)")
                                .HasColumnName("CurrencyBought");

                            b1.Property<decimal>("EurТоBgn")
                                .HasColumnType("decimal(18,2)")
                                .HasColumnName("EurТоBgn");

                            b1.Property<decimal>("EurТоCny")
                                .HasColumnType("decimal(18,2)")
                                .HasColumnName("EurТоCny");

                            b1.Property<decimal>("GbpТоBgn")
                                .HasColumnType("decimal(18,2)")
                                .HasColumnName("GbpТоBgn");

                            b1.Property<decimal>("GbpТоCny")
                                .HasColumnType("decimal(18,2)")
                                .HasColumnName("GbpТоCny");

                            b1.Property<decimal>("GbpТоEur")
                                .HasColumnType("decimal(18,2)")
                                .HasColumnName("GbpТоEur");

                            b1.Property<decimal>("JpyТоBgn")
                                .HasColumnType("decimal(18,2)")
                                .HasColumnName("JpyТоBgn");

                            b1.Property<decimal>("JpyТоCny")
                                .HasColumnType("decimal(18,2)")
                                .HasColumnName("JpyТоCny");

                            b1.Property<decimal>("JpyТоEur")
                                .HasColumnType("decimal(18,2)")
                                .HasColumnName("JpyТоEur");

                            b1.Property<decimal>("JpyТоGbp")
                                .HasColumnType("decimal(18,2)")
                                .HasColumnName("JpyТоGbp");

                            b1.Property<decimal>("PricePerGramInUSD")
                                .HasColumnType("decimal(18,2)")
                                .HasColumnName("PricePerGramInUSD");

                            b1.Property<decimal>("ShippingPricePerGramInUSD")
                                .HasColumnType("decimal(18,2)")
                                .HasColumnName("ShippingPricePerGramInUSD");

                            b1.Property<decimal>("TwdТоBgn")
                                .HasColumnType("decimal(18,2)")
                                .HasColumnName("TwdТоBgn");

                            b1.Property<decimal>("TwdТоCny")
                                .HasColumnType("decimal(18,2)")
                                .HasColumnName("TwdТоCny");

                            b1.Property<decimal>("TwdТоEur")
                                .HasColumnType("decimal(18,2)")
                                .HasColumnName("TwdТоEur");

                            b1.Property<decimal>("TwdТоGbp")
                                .HasColumnType("decimal(18,2)")
                                .HasColumnName("TwdТоGbp");

                            b1.Property<decimal>("TwdТоJpy")
                                .HasColumnType("decimal(18,2)")
                                .HasColumnName("TwdТоJpy");

                            b1.Property<decimal>("UsdТоBgn")
                                .HasColumnType("decimal(18,2)")
                                .HasColumnName("UsdТоBgn");

                            b1.Property<decimal>("UsdТоCny")
                                .HasColumnType("decimal(18,2)")
                                .HasColumnName("UsdТоCny");

                            b1.Property<decimal>("UsdТоEur")
                                .HasColumnType("decimal(18,2)")
                                .HasColumnName("UsdТоEur");

                            b1.Property<decimal>("UsdТоGbp")
                                .HasColumnType("decimal(18,2)")
                                .HasColumnName("UsdТоGbp");

                            b1.Property<decimal>("UsdТоJpy")
                                .HasColumnType("decimal(18,2)")
                                .HasColumnName("UsdТоJpy");

                            b1.Property<decimal>("UsdТоTwd")
                                .HasColumnType("decimal(18,2)")
                                .HasColumnName("UsdТоTwd");

                            b1.HasKey("TeaId");

                            b1.ToTable("PriceDetails");

                            b1.WithOwner()
                                .HasForeignKey("TeaId");
                        });

                    b.Navigation("PriceDetails");
                });

            modelBuilder.Entity("Drincc.DAL.Models.Tea", b =>
                {
                    b.Navigation("SessionNotes");
                });
#pragma warning restore 612, 618
        }
    }
}
