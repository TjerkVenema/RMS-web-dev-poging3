using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySqlX.XDevAPI;

using RMS_web_dev_poging3.Pages.Helpers.LearnASPNETCoreRazorPagesWithRealApps.Helpers;
using RMS_web_dev_poging3.Pages.Models;
using RMS_web_dev_poging3.Pages.Repository;
using Session = Renci.SshNet.Session;

namespace RMS_web_dev_poging3.Pages
{
    public class Kopen : PageModel
    {
        [BindProperty]
        public List<record> records { get; set; }
        
        
        public void OnGet()
        {
            records = RecordRep.Get();
        }

        public IActionResult OnGetAddToCart(int id)
        {
            var list = HttpContext.Session.GetObjectFromJson<List<int>>("cart");
            if (list == null)
            {
                List<int> records = new List<int>();
                records.Add(id);
                HttpContext.Session.SetObjectAsJson("cart", records);
            }
            else
            {
                list.Add(id);
                HttpContext.Session.SetObjectAsJson("cart", list);
            }
            
            
            return RedirectToPage("/Paginas/Winkelmandje");
        }
    }
}