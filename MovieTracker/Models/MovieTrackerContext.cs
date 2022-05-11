using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MovieTracker.Models
{
    public partial class MovieTrackerContext : DbContext
    {
        public MovieTrackerContext()
        {
        }

        public MovieTrackerContext(DbContextOptions<MovieTrackerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Movie> Movies { get; set; } = null!;
        public virtual DbSet<Review> Reviews { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=MovieTracker;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>(entity =>
            {
                entity.ToTable("Movie");

                entity.Property(e => e.MovieId)
                    .ValueGeneratedNever()
                    .HasColumnName("movie_id");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("title");

                entity.Property(e => e.WatchedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("watched_on");
            });

            modelBuilder.Entity<Review>(entity =>
            {
                entity.ToTable("Review");

                entity.Property(e => e.ReviewId)
                    .ValueGeneratedNever()
                    .HasColumnName("review_id");

                entity.Property(e => e.Author)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("author");

                entity.Property(e => e.Created)
                    .HasColumnType("datetime")
                    .HasColumnName("created");

                entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");

                entity.Property(e => e.MovieId).HasColumnName("movie_id");

                entity.Property(e => e.Rating).HasColumnName("rating");

                entity.Property(e => e.Text)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("text");

                entity.Property(e => e.Updated)
                    .HasColumnType("datetime")
                    .HasColumnName("updated");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
