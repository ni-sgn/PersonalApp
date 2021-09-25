using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace DAL.Context
{
    public class CustomDbContext : DbContext
    {
        public CustomDbContext(DbContextOptions options) : base(options)
        {}

        public DbSet<DAL.Entities.Books> books {get;set;}
        public DbSet<DAL.Entities.BookRatings> bookRatings {get;set;}
        public DbSet<DAL.Entities.BookTypes> bookTypes {get;set;}

    }
}


