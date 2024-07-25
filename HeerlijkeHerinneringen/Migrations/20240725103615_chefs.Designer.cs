﻿// <auto-generated />
using System;
using HeerlijkeHerinneringen.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HeerlijkeHerinneringen.Migrations
{
    [DbContext(typeof(HeerlijkeHerinneringenContext))]
    [Migration("20240725103615_chefs")]
    partial class chefs
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HeerlijkeHerinneringen.Data.Models.Afbeelding", b =>
                {
                    b.Property<int>("AfbeeldingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AfbeeldingId"));

                    b.Property<string>("AfbeeldingNaam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReceptId")
                        .HasColumnType("int");

                    b.HasKey("AfbeeldingId");

                    b.HasIndex("ReceptId");

                    b.ToTable("Afbeeldings");
                });

            modelBuilder.Entity("HeerlijkeHerinneringen.Data.Models.Chef", b =>
                {
                    b.Property<int>("ChefId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChefId"));

                    b.Property<string>("ChefNaam")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReceptId")
                        .HasColumnType("int");

                    b.HasKey("ChefId");

                    b.HasIndex("ReceptId");

                    b.ToTable("Chefs");
                });

            modelBuilder.Entity("HeerlijkeHerinneringen.Data.Models.Ingredient", b =>
                {
                    b.Property<int>("IngredientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IngredientId"));

                    b.Property<string>("Eenheid")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hoeveelheid")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IngredientName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReceptId")
                        .HasColumnType("int");

                    b.HasKey("IngredientId");

                    b.HasIndex("ReceptId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("HeerlijkeHerinneringen.Data.Models.MenuGang", b =>
                {
                    b.Property<int>("MenuGangId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MenuGangId"));

                    b.Property<string>("MenuGangName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MenuGangId");

                    b.ToTable("MenuGangs");
                });

            modelBuilder.Entity("HeerlijkeHerinneringen.Data.Models.Recept", b =>
                {
                    b.Property<int>("ReceptId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReceptId"));

                    b.Property<DateTime>("AanmaakDatum")
                        .HasColumnType("datetime2");

                    b.Property<byte>("Afbeelding")
                        .HasColumnType("tinyint");

                    b.Property<string>("Beschrijving")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("MenuGangId")
                        .HasColumnType("int");

                    b.Property<int>("TemperatuurId")
                        .HasColumnType("int");

                    b.Property<string>("Titel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TypeGerechtId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdateDatum")
                        .HasColumnType("datetime2");

                    b.HasKey("ReceptId");

                    b.HasIndex("MenuGangId");

                    b.HasIndex("TemperatuurId");

                    b.HasIndex("TypeGerechtId");

                    b.ToTable("Recepts");
                });

            modelBuilder.Entity("HeerlijkeHerinneringen.Data.Models.Temperatuur", b =>
                {
                    b.Property<int>("TemperatuurId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TemperatuurId"));

                    b.Property<string>("ITemperatuurName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TemperatuurId");

                    b.ToTable("Temperatuurs");
                });

            modelBuilder.Entity("HeerlijkeHerinneringen.Data.Models.TypeGerecht", b =>
                {
                    b.Property<int>("TypeGerechtId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TypeGerechtId"));

                    b.Property<string>("TypeGerechtName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TypeGerechtId");

                    b.ToTable("TypeGerechts");
                });

            modelBuilder.Entity("HeerlijkeHerinneringen.Data.Models.Afbeelding", b =>
                {
                    b.HasOne("HeerlijkeHerinneringen.Data.Models.Recept", "Recept")
                        .WithMany()
                        .HasForeignKey("ReceptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recept");
                });

            modelBuilder.Entity("HeerlijkeHerinneringen.Data.Models.Chef", b =>
                {
                    b.HasOne("HeerlijkeHerinneringen.Data.Models.Recept", "Recept")
                        .WithMany("Chefs")
                        .HasForeignKey("ReceptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recept");
                });

            modelBuilder.Entity("HeerlijkeHerinneringen.Data.Models.Ingredient", b =>
                {
                    b.HasOne("HeerlijkeHerinneringen.Data.Models.Recept", "Recept")
                        .WithMany("Ingredients")
                        .HasForeignKey("ReceptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Recept");
                });

            modelBuilder.Entity("HeerlijkeHerinneringen.Data.Models.Recept", b =>
                {
                    b.HasOne("HeerlijkeHerinneringen.Data.Models.MenuGang", "MenuGang")
                        .WithMany("Recepts")
                        .HasForeignKey("MenuGangId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HeerlijkeHerinneringen.Data.Models.Temperatuur", "Temperatuur")
                        .WithMany("Recepts")
                        .HasForeignKey("TemperatuurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HeerlijkeHerinneringen.Data.Models.TypeGerecht", "TypeGerecht")
                        .WithMany("Recepts")
                        .HasForeignKey("TypeGerechtId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MenuGang");

                    b.Navigation("Temperatuur");

                    b.Navigation("TypeGerecht");
                });

            modelBuilder.Entity("HeerlijkeHerinneringen.Data.Models.MenuGang", b =>
                {
                    b.Navigation("Recepts");
                });

            modelBuilder.Entity("HeerlijkeHerinneringen.Data.Models.Recept", b =>
                {
                    b.Navigation("Chefs");

                    b.Navigation("Ingredients");
                });

            modelBuilder.Entity("HeerlijkeHerinneringen.Data.Models.Temperatuur", b =>
                {
                    b.Navigation("Recepts");
                });

            modelBuilder.Entity("HeerlijkeHerinneringen.Data.Models.TypeGerecht", b =>
                {
                    b.Navigation("Recepts");
                });
#pragma warning restore 612, 618
        }
    }
}
