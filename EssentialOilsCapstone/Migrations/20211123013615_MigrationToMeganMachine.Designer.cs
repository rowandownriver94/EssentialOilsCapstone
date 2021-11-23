﻿// <auto-generated />
using EssentialOilCapstone.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EssentialOilsCapstone.Migrations
{
    [DbContext(typeof(OilDbContext))]
    [Migration("20211123013615_MigrationToMeganMachine")]
    partial class MigrationToMeganMachine
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("EssentialOilCapstone.Models.Oil", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("EssentialOils");
                });

            modelBuilder.Entity("EssentialOilCapstone.Models.OilTreatment", b =>
                {
                    b.Property<int>("OilId")
                        .HasColumnType("int");

                    b.Property<int>("TreatmentId")
                        .HasColumnType("int");

                    b.HasKey("OilId", "TreatmentId");

                    b.HasIndex("TreatmentId");

                    b.ToTable("OilTreatment");
                });

            modelBuilder.Entity("EssentialOilCapstone.Models.Treatment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Treatment");
                });

            modelBuilder.Entity("EssentialOilCapstone.Models.OilTreatment", b =>
                {
                    b.HasOne("EssentialOilCapstone.Models.Oil", "Oil")
                        .WithMany()
                        .HasForeignKey("OilId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EssentialOilCapstone.Models.Treatment", "Treatment")
                        .WithMany()
                        .HasForeignKey("TreatmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}