﻿// <auto-generated />
using System;
using Api_Laptop_Task.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Api_Laptop_Task.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240415212236_newlaptopapi")]
    partial class newlaptopapi
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Api_Laptop_Task.Model.Brand", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("brands");
                });

            modelBuilder.Entity("Api_Laptop_Task.Model.Laptop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<int?>("BrandId1")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Oldprice")
                        .HasColumnType("float");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int?>("RatingId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("price")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.HasIndex("BrandId1");

                    b.HasIndex("RatingId");

                    b.ToTable("laptops");
                });

            modelBuilder.Entity("Api_Laptop_Task.Model.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("no_of_stars")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ratings");
                });

            modelBuilder.Entity("Api_Laptop_Task.Model.Laptop", b =>
                {
                    b.HasOne("Api_Laptop_Task.Model.Brand", "brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api_Laptop_Task.Model.Brand", null)
                        .WithMany("laptops")
                        .HasForeignKey("BrandId1");

                    b.HasOne("Api_Laptop_Task.Model.Rating", null)
                        .WithMany("laptops")
                        .HasForeignKey("RatingId");

                    b.Navigation("brand");
                });

            modelBuilder.Entity("Api_Laptop_Task.Model.Brand", b =>
                {
                    b.Navigation("laptops");
                });

            modelBuilder.Entity("Api_Laptop_Task.Model.Rating", b =>
                {
                    b.Navigation("laptops");
                });
#pragma warning restore 612, 618
        }
    }
}
