using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookStore_API.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Author>()
        //        .HasMany(a => a.Books)
        //        .WithOne(b => b.Author);
        //    modelBuilder.Entity<IdentityUserLogin<string>>(
        //        er =>
        //        {
        //            er.HasNoKey();
        //        });
        //    modelBuilder.Entity<IdentityUserRole<string>>(
        //        er =>
        //        {
        //            er.HasNoKey();
        //        });
        //}

    }
}
