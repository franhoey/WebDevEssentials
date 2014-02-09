using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class ConfigExample
    {
        public string ConnectionString
        {
            get { return ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString; }
        }

        public string ConfigData
        {
            get { return ConfigurationManager.AppSettings["MyConfigValue"]; }
        }
    }
}