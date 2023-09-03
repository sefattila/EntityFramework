﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Movie.DAL.Contexts;

#nullable disable

namespace Movie.DAL.Migrations
{
    [DbContext(typeof(FilmContext))]
    partial class FilmContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Movie.DATA.Concrete.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ActorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Biography")
                        .HasColumnType("text");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("TblActor", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ActorName = "Leonardo DiCaprio",
                            CreatedDate = new DateTime(2023, 9, 3, 19, 5, 11, 962, DateTimeKind.Local).AddTicks(6519),
                            Status = 0
                        },
                        new
                        {
                            Id = 2,
                            ActorName = "Tom Hanks",
                            CreatedDate = new DateTime(2023, 9, 3, 19, 5, 11, 962, DateTimeKind.Local).AddTicks(6520),
                            Status = 0
                        },
                        new
                        {
                            Id = 3,
                            ActorName = "Michael Clarke Duncan",
                            CreatedDate = new DateTime(2023, 9, 3, 19, 5, 11, 962, DateTimeKind.Local).AddTicks(6521),
                            Status = 0
                        },
                        new
                        {
                            Id = 4,
                            ActorName = "Tom Hardy",
                            CreatedDate = new DateTime(2023, 9, 3, 19, 5, 11, 962, DateTimeKind.Local).AddTicks(6522),
                            Status = 0
                        });
                });

            modelBuilder.Entity("Movie.DATA.Concrete.Film", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("FilmDuration")
                        .HasColumnType("float");

                    b.Property<string>("FilmName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("TblFilm", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2023, 9, 3, 19, 5, 11, 962, DateTimeKind.Local).AddTicks(7047),
                            FilmDuration = 2.5,
                            FilmName = "Cath Me If You Can",
                            Status = 0
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2023, 9, 3, 19, 5, 11, 962, DateTimeKind.Local).AddTicks(7049),
                            FilmDuration = 3.0,
                            FilmName = "Forest Gump",
                            Status = 0
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            CreatedDate = new DateTime(2023, 9, 3, 19, 5, 11, 962, DateTimeKind.Local).AddTicks(7050),
                            FilmDuration = 2.0,
                            FilmName = "Inception",
                            Status = 0
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            CreatedDate = new DateTime(2023, 9, 3, 19, 5, 11, 962, DateTimeKind.Local).AddTicks(7051),
                            FilmDuration = 2.2999999999999998,
                            FilmName = "The Green Mile",
                            Status = 0
                        });
                });

            modelBuilder.Entity("Movie.DATA.Concrete.FilmActor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ActorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("WorkDay")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ActorId");

                    b.HasIndex("FilmId");

                    b.ToTable("TblFilmActor", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ActorId = 1,
                            CreatedDate = new DateTime(2023, 9, 3, 19, 5, 11, 962, DateTimeKind.Local).AddTicks(6829),
                            FilmId = 1,
                            Status = 0
                        },
                        new
                        {
                            Id = 2,
                            ActorId = 2,
                            CreatedDate = new DateTime(2023, 9, 3, 19, 5, 11, 962, DateTimeKind.Local).AddTicks(6831),
                            FilmId = 1,
                            Status = 0
                        },
                        new
                        {
                            Id = 3,
                            ActorId = 2,
                            CreatedDate = new DateTime(2023, 9, 3, 19, 5, 11, 962, DateTimeKind.Local).AddTicks(6832),
                            FilmId = 2,
                            Status = 0
                        },
                        new
                        {
                            Id = 4,
                            ActorId = 1,
                            CreatedDate = new DateTime(2023, 9, 3, 19, 5, 11, 962, DateTimeKind.Local).AddTicks(6833),
                            FilmId = 3,
                            Status = 0
                        },
                        new
                        {
                            Id = 5,
                            ActorId = 4,
                            CreatedDate = new DateTime(2023, 9, 3, 19, 5, 11, 962, DateTimeKind.Local).AddTicks(6834),
                            FilmId = 3,
                            Status = 0
                        },
                        new
                        {
                            Id = 6,
                            ActorId = 2,
                            CreatedDate = new DateTime(2023, 9, 3, 19, 5, 11, 962, DateTimeKind.Local).AddTicks(6836),
                            FilmId = 4,
                            Status = 0
                        },
                        new
                        {
                            Id = 7,
                            ActorId = 3,
                            CreatedDate = new DateTime(2023, 9, 3, 19, 5, 11, 962, DateTimeKind.Local).AddTicks(6837),
                            FilmId = 4,
                            Status = 0
                        });
                });

            modelBuilder.Entity("Movie.DATA.Concrete.FilmCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("TblCategory", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Drama",
                            CreatedDate = new DateTime(2023, 9, 3, 19, 5, 11, 962, DateTimeKind.Local).AddTicks(6918),
                            Status = 0
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Action",
                            CreatedDate = new DateTime(2023, 9, 3, 19, 5, 11, 962, DateTimeKind.Local).AddTicks(6919),
                            Status = 0
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Science Fiction",
                            CreatedDate = new DateTime(2023, 9, 3, 19, 5, 11, 962, DateTimeKind.Local).AddTicks(6920),
                            Status = 0
                        },
                        new
                        {
                            Id = 4,
                            CategoryName = "Comedy",
                            CreatedDate = new DateTime(2023, 9, 3, 19, 5, 11, 962, DateTimeKind.Local).AddTicks(6921),
                            Status = 0
                        });
                });

            modelBuilder.Entity("Movie.DATA.Concrete.FilmDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FilmDetails")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("FilmId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("FilmId")
                        .IsUnique();

                    b.ToTable("TblFilmDetail", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 9, 3, 19, 5, 11, 962, DateTimeKind.Local).AddTicks(6985),
                            FilmDetails = "DenemeDenemeDeneme",
                            FilmId = 1,
                            Status = 0
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 9, 3, 19, 5, 11, 962, DateTimeKind.Local).AddTicks(6987),
                            FilmDetails = "DenemeDenemeDeneme",
                            FilmId = 2,
                            Status = 0
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 9, 3, 19, 5, 11, 962, DateTimeKind.Local).AddTicks(6988),
                            FilmDetails = "DenemeDenemeDeneme",
                            FilmId = 3,
                            Status = 0
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2023, 9, 3, 19, 5, 11, 962, DateTimeKind.Local).AddTicks(6989),
                            FilmDetails = "DenemeDenemeDeneme",
                            FilmId = 4,
                            Status = 0
                        });
                });

            modelBuilder.Entity("Movie.DATA.Concrete.Film", b =>
                {
                    b.HasOne("Movie.DATA.Concrete.FilmCategory", "FilmCategory")
                        .WithMany("Films")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FilmCategory");
                });

            modelBuilder.Entity("Movie.DATA.Concrete.FilmActor", b =>
                {
                    b.HasOne("Movie.DATA.Concrete.Actor", "Actor")
                        .WithMany("FilmActors")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Movie.DATA.Concrete.Film", "Film")
                        .WithMany("FilmActors")
                        .HasForeignKey("FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Film");
                });

            modelBuilder.Entity("Movie.DATA.Concrete.FilmDetail", b =>
                {
                    b.HasOne("Movie.DATA.Concrete.Film", "Film")
                        .WithOne("FilmDetail")
                        .HasForeignKey("Movie.DATA.Concrete.FilmDetail", "FilmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Film");
                });

            modelBuilder.Entity("Movie.DATA.Concrete.Actor", b =>
                {
                    b.Navigation("FilmActors");
                });

            modelBuilder.Entity("Movie.DATA.Concrete.Film", b =>
                {
                    b.Navigation("FilmActors");

                    b.Navigation("FilmDetail")
                        .IsRequired();
                });

            modelBuilder.Entity("Movie.DATA.Concrete.FilmCategory", b =>
                {
                    b.Navigation("Films");
                });
#pragma warning restore 612, 618
        }
    }
}
