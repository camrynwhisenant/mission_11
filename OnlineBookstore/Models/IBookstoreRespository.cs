using System;
using System.Linq;

namespace OnlineBookstore.Models
{
    public interface IBookstoreRespository
    {
        IQueryable<Books> Books { get; }

    }
}
