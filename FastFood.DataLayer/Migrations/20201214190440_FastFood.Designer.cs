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
    [Migration("20201214190440_FastFood")]
    partial class FastFood
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("FastFood.DomainClass.Domain.Entities.FactorsEnt", b =>
                {
                    b.Property<long>("IdFactor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .UseIdentityColumn();

                    b.Property<string>("AddressUser")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<DateTime>("DateSave")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdProdut")
                        .HasColumnType("int");

                    b.Property<int>("IdUser")
                        .HasColumnType("int");

                    b.Property<int?>("ProductsIdProducts")
                        .HasColumnType("int");

                    b.Property<int>("QtyFood")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<DateTime>("TimeSave")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UserIdUser")
                        .HasColumnType("int");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdFactor");

                    b.HasIndex("ProductsIdProducts");

                    b.HasIndex("UserIdUser");

                    b.ToTable("Factors");
                });

            modelBuilder.Entity("FastFood.DomainClass.Domain.Entities.ProductsEnt", b =>
                {
                    b.Property<int>("IdProducts")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("DateSave")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdType")
                        .HasColumnType("int");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("NameFood")
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("PicUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("TimeAmadehSazi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeSave")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TypesIdType")
                        .HasColumnType("int");

                    b.HasKey("IdProducts");

                    b.HasIndex("TypesIdType");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("FastFood.DomainClass.Domain.Entities.TypesEnt", b =>
                {
                    b.Property<int>("IdType")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("IdType");

                    b.ToTable("Types");
                });

            modelBuilder.Entity("FastFood.DomainClass.Domain.Entities.UsersEnt", b =>
                {
                    b.Property<int>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("AddressUser")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("FName")
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<bool>("IsDelete")
                        .HasColumnType("bit");

                    b.Property<string>("LName")
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<int>("Mobile")
                        .HasColumnType("int");

                    b.Property<int>("NationalCode")
                        .HasColumnType("int");

                    b.Property<int>("Pass")
                        .HasColumnType("int");

                    b.Property<string>("PicUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StatusAdmin")
                        .HasColumnType("int");

                    b.HasKey("IdUser");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FastFood.DomainClass.Domain.Entities.FactorsEnt", b =>
                {
                    b.HasOne("FastFood.DomainClass.Domain.Entities.ProductsEnt", "Products")
                        .WithMany()
                        .HasForeignKey("ProductsIdProducts");

                    b.HasOne("FastFood.DomainClass.Domain.Entities.UsersEnt", "User")
                        .WithMany()
                        .HasForeignKey("UserIdUser");

                    b.Navigation("Products");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FastFood.DomainClass.Domain.Entities.ProductsEnt", b =>
                {
                    b.HasOne("FastFood.DomainClass.Domain.Entities.TypesEnt", "Types")
                        .WithMany()
                        .HasForeignKey("TypesIdType");

                    b.Navigation("Types");
                });
#pragma warning restore 612, 618
        }
    }
}
