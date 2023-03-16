using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2ndClassAmazon.Infrastructure;
using _2ndClassAmazon.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace _2ndClassAmazon.Pages
{
    public class OrderModel : PageModel
    {
        private IBookstoreRepository repo { get; set; }
        public OrderModel(IBookstoreRepository temp, Cart c)
        {
            repo = temp;
            cart = c;
        }
        public Cart cart { get; set; }
        public string ReturnUrl { get; set; }
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
        }

        public IActionResult OnPost(int bookId, string returnUrl)
        {
            Book p = repo.Books.FirstOrDefault(x => x.BookId == bookId);

            cart.AddItem(p, 1);

            return RedirectToPage(new { ReturnUrl = returnUrl });
        }

        public IActionResult OnPostRemove(int bookId, string returnUrl)
        {
            cart.RemoveItem(cart.Items.First(x => x.Book.BookId == bookId).Book);

            return RedirectToPage(new { ReturnUrl = returnUrl });
        }
    }
}
