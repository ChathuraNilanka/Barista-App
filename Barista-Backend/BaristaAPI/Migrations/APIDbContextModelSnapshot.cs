﻿// <auto-generated />
using System;
using BaristaAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BaristaAPI.Migrations
{
    [DbContext(typeof(APIDbContext))]
    partial class APIDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("BaristaAPI.Models.Domain.Cafe", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Logo")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Cafes");
                });

            modelBuilder.Entity("BaristaAPI.Models.Domain.Employee", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<Guid?>("CafeId")
                        .HasColumnType("char(36)");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.HasIndex("CafeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("BaristaAPI.Models.Domain.Image", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CafeId")
                        .HasColumnType("char(36)");

                    b.Property<string>("FileDescription")
                        .HasColumnType("longtext");

                    b.Property<string>("FileExtension")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("FileSizeInBytes")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("BaristaAPI.Models.Domain.Employee", b =>
                {
                    b.HasOne("BaristaAPI.Models.Domain.Cafe", "Cafe")
                        .WithMany("Employees")
                        .HasForeignKey("CafeId");

                    b.Navigation("Cafe");
                });

            modelBuilder.Entity("BaristaAPI.Models.Domain.Cafe", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
