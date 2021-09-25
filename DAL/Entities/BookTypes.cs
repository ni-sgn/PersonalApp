using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class BookTypes{
        [Key]
        public int BookTypes_Id {get;set;}
        public string Type {get;set;}

        public ICollection<DAL.Entities.Books> books {get;set;}
    }

}