using System;
using System.Linq;

namespace OnlineBookstore.Models
{
    public interface IBookstoreRespository
    {
        IQueryable<Books> Books { get; }

        public void SaveBook(Books b);
        public void DeleteBook(Books b);
        public void CreateBook(Books b);

    }
}
