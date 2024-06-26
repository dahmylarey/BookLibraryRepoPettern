﻿// <auto-generated />
using System;
using BookLibraryRepoPetternCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookLibraryRepoPetternCore.Migrations
{
    [DbContext(typeof(BookDbContext))]
    partial class BookDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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
                            PublishDate = new DateTime(2024, 5, 11, 12, 9, 31, 601, DateTimeKind.Local).AddTicks(9585),
                            Title = "Eternal secred king"
                        },
                        new
                        {
                            Id = 2,
                            Author = "James wood",
                            Description = "Display info about the Book.",
                            Genre = "Cultivation",
                            PublishDate = new DateTime(2024, 5, 11, 12, 9, 31, 601, DateTimeKind.Local).AddTicks(9607),
                            Title = "Legend of swordsMan"
                        },
                        new
                        {
                            Id = 3,
                            Author = "muller james",
                            Description = "Display info about the Book.",
                            Genre = "Cultivation",
                            PublishDate = new DateTime(2024, 5, 11, 12, 9, 31, 601, DateTimeKind.Local).AddTicks(9613),
                            Title = "Walker of Worlds"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Ibrahim Oloto",
                            Description = "Display info about the Book.",
                            Genre = "Cultivation",
                            PublishDate = new DateTime(2024, 5, 11, 12, 9, 31, 601, DateTimeKind.Local).AddTicks(9616),
                            Title = "Emperor Dominations"
                        },
                        new
                        {
                            Id = 5,
                            Author = "chen Ming",
                            Description = "Display info about the Book.",
                            Genre = "Asian",
                            PublishDate = new DateTime(2024, 5, 11, 12, 9, 31, 601, DateTimeKind.Local).AddTicks(9620),
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
