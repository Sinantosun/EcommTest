﻿// <auto-generated />
using EcommTest.DAL.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EcommTest.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.29")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EcommTest.DAL.Entites.ProductAttrubute", b =>
                {
                    b.Property<int>("ProductAttrubuteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductAttrubuteID"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductAttrubuteID");

                    b.ToTable("ProductAttrubutes");
                });

            modelBuilder.Entity("EcommTest.DAL.Entites.ProductDetail", b =>
                {
                    b.Property<int>("ProductDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductDetailID"), 1L, 1);

                    b.Property<int>("ProductAttrubuteID")
                        .HasColumnType("int");

                    b.Property<int>("ProductsID")
                        .HasColumnType("int");

                    b.Property<string>("TypeValue")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductDetailID");

                    b.HasIndex("ProductAttrubuteID");

                    b.HasIndex("ProductsID");

                    b.ToTable("productDetails");
                });

            modelBuilder.Entity("EcommTest.DAL.Entites.Products", b =>
                {
                    b.Property<int>("ProductsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductsID"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Stok")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductsID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("EcommTest.DAL.Entites.ProductDetail", b =>
                {
                    b.HasOne("EcommTest.DAL.Entites.ProductAttrubute", "productAttrubute")
                        .WithMany("productDetails")
                        .HasForeignKey("ProductAttrubuteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EcommTest.DAL.Entites.Products", "Products")
                        .WithMany("productDetails")
                        .HasForeignKey("ProductsID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Products");

                    b.Navigation("productAttrubute");
                });

            modelBuilder.Entity("EcommTest.DAL.Entites.ProductAttrubute", b =>
                {
                    b.Navigation("productDetails");
                });

            modelBuilder.Entity("EcommTest.DAL.Entites.Products", b =>
                {
                    b.Navigation("productDetails");
                });
#pragma warning restore 612, 618
        }
    }
}