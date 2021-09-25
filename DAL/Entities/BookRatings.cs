using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class BookRatings
    {
        [Key]
        public int BookRatings_Id {get;set;}
        public int Rating {get;set;}

        public ICollection<DAL.Entities.Books> books {get;set;}
    }
}