using System;
using System.Linq;

namespace OnlineBookstore.Models
{
    public class EFBookstoreRepository : IBookstoreRespository
    {
        private BookstoreContext context { get; set; }

        public EFBookstoreRepository(BookstoreContext temp)
        {
            context = temp;
        }
        public IQueryable<Books> Books => context.Books;
    }
}
