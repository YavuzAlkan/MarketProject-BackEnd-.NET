﻿// <auto-generated />
using System;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Context.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ApplicationCore.Entities.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(750)
                        .HasColumnType("nvarchar(750)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Category", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2024, 7, 6, 16, 46, 44, 149, DateTimeKind.Local).AddTicks(8239),
                            Description = "Sebze ve meyve ürünleri bulunur.",
                            Name = "Manav",
                            Status = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2024, 7, 6, 16, 46, 44, 149, DateTimeKind.Local).AddTicks(8260),
                            Description = "Teknolojik ürünler bulunur.",
                            Name = "Teknoloji",
                            Status = 1
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2024, 7, 6, 16, 46, 44, 149, DateTimeKind.Local).AddTicks(8261),
                            Description = "Kahvaltılık ürünler bulunur",
                            Name = "Şarküteri",
                            Status = 1
                        });
                });

            modelBuilder.Entity("ApplicationCore.Entities.Concrete.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2024, 7, 6, 16, 46, 44, 149, DateTimeKind.Local).AddTicks(8416),
                            Name = "Elma",
                            Price = 23.5,
                            Quantity = 25,
                            Status = 1
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2024, 7, 6, 16, 46, 44, 149, DateTimeKind.Local).AddTicks(8420),
                            Name = "Salatalık",
                            Price = 27.899999999999999,
                            Quantity = 45,
                            Status = 1
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2024, 7, 6, 16, 46, 44, 149, DateTimeKind.Local).AddTicks(8422),
                            Name = "Telefon",
                            Price = 27.5,
                            Quantity = 3,
                            Status = 1
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 2,
                            CreatedDate = new DateTime(2024, 7, 6, 16, 46, 44, 149, DateTimeKind.Local).AddTicks(8423),
                            Name = "Tablet",
                            Price = 18.699999999999999,
                            Quantity = 6,
                            Status = 1
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2024, 7, 6, 16, 46, 44, 149, DateTimeKind.Local).AddTicks(8424),
                            Name = "Sucuk",
                            Price = 400.0,
                            Quantity = 45,
                            Status = 1
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2024, 7, 6, 16, 46, 44, 149, DateTimeKind.Local).AddTicks(8425),
                            Name = "Peynir",
                            Price = 280.0,
                            Quantity = 34,
                            Status = 1
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 5,
                            CreatedDate = new DateTime(2024, 7, 6, 16, 46, 44, 149, DateTimeKind.Local).AddTicks(8455),
                            Name = "Filtre Kahve",
                            Price = 85.0,
                            Quantity = 21,
                            Status = 1
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 5,
                            CreatedDate = new DateTime(2024, 7, 6, 16, 46, 44, 149, DateTimeKind.Local).AddTicks(8457),
                            Name = "Türk Kahvesi",
                            Price = 50.0,
                            Quantity = 15,
                            Status = 1
                        });
                });

            modelBuilder.Entity("ApplicationCore.Entities.Concrete.Product", b =>
                {
                    b.HasOne("ApplicationCore.Entities.Concrete.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
