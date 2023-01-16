﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sistema_lojaKX.Data;

#nullable disable

namespace Sistema_lojaKX.Migrations
{
    [DbContext(typeof(PurchaseSystemDBcontext))]
    [Migration("20230116171444_ModifyingTablePurchases")]
    partial class ModifyingTablePurchases
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Sistema_lojaKX.Models.ClientModel", b =>
                {
                    b.Property<int>("Id_Client")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Client"), 1L, 1);

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Name_Client")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id_Client");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Sistema_lojaKX.Models.ProductModel", b =>
                {
                    b.Property<int>("Id_Product")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Product"), 1L, 1);

                    b.Property<string>("Name_Product")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Value_Product")
                        .HasColumnType("float");

                    b.HasKey("Id_Product");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Sistema_lojaKX.Models.PurchaseModel", b =>
                {
                    b.Property<int>("Id_Purchase")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id_Purchase"), 1L, 1);

                    b.Property<string>("Cpf_Client")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id_Client")
                        .HasColumnType("int");

                    b.Property<int>("Id_Product")
                        .HasColumnType("int");

                    b.HasKey("Id_Purchase");

                    b.ToTable("Purchases");
                });
#pragma warning restore 612, 618
        }
    }
}