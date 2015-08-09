using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DanielOramTradeMeSimple.Models
{
    public class DanielOramsListingViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public bool Featured { get; set; }
        public int Price { get; set; }
    }
}