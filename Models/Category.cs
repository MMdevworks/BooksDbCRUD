using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_1BooksDbCRUD.Models
{
    public class Category
    {
        [Key]
        public int CategoriesId { get; set; }
        public string? Name { get; set; }
        public virtual ObservableCollectionListSource<Book> Books { get; set; }
    }
}
