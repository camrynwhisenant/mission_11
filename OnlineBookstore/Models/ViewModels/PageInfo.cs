using System;
namespace OnlineBookstore.Models.ViewModels
{
    public class PageInfo
    {
        public int TotalNumBooks { get; set; }
        public int CurrentPage { get; set; }
        public int BooksPerPage { get; set; }

        //calculates pages needed
        public int TotalPages => (int)Math.Ceiling((double) TotalNumBooks / BooksPerPage);

    }
}
