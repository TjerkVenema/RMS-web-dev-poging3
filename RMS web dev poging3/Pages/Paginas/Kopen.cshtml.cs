using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RMS_web_dev_poging3.Pages.Models;
using RMS_web_dev_poging3.Pages.Repository;

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
    }
}