using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PipelineExample
{
    public class WorldModule : IHttpModule
    {
        public void Init(HttpApplication context)
        {
            context.BeginRequest += (sender, args) => context.Response.Write(" World ");
            context.EndRequest += (sender, args) => context.Response.Write(" World ");
        }

        public void Dispose()
        {

        }
    }
}