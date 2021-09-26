using System.Collections.Generic;
using System.Linq.Expressions;
using System;

namespace Services.Repository
{
    public interface IRepository
    {
        //Create new instance of a book in the database
        void CreateBook(DAL.Entities.Books entity);
        //Get all books from the database
        IEnumerable<DAL.Entities.Books> GetAllBooks();   

        //Get specifig book with id
        DAL.Entities.Books GetBook(int Book_Id);

        //Update the book data
        void UpdateBook(DAL.Entities.Books entity);

        //Detele the book from the database
        void DeleteBook(DAL.Entities.Books entity);

        //Filter books
        IEnumerable<DAL.Entities.Books> GetBooksByFilter(Expression<Func<DAL.Entities.Books, bool>> expression);
    }
}