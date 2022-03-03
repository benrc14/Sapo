﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sapo.Infrastructure;
using Sapo.Models;

namespace Sapo.Pages
{
    public class CheckoutModel : PageModel
    {

        private ISapoRepository repo {get; set;}

        
        public CheckoutModel (ISapoRepository temp, Basket b)
        {
            repo = temp;
            basket = b;
        }


        public Basket basket { get; set; }
        public string ReturnUrl { get; set; }

        public void OnGet(string returnUrl)
            {

            ReturnUrl = returnUrl ?? "/";
            //basket = HttpContext.Session.GetJson<Basket>("basket") ?? new Basket();
        }

        public IActionResult OnPost(int bookId, string returnUrl)
        {
            Book b = repo.Books.FirstOrDefault(x => x.BookId == bookId);

            //basket = HttpContext.Session.GetJson<Basket>("basket") ?? new Basket();
            basket.AddItem(b, 1);


            //HttpContext.Session.SetJson("basket", basket);

            return RedirectToPage(new { ReturnUrl = returnUrl });

        }


        public IActionResult OnPostRemove(int bookid, string returnUrl)
        {
            basket.RemoveItem(basket.Items.First(x => x.Book.BookId == bookid).Book);

            return RedirectToPage ( new {ReturnUrl = returnUrl});
        }
    }
}
