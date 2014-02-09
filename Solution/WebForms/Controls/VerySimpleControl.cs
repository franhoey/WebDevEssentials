using System.Web.UI;

namespace WebForms.Controls
{
    public class VerySimpleControl : Control
    {
        public string WhatShouldISay { get; set; }

        protected override void Render(HtmlTextWriter writer)
        {
            writer.Write(string.Format("<h3>I want to say: {0}</h3>", WhatShouldISay));
        }
    }
}