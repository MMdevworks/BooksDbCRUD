using _11_1BooksDbCRUD.Data;
using _11_1BooksDbCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_1BooksDbCRUD.Services
{
    public interface ICRUD
    {
        void AddRecord(Book book);
        void DeleteRecord(string bookId);
        void UpdateRecord(string bookId, Book book);
        ICollection<Book> GetAllRecords();
        Book FindBook(string id);
        ICollection<Category> GetAllCategories();
    }

    public class CRUD : ICRUD
    {
        public void AddRecord(Book book)
        {
            Data.Data.bookContext.Books.Add(book);
            Data.Data.bookContext.SaveChanges();
        }

        public void DeleteRecord(string isbn)
        {
            var book = Data.Data.bookContext.Books.Find(isbn);
            Data.Data.bookContext.Books.Remove(book);
            Data.Data.bookContext.SaveChanges();
        }

        public Book FindBook(string isbn)
        {
            return Data.Data.bookContext.Books.Find(isbn);
        }

        public ICollection<Category> GetAllCategories()
        {
            return Data.Data.bookContext.Categories.ToList();
        }

        public ICollection<Book> GetAllRecords()
        {
            return Data.Data.bookContext.Books.ToList();
        }

        public void UpdateRecord(string bookId, Book book)
        {
            var bookToUpdate = Data.Data.bookContext.Books.Find(bookId);
            bookToUpdate.ISBNid = book.ISBNid;
            bookToUpdate.Title = book.Title;
            bookToUpdate.Author = book.Author;
            bookToUpdate.Description = book.Description;
            bookToUpdate.Stock = book.Stock;
            bookToUpdate.CategoryId = book.CategoryId;
            Data.Data.bookContext.SaveChanges();
        }
    }
}

