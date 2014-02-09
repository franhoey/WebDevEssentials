using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class DemoController : Controller
    {
        //
        // GET: /Demo/
        
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Simple(int id)
        {
            return View(id);
        }

        public ActionResult Template()
        {
            return View();
        }

        public ActionResult Complex(int id, string value)
        {
            return View(new ComplexData() {Id = id, Value = value});
        }

        public ActionResult ModelBinding()
        {
            return View(new InterestingDataViewModel(){ Message = "Please enter your data"});
        }
        [HttpPost]
        public ActionResult ModelBinding(InterestingDataViewModel model)
        {
            
            model.Message = "This is what you entered";

            return View(model);
        }

        public ActionResult Library()
        {
            object data = string.Empty;

            var lib = new Library.LibraryData();
            data = lib.GetInformation();

            return View(data);
        }

        public ActionResult Debug()
        {
            var debugger = new DebugExample();
            var returnValue = debugger.Begin();
            return Content(returnValue);
        }

        public ActionResult Config()
        {
            return View(new ConfigExample());
        }


        public ActionResult Css()
        {
            return View();
        }
    }
}
