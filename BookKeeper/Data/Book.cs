using System;
using System.ComponentModel.DataAnnotations;

namespace BookKeeper.Data
{
    public class Book
    {
        public Book()
        {
        }

        [Key]
        public string ISBN { get; set; }
        public string Title { get; set; }
        public int Category { get; set; }
        public string Author { get; set; }
    }
}
