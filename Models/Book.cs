using Humanizer.Localisation;
using System.ComponentModel;

namespace BjornsBookShop.Models
{
    public class Book
    {
        //[DefaultValue(0)]
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; } 
        public string? Genre { get; set; } 
        public int? Price { get; set; }

    }
}
