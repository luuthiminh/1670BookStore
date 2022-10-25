using System.Collections;
using System.Collections.Generic;

namespace Book_Store.Models
{
    public class Book
    {
        public int Id { get; set; }
       /* public string Book_ID { get; set; }*/
        public string Title { get; set; }
        public string Category { get; set; }
        public double Book_Price { get; set; }
        public int Book_Quantity { get; set; }
        public string Book_Description { get; set; }
        public string Author { get; set; }
        public string Book_Image { get; set; }
     
        public ICollection<Order> Orders { get; set; }
    }
}
