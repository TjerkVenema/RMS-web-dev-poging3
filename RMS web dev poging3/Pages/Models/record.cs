using System;

namespace RMS_web_dev_poging3.Pages.Models
{
    public class record
    {
        public int record_id { get; set; }
        public int owner { get; set; }
        public string artist { get; set; }
        public string title { get; set; }
        public string label { get; set; }
        public string format { get; set; }
        public char rating { get; set; }
        public DateTime releasedate { get; set; }
        public DateTime dateadded { get; set; }
        public string collection { get; set; }
        public string notes { get; set; }
        public int price { get; set; }
        public bool for_sale { get; set; }
        
    }
}