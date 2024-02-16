﻿using Microsoft.EntityFrameworkCore;
using PokemonReview.Models;

namespace PokemonReview.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<Category> Categories { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Owner> Owners { get; set; }

        public DbSet<Pokemon> Pokemon { get; set; }

        public DbSet<PokemonOwner> PokemonOwners { get; set; }

        public DbSet<PokemonCategory> PokemonCategories { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Reviewer> Reviewers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PokemonCategory>()
                     .HasKey(pc => new { pc.CategoryId, pc.PokemonId });
            modelBuilder.Entity<PokemonCategory>()
                     .HasOne<Pokemon>(p => p.Pokemon)
                     .WithMany(pc => pc.PokemonCategories)
                     .HasForeignKey(p => p.PokemonId);
            modelBuilder.Entity<PokemonCategory>()
                    .HasOne<Category>(p => p.Category)
                    .WithMany(pc => pc.PokemonCategories)
                    .HasForeignKey(c => c.CategoryId);


            modelBuilder.Entity<PokemonOwner>()
                     .HasKey(po => new { po.OwnerId, po.PokemonId });
            modelBuilder.Entity<PokemonOwner>()
                     .HasOne<Pokemon>(p => p.Pokemon)
                     .WithMany(po => po.PokemonOwners)
                     .HasForeignKey(p => p.PokemonId);
            modelBuilder.Entity<PokemonOwner>()
                    .HasOne<Owner>(o => o.Owner)
                    .WithMany(po => po.PokemonOwners)
                    .HasForeignKey(o => o.OwnerId);
        }
    }
}
