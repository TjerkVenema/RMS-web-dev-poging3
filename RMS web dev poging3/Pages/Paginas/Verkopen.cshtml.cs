using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RMS_web_dev_poging3.Pages.Models;
using RMS_web_dev_poging3.Pages.Repository;

namespace RMS_web_dev_poging3.Pages.Paginas
{
    public class Verkopen : PageModel
    {
        [BindProperty]
        public List<record> verkoopcollectie { get; set; }
        
        [BindProperty]
        public record verkooprecord { get; set; }


        public void OnPostView()
        {
            int Id = Convert.ToInt32(Request.Cookies["user_id"]);
            verkoopcollectie = RecordRep.GetRecordsByOwner(Id);
            
            int value = Convert.ToInt32(Request.Form["records"]);
            verkooprecord = verkoopcollectie.Single(a => a.record_id == value);

            Response.Cookies.Append("record_id", verkooprecord.record_id.ToString());
            
        }

        public IActionResult OnPostSubmit()
        {
            int record_Id = Convert.ToInt32(Request.Cookies["record_id"]);
            if (record_Id != 0)
            {
                verkooprecord.record_id = record_Id;
                RecordRep.UpdateForSale(verkooprecord);
            }
            Response.Cookies.Delete("record_id");
            return RedirectToPage("/Paginas/MyCollection");
        }
        
        public void OnGet()
        {
            int Id = Convert.ToInt32(Request.Cookies["user_id"]);
            verkoopcollectie = RecordRep.GetRecordsByOwner(Id);
        }
    }
}