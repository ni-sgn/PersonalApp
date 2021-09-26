using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;

namespace DAL.Context
{
    public static class Initializer
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DAL.Entities.Books>().HasData(
                new DAL.Entities.Books()
                {
                    Books_Id = 1,
                    Author_Firstname = "John",
                    Author_Lastname = "Doe",
                    Title = "13km under pressure",
                }
            );
        }
    }
}