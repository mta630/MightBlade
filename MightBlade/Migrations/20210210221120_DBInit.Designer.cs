﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MightBlade.DBContexts;

namespace MightBlade.Migrations
{
    [DbContext(typeof(MyDBContext))]
    [Migration("20210210221120_DBInit")]
    partial class DBInit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("MightBlade.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BuyValue")
                        .HasColumnType("int");

                    b.Property<int>("DamageMod")
                        .HasColumnType("int");

                    b.Property<int>("HealthMod")
                        .HasColumnType("int");

                    b.Property<int>("ManaMod")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("SellValue")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id")
                        .HasName("PK_Items");

                    b.HasIndex("Name")
                        .HasDatabaseName("Idx_Name");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("MightBlade.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Gold")
                        .HasColumnType("int");

                    b.Property<string>("Inventory")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Stats")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserClass")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id")
                        .HasName("PK_Users");

                    b.HasIndex("UserName")
                        .HasDatabaseName("Idx_UserName");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
