﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SpaceTravel.Models;

#nullable disable

namespace SpaceTravel.Migrations
{
    [DbContext(typeof(SpaceTravelContext))]
    [Migration("20230426015035_Distance")]
    partial class Distance
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SpaceTravel.Models.Destination", b =>
                {
                    b.Property<int>("DestinationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Distance")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Price")
                        .HasColumnType("longtext");

                    b.Property<string>("Url")
                        .HasColumnType("longtext");

                    b.HasKey("DestinationId");

                    b.ToTable("Destination");

                    b.HasData(
                        new
                        {
                            DestinationId = 1,
                            Distance = "7,500 light years",
                            Name = "Carina Nebula",
                            Price = "$1,295",
                            Url = "https://images-assets.nasa.gov/image/carina_nebula/carina_nebula~medium.jpg"
                        },
                        new
                        {
                            DestinationId = 2,
                            Distance = "694.7 light years",
                            Name = "Helix Nebula",
                            Price = "$1,495",
                            Url = "https://images-assets.nasa.gov/image/PIA09178/PIA09178~medium.jpg"
                        },
                        new
                        {
                            DestinationId = 3,
                            Distance = "158.16 million miles",
                            Name = "Mars",
                            Price = "$1,095",
                            Url = "https://images-assets.nasa.gov/image/PIA21041/PIA21041~small.jpg"
                        },
                        new
                        {
                            DestinationId = 4,
                            Distance = "2.8516 billion miles",
                            Name = "Neptune ",
                            Price = "$2,295",
                            Url = "https://images-assets.nasa.gov/image/PIA01492/PIA01492~medium.jpg"
                        },
                        new
                        {
                            DestinationId = 5,
                            Distance = "414.8 million light years",
                            Name = "Markarian 421 - Blazar Black Hole",
                            Price = "$1,895",
                            Url = "https://images-assets.nasa.gov/image/PIA20912/PIA20912~small.jpg"
                        },
                        new
                        {
                            DestinationId = 6,
                            Distance = "6,523 light years",
                            Name = "Crab Nebula",
                            Price = "$1,495",
                            Url = "https://images-assets.nasa.gov/image/PIA21474/PIA21474~small.jpg"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}