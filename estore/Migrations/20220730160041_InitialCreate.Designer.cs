﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using estore.Models;

namespace estore.Migrations
{
    [DbContext(typeof(productContext))]
    [Migration("20220730160041_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("estore.Models.product", b =>
                {
                    b.Property<int>("productID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("gallery")
                        .HasColumnType("bit");

                    b.Property<bool>("isBestCollection")
                        .HasColumnType("bit");

                    b.Property<bool>("isBestProduct")
                        .HasColumnType("bit");

                    b.Property<bool>("isCategory")
                        .HasColumnType("bit");

                    b.Property<bool>("isLatestOffer")
                        .HasColumnType("bit");

                    b.Property<bool>("isLatestProduct")
                        .HasColumnType("bit");

                    b.Property<bool>("isSlider")
                        .HasColumnType("bit");

                    b.HasKey("productID");

                    b.ToTable("products");
                });
#pragma warning restore 612, 618
        }
    }
}
