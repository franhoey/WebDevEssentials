using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PipelineExample
{
    public class Handler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.Write("<p>Handled Here</p>");
        }

        public bool IsReusable {
            get { return true; }
        }
    }
}