using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}