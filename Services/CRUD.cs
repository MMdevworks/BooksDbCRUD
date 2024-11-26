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
        void DeleteRecord(int bookId);
        void UpdateRecord(int bookId, Book book);
        ICollection<Book> GetAllRecords();
        Book FindBook(int id);
        ICollection<Category> GetAllCategories();
    }

    public class CRUD : ICRUD
    {
        public void AddRecord(Book book)
        {
            Data.Data.bookContext.Books.Add(book);
            Data.Data.bookContext.SaveChanges();
        }

        public void DeleteRecord(int bookId)
        {
            var book = Data.Data.bookContext.Books.Find(bookId);
            Data.Data.bookContext.Books.Remove(book);
            Data.Data.bookContext.SaveChanges();
        }

        public Book FindBook(int id)
        {
            return Data.Data.bookContext.Books.Find(id);
        }

        public ICollection<Category> GetAllCategories()
        {
            return Data.Data.bookContext.Categories.ToList();
        }

        public ICollection<Book> GetAllRecords()
        {
            return Data.Data.bookContext.Books.ToList();
        }

        public void UpdateRecord(int bookId, Book book)
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

