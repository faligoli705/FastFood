﻿// <auto-generated />
using System;
using FastFood.DataLayer.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FastFood.DataLayer.Migrations
{
    [DbContext(typeof(FastFoodContext))]
    [Migration("20201222092624_FastFood")]
    partial class FastFood
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("FastFood.DomainClass.Domain.Entities.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CategoryCreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CategoryDeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CategoryName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CategoryUpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<int?>("ProductsProductID")
                        .HasColumnType("int");

                    b.HasKey("CategoryID");

                    b.HasIndex("ProductsProductID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("FastFood.DomainClass.Domain.Entities.Customers", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<DateTime>("CustomerCreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CustomerDeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CustomerUpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FName")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("LName")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("Mobile")
                        .HasColumnType("int");

                    b.Property<int>("PasswordCustomer")
                        .HasColumnType("int");

                    b.Property<int>("StatusCustomer")
                        .HasColumnType("int");

                    b.Property<long?>("StoreInvoicingInvoicingId")
                        .HasColumnType("bigint");

                    b.HasKey("CustomerId");

                    b.HasIndex("StoreInvoicingInvoicingId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("FastFood.DomainClass.Domain.Entities.Products", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ProductCreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ProductDeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProductName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ProductPicUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ProductPreparationTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ProductUpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<long?>("StoreInvoicingDetailsInvoicingDetailId")
                        .HasColumnType("bigint");

                    b.Property<decimal>("UnitPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductID");

                    b.HasIndex("StoreInvoicingDetailsInvoicingDetailId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("FastFood.DomainClass.Domain.Entities.StoreInvoicing", b =>
                {
                    b.Property<long>("InvoicingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<DateTime>("StoreInvoicingCreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StoreInvoicingDeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("StoreInvoicingDetailsInvoicingDetailId")
                        .HasColumnType("bigint");

                    b.Property<int>("StoreInvoicingStatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("StoreInvoicingUpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("InvoicingId");

                    b.HasIndex("StoreInvoicingDetailsInvoicingDetailId");

                    b.ToTable("StoreInvoicings");
                });

            modelBuilder.Entity("FastFood.DomainClass.Domain.Entities.StoreInvoicingDetails", b =>
                {
                    b.Property<long>("InvoicingDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<int>("CurrentPrice")
                        .HasColumnType("int");

                    b.Property<decimal>("Discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("InvoicingDetailCreateDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InvoicingDetailDeleteDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("InvoicingDetailStatus")
                        .HasColumnType("int");

                    b.Property<DateTime>("InvoicingDetailUpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("InvoicingId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<int>("LaborCustomerItem")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("InvoicingDetailId");

                    b.ToTable("StoreInvoicingDetails");
                });

            modelBuilder.Entity("FastFood.DomainClass.Domain.Entities.Category", b =>
                {
                    b.HasOne("FastFood.DomainClass.Domain.Entities.Products", null)
                        .WithMany("Category")
                        .HasForeignKey("ProductsProductID");
                });

            modelBuilder.Entity("FastFood.DomainClass.Domain.Entities.Customers", b =>
                {
                    b.HasOne("FastFood.DomainClass.Domain.Entities.StoreInvoicing", null)
                        .WithMany("Customers")
                        .HasForeignKey("StoreInvoicingInvoicingId");
                });

            modelBuilder.Entity("FastFood.DomainClass.Domain.Entities.Products", b =>
                {
                    b.HasOne("FastFood.DomainClass.Domain.Entities.StoreInvoicingDetails", null)
                        .WithMany("Products")
                        .HasForeignKey("StoreInvoicingDetailsInvoicingDetailId");
                });

            modelBuilder.Entity("FastFood.DomainClass.Domain.Entities.StoreInvoicing", b =>
                {
                    b.HasOne("FastFood.DomainClass.Domain.Entities.StoreInvoicingDetails", null)
                        .WithMany("StoreInvoicings")
                        .HasForeignKey("StoreInvoicingDetailsInvoicingDetailId");
                });

            modelBuilder.Entity("FastFood.DomainClass.Domain.Entities.Products", b =>
                {
                    b.Navigation("Category");
                });

            modelBuilder.Entity("FastFood.DomainClass.Domain.Entities.StoreInvoicing", b =>
                {
                    b.Navigation("Customers");
                });

            modelBuilder.Entity("FastFood.DomainClass.Domain.Entities.StoreInvoicingDetails", b =>
                {
                    b.Navigation("Products");

                    b.Navigation("StoreInvoicings");
                });
#pragma warning restore 612, 618
        }
    }
}
