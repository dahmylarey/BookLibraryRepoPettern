﻿// <auto-generated />
using System;
using BookLibraryRepoPetternCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookLibraryRepoPetternCore.Migrations
{
    [DbContext(typeof(BookDbContext))]
    [Migration("20240424202600_BookTableAndForeignKeyAdded")]
    partial class BookTableAndForeignKeyAdded
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookBook", b =>
                {
                    b.Property<int>("BooksId")
                        .HasColumnType("int");

                    b.Property<int>("JournalId")
                        .HasColumnType("int");

                    b.HasKey("BooksId", "JournalId");

                    b.HasIndex("JournalId");

                    b.ToTable("BookBook");
                });

            modelBuilder.Entity("BookLibraryRepoPetternCore.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("AuthorId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Damilare oladele",
                            Description = "Display info about the Book.",
                            Genre = "Asian",
                            PublishDate = new DateTime(2024, 4, 24, 21, 25, 59, 699, DateTimeKind.Local).AddTicks(4694),
                            Title = "Eternal secred king"
                        },
                        new
                        {
                            Id = 2,
                            Author = "James wood",
                            Description = "Display info about the Book.",
                            Genre = "Cultivation",
                            PublishDate = new DateTime(2024, 4, 24, 21, 25, 59, 699, DateTimeKind.Local).AddTicks(4708),
                            Title = "Legend of swordsMan"
                        },
                        new
                        {
                            Id = 3,
                            Author = "muller james",
                            Description = "Display info about the Book.",
                            Genre = "Cultivation",
                            PublishDate = new DateTime(2024, 4, 24, 21, 25, 59, 699, DateTimeKind.Local).AddTicks(4709),
                            Title = "Walker of Worlds"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Ibrahim Oloto",
                            Description = "Display info about the Book.",
                            Genre = "Cultivation",
                            PublishDate = new DateTime(2024, 4, 24, 21, 25, 59, 699, DateTimeKind.Local).AddTicks(4710),
                            Title = "Emperor Dominations"
                        },
                        new
                        {
                            Id = 5,
                            Author = "chen Ming",
                            Description = "Display info about the Book.",
                            Genre = "Asian",
                            PublishDate = new DateTime(2024, 4, 24, 21, 25, 59, 699, DateTimeKind.Local).AddTicks(4711),
                            Title = "Loaded With Persive Skills"
                        });
                });

            modelBuilder.Entity("BookLibraryRepoPetternCore.DataModels.Tbl_Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AuthorId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Tbl_AuthorAuthorId")
                        .HasColumnType("int");

                    b.HasKey("AuthorId");

                    b.HasIndex("Tbl_AuthorAuthorId");

                    b.ToTable("tbl_Authors");
                });

            modelBuilder.Entity("BookBook", b =>
                {
                    b.HasOne("BookLibraryRepoPetternCore.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookLibraryRepoPetternCore.Book", null)
                        .WithMany()
                        .HasForeignKey("JournalId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookLibraryRepoPetternCore.Book", b =>
                {
                    b.HasOne("BookLibraryRepoPetternCore.DataModels.Tbl_Author", "AuthorsCollection")
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.Navigation("AuthorsCollection");
                });

            modelBuilder.Entity("BookLibraryRepoPetternCore.DataModels.Tbl_Author", b =>
                {
                    b.HasOne("BookLibraryRepoPetternCore.DataModels.Tbl_Author", null)
                        .WithMany("AuthorsCollection")
                        .HasForeignKey("Tbl_AuthorAuthorId");
                });

            modelBuilder.Entity("BookLibraryRepoPetternCore.DataModels.Tbl_Author", b =>
                {
                    b.Navigation("AuthorsCollection");
                });
#pragma warning restore 612, 618
        }
    }
}
