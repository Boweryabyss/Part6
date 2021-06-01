using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BookstoreProject.Models
{
    public class Book
    {
        public int ID { get; set; }
        [StringLength(154)]
        [Required]
        public string Title { get; set; }
        [StringLength(154)]
        [Required]
        public string Author { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        public DateTime ReleaseDate { get; set; }
    }

    public class BookDBContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}