﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RecordCollection.DataAccess;

#nullable disable

namespace RecordCollection.Migrations
{
    [DbContext(typeof(RecordCollectionContext))]
    [Migration("20230921151120_seedData")]
    partial class seedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("RecordCollection.Models.Album", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Artist")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("artist");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("release_date");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.HasKey("Id")
                        .HasName("pk_albums");

                    b.ToTable("albums", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Artist = "Pink Floyd",
                            ReleaseDate = new DateTime(1973, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Title = "Dark Side of the Moon"
                        },
                        new
                        {
                            Id = 2,
                            Artist = "The Beatles",
                            ReleaseDate = new DateTime(1969, 9, 26, 0, 0, 0, 0, DateTimeKind.Utc),
                            Title = "Abbey Road"
                        },
                        new
                        {
                            Id = 3,
                            Artist = "Led Zeppelin",
                            ReleaseDate = new DateTime(1971, 11, 8, 0, 0, 0, 0, DateTimeKind.Utc),
                            Title = "Led Zeppelin IV"
                        },
                        new
                        {
                            Id = 4,
                            Artist = "Fleetwood Mac",
                            ReleaseDate = new DateTime(1977, 2, 4, 0, 0, 0, 0, DateTimeKind.Utc),
                            Title = "Rumours"
                        },
                        new
                        {
                            Id = 5,
                            Artist = "Pink Floyd",
                            ReleaseDate = new DateTime(1979, 11, 30, 0, 0, 0, 0, DateTimeKind.Utc),
                            Title = "The Wall"
                        },
                        new
                        {
                            Id = 6,
                            Artist = "The Beatles",
                            ReleaseDate = new DateTime(1966, 8, 5, 0, 0, 0, 0, DateTimeKind.Utc),
                            Title = "Revolver"
                        },
                        new
                        {
                            Id = 7,
                            Artist = "Led Zeppelin",
                            ReleaseDate = new DateTime(1969, 10, 22, 0, 0, 0, 0, DateTimeKind.Utc),
                            Title = "Led Zeppelin II"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
