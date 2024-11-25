using Microsoft.EntityFrameworkCore;

namespace _11_1BooksDbCRUD
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Data.Data.bookContext = new Data.BookContext();
            Data.Data.bookContext.Database.EnsureCreated();
            Data.Data.bookContext.Books.Load();
            Application.Run(new Form1());
        }
    }
}