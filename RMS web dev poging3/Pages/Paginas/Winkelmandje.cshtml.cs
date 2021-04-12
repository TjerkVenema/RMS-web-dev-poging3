using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RMS_web_dev_poging3.Pages.Helpers.LearnASPNETCoreRazorPagesWithRealApps.Helpers;

namespace RMS_web_dev_poging3.Pages.Paginas
{
    public class Winkelmandje : PageModel
    {
        public void OnGet()
        {
            List<int> cart = HttpContext.Session.GetObjectFromJson<List<int>>("cart");
        }
    }
}