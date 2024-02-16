using BjornsBookShop.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace BjornsBookShop.Models
{
    public class Transaction
    {
        //  public int Id { get; set; }
        //  public string Name { get; set; }
        //public DateTime OrderDate { get; set; }
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Genre { get; set; }
        public int? Price { get; set; }
        public string? PicturePath { get; set; }
        //public List<TransactionItem> Items { get; set; }
    }
}
