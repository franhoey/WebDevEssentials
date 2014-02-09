using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CSVReader.Models;
using CSVReader.Models.Factories;

namespace CSVReader.Controllers
{
    public class BestController : Controller
    {
        //
        // GET: /Good/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Upload()
        {
            var dragons = ParseDragonsFromCsvUpload(Request);

            if (dragons == null || dragons.Count == 0)
                return RedirectToAction("Index");

            var adultDragons = FilterAdultDragons(dragons);

            return View(adultDragons);
        }

        private List<Dragon> ParseDragonsFromCsvUpload(HttpRequestBase request)
        {
            var dragons = new List<Dragon>();

            using (var reader = OpenUploadStream(request))
            {
                if (reader != null)
                {
                    while (true)
                    {
                        var currentDragon = reader.ReadLine();

                        if (string.IsNullOrWhiteSpace(currentDragon))
                            break;

                        var dragon = DragonFactory.ParseDragon(currentDragon);

                        if (dragon != null)
                            dragons.Add(dragon);

                    }
                }
            }

            return dragons;
        }

        private StreamReader OpenUploadStream(HttpRequestBase request)
        {
            var file = Request.Files["upload"];

            if (file == null || file.ContentLength == 0)
                return null;

            return new StreamReader(file.InputStream);
        }

        private List<Dragon> FilterAdultDragons(List<Dragon> dragons)
        {
            return dragons.Where(d => d.Age > 18).ToList();
        }
    }
}
