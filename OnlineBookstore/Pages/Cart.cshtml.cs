using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OnlineBookstore.Infastructure;
using OnlineBookstore.Models;
using Microsoft.AspNetCore.Http;

namespace OnlineBookstore.Pages
{
    public class CartModel : PageModel
    {
        private IBookstoreRespository repo { get; set; }
        public CartModel(IBookstoreRespository temp)
        {
            repo = temp;
        }
        public string ReturnUrl { get; set; }

        public Cart cart { get; set; }
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }
        public IActionResult OnPost(int bookId, string returnUrl)
        {
            Books b = repo.Books.FirstOrDefault(x => x.BookId == bookId);
            cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
            cart.AddItem(b, 1);

            HttpContext.Session.SetJson("cart", cart);
            return RedirectToPage(new { ReturnUrl = returnUrl });

        }
    }
}
