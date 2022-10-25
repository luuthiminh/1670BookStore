using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Book_Store.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public DateTime Date { get; set; }
        public int Quantity    { get; set; }
        public double Price { get; set; }

       /* public ICollection<Book> Books { get; set;}*/
       //1 book có thể có nhiều order
       //1 order chỉ có thể có 1sp
       //
        public string Image { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
