using System;
using System.ComponentModel.DataAnnotations;

namespace BookKeeper.Data
{
    public class Category
    {
        public Category()
        {
        }

        [Key]
        public string NameToken { get; set; }
        public int Type { get; set; }
        public string Description { get; set; }
    }
}
