using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using RMS_web_dev_poging3.Pages.Models;

namespace RMS_web_dev_poging3.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public RedirectToPageResult OnGet()
        {
            int userid = Convert.ToInt32(Request.Cookies["user_id"]);
            if (userid != 0)
            {
                return RedirectToPage("/Paginas/MyCollection");
            }

            return null;
        }
    }
}