﻿// <auto-generated />
using System;
using DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DAL.Migrations
{
    [DbContext(typeof(CustomDbContext))]
    partial class CustomDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookTypesBooks", b =>
                {
                    b.Property<int>("BookTypes_Id")
                        .HasColumnType("int");

                    b.Property<int>("Books_Id")
                        .HasColumnType("int");

                    b.HasKey("BookTypes_Id", "Books_Id");

                    b.HasIndex("Books_Id");

                    b.ToTable("BookTypesBooks");
                });

            modelBuilder.Entity("DAL.Entities.BookRatings", b =>
                {
                    b.Property<int>("BookRatings_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.HasKey("BookRatings_Id");

                    b.ToTable("bookRatings");
                });

            modelBuilder.Entity("DAL.Entities.BookTypes", b =>
                {
                    b.Property<int>("BookTypes_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookTypes_Id");

                    b.ToTable("bookTypes");
                });

            modelBuilder.Entity("DAL.Entities.Books", b =>
                {
                    b.Property<int>("Books_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author_Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Author_Lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BookRatings_Id")
                        .HasColumnType("int");

                    b.Property<string>("MyImpressions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Books_Id");

                    b.HasIndex("BookRatings_Id");

                    b.ToTable("books");

                    b.HasData(
                        new
                        {
                            Books_Id = 1,
                            Author_Firstname = "John",
                            Author_Lastname = "Doe",
                            Title = "13km under pressure"
                        });
                });

            modelBuilder.Entity("BookTypesBooks", b =>
                {
                    b.HasOne("DAL.Entities.BookTypes", null)
                        .WithMany()
                        .HasForeignKey("BookTypes_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.Books", null)
                        .WithMany()
                        .HasForeignKey("Books_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DAL.Entities.Books", b =>
                {
                    b.HasOne("DAL.Entities.BookRatings", null)
                        .WithMany("books")
                        .HasForeignKey("BookRatings_Id");
                });

            modelBuilder.Entity("DAL.Entities.BookRatings", b =>
                {
                    b.Navigation("books");
                });
#pragma warning restore 612, 618
        }
    }
}
