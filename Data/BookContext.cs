using _11_1BooksDbCRUD.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_1BooksDbCRUD.Data
{
    public class BookContext:DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=MariePC\MSSQLSERVER01;Database=booksdb;Integrated Security=true;Trusted_Connection=true;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
            new Category { CategoriesId = 1, Name = "Fiction"},
            new Category { CategoriesId = 2, Name = "Non-Fiction"},
            new Category { CategoriesId = 3, Name = "Education"},
            new Category { CategoriesId = 4, Name = "Cooking"}
            );


        modelBuilder.Entity<Book>().HasData(
            new Book { ISBNid = "150-55-73251-02-5", CategoryId = 1, Title = "Frankenstein", Author = "Mary Shelley", Description = "Frankenstein tells the story of Victor Frankenstein, a young scientist who creates a sapient creature in an unorthodox scientific experiment.", Stock = 5 },
            new Book { ISBNid = "230-55-88851-01-0", CategoryId = 1, Title = "The War of the Worlds", Author = "H.G. Wells", Description = "H.G. Wells's hugely influential book tracks the exploits of a writer who struggles to survive an alien invasion of Victorian England.", Stock = 4 },
            new Book { ISBNid = "660-55-53251-02-6", CategoryId = 2, Title = "Hidden Figures", Author = "Margot Lee Shetterly", Description = "The phenomenal true story of the black female mathematicians at NASA whose calculations helped fuel some of America’s greatest achievements in space.", Stock = 2 },
            new Book { ISBNid = "180-55-62551-03-5", CategoryId = 2, Title = "Angela's Ashes", Author = "Frank McCourt", Description = "A 1996 memoir by the Irish-American author Frank McCourt, with various anecdotes and stories of his childhood.", Stock = 3 },
            new Book { ISBNid = "754-55-55551-02-0", CategoryId = 3, Title = "A Common-Sense Guide to Data Structures and Algorithms", Author = "Jay Wengrow", Description = "ake a practical approach to data structures and algorithms, with techniques and real-world scenarios that you can use in your daily production code.", Stock = 1 },
            new Book { ISBNid = "645-55-35351-01-5", CategoryId = 3, Title = "History of the World Map by Map", Author = "DK", Description = "Explore the history of the world in unprecedented detail with this ultimate guide to history throughout the ages. ", Stock = 0 },
            new Book { ISBNid = "160-55-57451-04-3", CategoryId = 4, Title = "The World Central Kitchen Cookbook", Author = "José Andrés", Description = "A captivating collection of stories and recipes from renowned chefs, local cooks, and celebrity friends of José Andrés’s beloved nonprofit World Central Kitchen.", Stock = 2 },
            new Book { ISBNid = "150-55-86511-01-5", CategoryId = 4, Title = "From Crook to Cook: Platinum Recipes from Tha Boss Dogg's Kitchen", Author = "SnoopDogg", Description = "Recipe book that delivers 50 recipes straight from Snoop's own collection", Stock = 0 }
            );

        }
    }
}
