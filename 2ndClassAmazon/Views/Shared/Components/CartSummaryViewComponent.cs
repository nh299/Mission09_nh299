﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _2ndClassAmazon.Models;
using Microsoft.AspNetCore.Mvc;
namespace SportsStore.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Cart cart;
        public CartSummaryViewComponent(Cart cartService)
        {
            cart = cartService;
        }
        public IViewComponentResult Invoke()
        {
            return View(cart);
        }
    }
}