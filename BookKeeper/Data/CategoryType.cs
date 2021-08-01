using System;
using System.ComponentModel.DataAnnotations;

namespace BookKeeper.Data
{
    public class CategoryType
    {
        public CategoryType()
        {
        }

        [Key]
        public string Type { get; set; }
        public string Name { get; set; }
    }
}
