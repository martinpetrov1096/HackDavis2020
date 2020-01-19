﻿// <auto-generated />
using HackDavis2020.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HackDavis2020.Migrations
{
    [DbContext(typeof(SiteContext))]
    [Migration("20200119103409_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("HackDavis2020.Models.BluePrint", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("BluePrint");
                });

            modelBuilder.Entity("HackDavis2020.Models.Language", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Lang");

                    b.HasKey("ID");

                    b.ToTable("Language");
                });
#pragma warning restore 612, 618
        }
    }
}
