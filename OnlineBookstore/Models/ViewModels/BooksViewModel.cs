using System;
using System.Linq;

namespace OnlineBookstore.Models.ViewModels
{
    public class BooksViewModel
    {
        public IQueryable<Books> Books { get; set; }
        public PageInfo PageInfo { get; set; }

    }
}
