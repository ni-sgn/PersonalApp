using System;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Linq;


namespace Services.Repository.Implementation
{
    public class Repository : IRepository
    {
        private DAL.Context.CustomDbContext context {get; set;} 
        public Repository(DAL.Context.CustomDbContext context)
        {
            this.context = context;
        }

        public void CreateBook(DAL.Entities.Books book)
        {
            context.Set<DAL.Entities.Books>().Add(book);
        }

        public IEnumerable<DAL.Entities.Books> GetAllBooks()
        {
            return context.Set<DAL.Entities.Books>();
        } 

        public void UpdateBook(DAL.Entities.Books book)
        {
            context.Set<DAL.Entities.Books>().Update(book);
        }

        public DAL.Entities.Books GetBook(int Book_Id)
        {
            return context.Set<DAL.Entities.Books>().Find(Book_Id);
        }

        public void DeleteBook(DAL.Entities.Books book)
        {
            context.Set<DAL.Entities.Books>().Remove(book);
        }

        public IEnumerable<DAL.Entities.Books> GetBooksByFilter(Expression<Func<DAL.Entities.Books, bool>> expression)
        {
            return context.Set<DAL.Entities.Books>().Where(expression);
        }

        public void SaveChanges()
        {
            context.SaveChanges();
        }

    }
}