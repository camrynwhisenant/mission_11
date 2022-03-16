using System;
using System.Linq;

namespace OnlineBookstore.Models
{
    public interface IPurchaseRepository
    {
        IQueryable<Purchase> Purchases {get; }

        void SavePurchase(Purchase purchase);

    }
}
