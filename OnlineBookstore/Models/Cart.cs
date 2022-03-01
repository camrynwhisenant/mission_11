using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace OnlineBookstore.Models
{
    public class Cart
    {
        //creates new list of Items
        public List<CartLineItem> Items { get; set; } = new List<CartLineItem>();

        //add books to cart or increment book if already in cart
        public virtual void AddItem(Books book, int qty)
        {
            CartLineItem line = Items
                .Where(b => b.Book.BookId == book.BookId)
                .FirstOrDefault();
            if (line == null)
            {
                Items.Add(new CartLineItem
                {
                    Book = book,
                    Quantity = qty
                });
            }
            else
            {
                line.Quantity += qty;
            }
        }

        //calculate total for Items
        public double CalculateTotal()
        {
            double sum = Items.Sum(x => x.Quantity * 10);
            return sum;
        }

        //remove books from cart
        public virtual void RemoveItem(Books book)
        {
            Items.RemoveAll(x => x.Book.BookId == book.BookId);
        }

        public virtual void ClearCart()
        {
            Items.Clear();
        }
    }
    public class CartLineItem
        {
            [Key]
            public int LineID { get; set; }
            public Books Book { get; set; }
            public int Quantity { get; set; }
            
    }
    
}
