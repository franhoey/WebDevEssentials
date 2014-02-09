using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CSVReader.Models;

namespace CSVReader.Controllers
{
    public class BadController : Controller
    {
        //
        // GET: /Bad/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Upload()
        {
            var file = Request.Files["upload"];
            var dragons = new List<Dragon>();

            if (file == null || file.ContentLength == 0)
                return RedirectToAction("Index");

            
            using (var reader = new StreamReader(file.InputStream))
            {
                while (true)
                {
                    var currentDragon = reader.ReadLine();

                    if (string.IsNullOrWhiteSpace(currentDragon))
                        break;

                    var dragonData = currentDragon.Split(',');
                    if (dragonData.Length != 4)
                        break;

                    int age = 0;
                    if (int.TryParse(dragonData[1], out age))
                    {
                        string twitter = dragonData[2];
                        if (!twitter.StartsWith("@"))
                            twitter = string.Concat("@", twitter);

                        dragons.Add(new Dragon()
                            {
                                Name = dragonData[0],
                                Age = age,
                                Twitter = twitter,
                                Type = dragonData[3]
                            });
                    }
                }
            }

            var adultDragons = dragons.Where(d => d.Age > 18).ToList();

            foreach(var dragon in adultDragons.Where(d=> string.IsNullOrWhiteSpace(d.Type)))
            {
                dragon.Type = "Unknown";
            }

            return View(adultDragons);
        }
    }
}
