using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CallingActionFromDropDown.Models
{
    public class FruitModel
    {
        public List<SelectListItem> Fruits { get; set; }// HTML HELPER - strongly typed  - with for
        public int FruitId { get; set; } // value 
        public string FruitName { get; set; } // Text
    }
}