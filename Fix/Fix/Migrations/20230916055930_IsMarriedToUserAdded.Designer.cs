﻿// <auto-generated />
using System;
using Fix.Models.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Fix.Migrations
{
    [DbContext(typeof(EFDbContext))]
    [Migration("20230916055930_IsMarriedToUserAdded")]
    partial class IsMarriedToUserAdded
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Fix.Models.Category", b =>
                {
                    b.Property<int>("ItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ItemID"));

                    b.Property<string>("Art")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Byd")
                        .HasColumnType("real");

                    b.Property<DateTime>("Dat")
                        .HasColumnType("datetime2");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("ItemID");

                    b.ToTable("Mark");
                });
#pragma warning restore 612, 618
        }
    }
}
