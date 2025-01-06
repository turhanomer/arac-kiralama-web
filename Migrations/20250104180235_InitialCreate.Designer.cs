﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RentalCar.Data;

#nullable disable

namespace RentalCar.Migrations
{
    [DbContext(typeof(VeriTabaniContext))]
    [Migration("20250104180235_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RentalCar.Models.Arac", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("GunlukFiyat")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Marka")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Model")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Musait")
                        .HasColumnType("bit");

                    b.Property<string>("ResimUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Yil")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Araclar");
                });

            modelBuilder.Entity("RentalCar.Models.KiralamaTalebi", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AracId")
                        .HasColumnType("int");

                    b.Property<DateTime>("BaslangicTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("BitisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Durum")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("MusteriAdi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("MusteriEmail")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("MusteriTelefon")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("TalepTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AracId");

                    b.ToTable("KiralamaTalepleri");
                });

            modelBuilder.Entity("RentalCar.Models.Yonetici", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AdSoyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Yoneticiler");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AdSoyad = "Sistem Yöneticisi",
                            Email = "admin@example.com",
                            KullaniciAdi = "admin",
                            Sifre = "admin123"
                        });
                });

            modelBuilder.Entity("RentalCar.Models.KiralamaTalebi", b =>
                {
                    b.HasOne("RentalCar.Models.Arac", "Arac")
                        .WithMany()
                        .HasForeignKey("AracId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Arac");
                });
#pragma warning restore 612, 618
        }
    }
}