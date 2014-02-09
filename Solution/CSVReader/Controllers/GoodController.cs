using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CSVReader.Models;

namespace CSVReader.Controllers
{
    public class GoodController : Controller
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

                        var dragon = ParseDragon(currentDragon);

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

        private Dragon ParseDragon(string dragonRow)
        {
            string[] dragonData;

            if (ValidateDragonData(dragonRow, out dragonData))
            {
                return new Dragon()
                {
                    Name = dragonData[0],
                    Age = int.Parse(dragonData[1]),
                    Twitter = EnsureTwitterHandleFormat(dragonData[2]),
                    Type = ApplyDragonTypeDefaults(dragonData[3])
                };
            }
            
            return null;
        }

        private bool ValidateDragonData(string dragonRow, out string[] dragonData)
        {
            if (string.IsNullOrEmpty(dragonRow))
            {
                dragonData = new string[0];
                return false;
            }

            dragonData = dragonRow.Split(',');
            if (dragonData.Length != 4)
                return false;

            if (!IsValidNumber(dragonData[1]))
                return false;

            return true;
        }

        private bool IsValidNumber(string value)
        {
            int temp;
            return int.TryParse(value, out temp);
        }

        private string EnsureTwitterHandleFormat(string value)
        {
            if (!value.StartsWith("@"))
                return string.Concat("@", value);

            return value;
        }

        private string ApplyDragonTypeDefaults(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                return "Unknown";

            return value;
        }

        private List<Dragon> FilterAdultDragons(List<Dragon> dragons)
        {
            return dragons.Where(d => d.Age > 18).ToList();
        }
    }
}
