﻿using System;
using Owin;
using Microsoft.Owin;

[assembly: OwinStartup(typeof(MVC523FromScratch.Startup))]

namespace MVC523FromScratch
{
    public class Startup
    {
        public void Configuration(IAppBuilder app) {
            //app.Run(context => {                
            //    context.Response.ContentType = "text/plain";
            //    return context.Response.WriteAsync("Hello World!");
            //});
        }
    }
}