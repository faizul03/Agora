﻿// <auto-generated />
using EShop.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EShop.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EShop.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("Quntity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 10,
                            Name = "Test Test",
                            Price = 5.99f,
                            Quntity = 1
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "Test One",
                            Price = 7.99f,
                            Quntity = 10
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "Test Two",
                            Price = 9.99f,
                            Quntity = 3
                        },
                        new
                        {
                            Id = 4,
                            DisplayOrder = 4,
                            Name = "Test Three",
                            Price = 4.99f,
                            Quntity = 21
                        },
                        new
                        {
                            Id = 5,
                            DisplayOrder = 5,
                            Name = "Test Four",
                            Price = 5.99f,
                            Quntity = 12
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
