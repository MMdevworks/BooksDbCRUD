using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_1BooksDbCRUD.Models
{
    public class Book
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string ISBNid { get; set; }
        public string Title { get; set; }
        public string? Author { get; set; }
        public string Description {  get; set; }
        public int Stock {  get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; } = null;
    }
}
