using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineBookstore.Models;
using OnlineBookstore.Models.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OnlineBookstore.Controllers
{
    public class HomeController : Controller
    {
        //private BookstoreContext context { get; set; }
        private IBookstoreRespository repo;

        //private IWaterProjectRespository repo;


        //public HomeController(BookstoreContext temp)
        //{
        //    context = temp;
        //}

        public HomeController(IBookstoreRespository temp)
        {
            repo = temp;
        }

        public IActionResult Index(string bookCategory, int pageNum = 1) //accepts pageNum, default 1
        {
            int pageSize = 10;

            var x = new BooksViewModel
            {
                Books = repo.Books
                .Where(p => p.Category == bookCategory || bookCategory == null)
                .OrderBy(p => p.Title) //puts it in alphabetical order
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PageInfo = new PageInfo
                {
                    TotalNumBooks = (bookCategory== null
                        ? repo.Books.Count()
                        : repo.Books.Where(x => x.Category == bookCategory).Count()), 
                    BooksPerPage = pageSize,
                    CurrentPage = pageNum
                }
            };

            return View(x);
        }
    }
}
