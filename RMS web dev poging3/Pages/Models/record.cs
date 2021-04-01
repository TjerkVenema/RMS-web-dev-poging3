using System;
using Microsoft.AspNetCore.Http;

namespace RMS_web_dev_poging3.Pages.Models
{
    public class record
    {
        public int record_id { get; set; }
        public int user_id { get; set; }
        public string artist { get; set; }
        public string title { get; set; }
        public string label { get; set; }
        public string format { get; set; }
        public string rating { get; set; }
        public DateTime releasedate { get; set; }
        public DateTime dateadded { get; set; }
        public string collection { get; set; }
        public string notes { get; set; }
        public float price { get; set; }
        public bool for_sale { get; set; }
        public IFormFile foto { get; set; }
        
    }
}