using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace DAL.Entities
{

    public class Books
    {
        [Key]
        public int Books_Id {get;set;}
        public string Title {get;set;}
        public string Author_Firstname {get;set;}
        public string Author_Lastname {get;set;}
        public string MyImpressions {get;set;}

        public ICollection<DAL.Entities.BookTypes> bookTypes {get;set;}


    }
}
