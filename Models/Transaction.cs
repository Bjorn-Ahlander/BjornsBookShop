using BjornsBookShop.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace BjornsBookShop.Models
{
    public class Transaction
    {
        public int Id { get; set; }

       // [ForeignKey("Book")]
       // public int BookId { get; set; }
       // public virtual Book Book { get; set; }

        //[ForeignKey("Customer")]
        //public int CustomerId { get; set; }
        //public virtual Customer Customer { get; set; }

        public string? Title { get; set; }
        public int? Price { get; set; }  
        public int Quantity { get; set; }
        public int Total_Amount { get; set; }
    }
}
