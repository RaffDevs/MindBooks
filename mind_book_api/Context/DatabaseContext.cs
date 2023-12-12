using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using mind_book_api.Entities;

namespace mind_book_api.Context
{
    public class DatabaseContext : IdentityDbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<Book> Book { get; set; }
        public DbSet<BookCollection> BookCollection { get; set; }
        public DbSet<BookNotes> BookNotes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<BookCollection>()
                .HasMany(bc => bc.Books)
                .WithOne()
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Cascade);

            base.OnModelCreating(builder);
        }
    }
}