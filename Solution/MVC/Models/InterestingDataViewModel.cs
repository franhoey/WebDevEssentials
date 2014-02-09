using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace MVC.Models
{
    public class InterestingDataViewModel
    {
        public string Message { get; set; }
        public string Name { get; set; }
        public string Colour { get; set; }

        public bool HasData
        {
            get { return !string.IsNullOrEmpty(Name) || !string.IsNullOrEmpty(Colour); }
        }
    }
}