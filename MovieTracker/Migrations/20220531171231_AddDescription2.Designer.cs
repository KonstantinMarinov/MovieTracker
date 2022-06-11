﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieTracker.Models;

#nullable disable

namespace MovieTracker.Migrations
{
    [DbContext(typeof(MovieTrackerContext))]
    [Migration("20220531171231_AddDescription2")]
    partial class AddDescription2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MovieTracker.Models.Movie", b =>
                {
                    b.Property<Guid>("MovieId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("movie_id");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("title");

                    b.Property<DateTime>("WatchedOn")
                        .HasColumnType("datetime")
                        .HasColumnName("watched_on");

                    b.HasKey("MovieId");

                    b.ToTable("Movie", (string)null);
                });

            modelBuilder.Entity("MovieTracker.Models.Review", b =>
                {
                    b.Property<Guid>("ReviewId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("review_id");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("author");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime")
                        .HasColumnName("created");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit")
                        .HasColumnName("is_deleted");

                    b.Property<Guid>("MovieId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("movie_id");

                    b.Property<int>("Rating")
                        .HasColumnType("int")
                        .HasColumnName("rating");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .IsUnicode(false)
                        .HasColumnType("varchar(1000)")
                        .HasColumnName("text");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime")
                        .HasColumnName("updated");

                    b.HasKey("ReviewId");

                    b.ToTable("Review", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}