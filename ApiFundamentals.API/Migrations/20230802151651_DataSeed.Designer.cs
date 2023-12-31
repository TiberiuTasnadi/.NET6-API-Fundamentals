﻿// <auto-generated />
using ApiFundamentals.API.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiFundamentals.API.Migrations
{
    [DbContext(typeof(CityInfoContext))]
    [Migration("20230802151651_DataSeed")]
    partial class DataSeed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("ApiFundamentals.API.Entities.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Description",
                            Name = "New York"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Description2",
                            Name = "New York2"
                        });
                });

            modelBuilder.Entity("ApiFundamentals.API.Entities.PointOfInterest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CityId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("PointOfInterest");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityId = 1,
                            Description = "Description POI",
                            Name = "New York POI"
                        },
                        new
                        {
                            Id = 2,
                            CityId = 2,
                            Description = "Description2 POI",
                            Name = "New York2 POI"
                        });
                });

            modelBuilder.Entity("ApiFundamentals.API.Entities.PointOfInterest", b =>
                {
                    b.HasOne("ApiFundamentals.API.Entities.City", "City")
                        .WithMany("PointOfInterest")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("ApiFundamentals.API.Entities.City", b =>
                {
                    b.Navigation("PointOfInterest");
                });
#pragma warning restore 612, 618
        }
    }
}
