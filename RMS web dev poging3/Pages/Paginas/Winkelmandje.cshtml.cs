using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RMS_web_dev_poging3.Pages.Helpers.LearnASPNETCoreRazorPagesWithRealApps.Helpers;
using RMS_web_dev_poging3.Pages.Models;
using RMS_web_dev_poging3.Pages.Repository;

namespace RMS_web_dev_poging3.Pages.Paginas
{
    public class Winkelmandje : PageModel
    {
        [BindProperty]
        public List<record> Records { get; set; }
        
        [BindProperty]
        public float PriceTotal { get; set; }
        
        public void OnGet()
        {
            List<int> cart = HttpContext.Session.GetObjectFromJson<List<int>>("cart");
            if (cart != null)
            {
                Records = RecordRep.GetRecordsInCart(cart);
            }
        }

        public IActionResult OnPostBuy()
        {
            List<int> cart = HttpContext.Session.GetObjectFromJson<List<int>>("cart");
            List<record> records = RecordRep.GetRecordsInCart(cart);
            int buyerId = Convert.ToInt32(Request.Cookies["user_id"]);
            if (cart != null)
            {
                RecordRep.RecordSold(cart, buyerId);
                Record_For_SaleRep.RecordSold(records, buyerId);
            }
            
            HttpContext.Session.Remove("cart");
            return RedirectToPage("/Paginas/MyCollection");
        }
    }
}