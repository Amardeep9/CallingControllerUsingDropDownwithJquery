using CallingActionFromDropDown.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CallingActionFromDropDown.Controllers
{
    public class DropDownController : Controller
    {

        public ActionResult Index()
        {
            FruitModel obj = new FruitModel();
            List<FruitModel> fruits = PopulateFruits();
           // obj.Fruits = PopulateFruitStronglytyped();
            return View("CallingControUsiDrpList", fruits);

        }



        private static List<FruitModel> PopulateFruits()
        {
            List<FruitModel> fruits = new List<FruitModel>();


            FruitModel obj = new FruitModel();
            obj.FruitName = "Mango";
            obj.FruitId = 1;

            fruits.Add(obj);



            FruitModel obj2 = new FruitModel();
            obj2.FruitName = "Orange";
            obj2.FruitId = 2;
            fruits.Add(obj2);






            return fruits;
        }


        [HttpPost]
        public ActionResult Submit(FormCollection formcollection)
        {
            TempData["Message"] = "Fruit Name: " + formcollection["FruitName"];
            TempData["Message"] += "\\nFruit Id: " + formcollection["FruitId"]; ;
            return RedirectToAction("Index");
        }


        private List<SelectListItem> PopulateFruitStronglytyped()
        {
            List<SelectListItem> items = new List<SelectListItem>();

            SelectListItem obj = new SelectListItem();
            obj.Text = "Mango";
            obj.Value = "1";

            items.Add(obj);



            SelectListItem obj1 = new SelectListItem();
            obj1.Text = "Orange";
            obj1.Value = "2";

            items.Add(obj1);


            return items;
        }
    }
}