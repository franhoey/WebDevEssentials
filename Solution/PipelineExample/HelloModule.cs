using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PipelineExample
{
    public class HelloModule : IHttpModule
    {
        public void Init(HttpApplication context)
        {
            context.BeginRequest += (sender, args) => context.Response.Write(" Hello ");
            context.EndRequest += (sender, args) => context.Response.Write(" GoodBye ");
        }

        public void Dispose()
        {
            
        }
    }
}