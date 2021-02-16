﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _portfolio.Data;

namespace _portfolio.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20210216113728_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("_portfolio.Data.Models.Example", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("description")
                        .HasColumnType("TEXT");

                    b.Property<string>("gitUrl")
                        .HasColumnType("TEXT");

                    b.Property<string>("img")
                        .HasColumnType("TEXT");

                    b.Property<string>("nameExample")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Example");
                });
#pragma warning restore 612, 618
        }
    }
}
