using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace MVC523FromScratch
{
    public class MyCustomHandler : IHttpHandler, System.Web.Routing.IRouteHandler
    {
        public bool IsReusable {
            get { return false; }
        }

        public void ProcessRequest(HttpContext context) {
            context.Response.Write("<html><head><title>hello world!</title></head><body>");
            //context.Response.Write("hello world!");
            foreach (string module in context.ApplicationInstance.Modules.AllKeys) {
                context.Response.Write(module + "<br>");
            }
            context.Response.Write("</body></html>");
        }

        public IHttpHandler GetHttpHandler(System.Web.Routing.RequestContext requestContext) {
            return this; // Here you can do factory and delegate ProcessRequest;
        }
    }

    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e) {
            System.Web.Routing.RouteTable.Routes.Add(new System.Web.Routing.Route("", new MyCustomHandler()));
            // System.Web.IHttpModule
            // System.Web.IHttpHandler            
        }

        //protected void Session_Start(object sender, EventArgs e) {

        //}

        protected void Application_BeginRequest(object sender, EventArgs e) {
            // base.Context.Response.Write("Prueba desde Application_BeginRequest   ");
        }

        //protected void Application_AuthenticateRequest(object sender, EventArgs e) {

        //}

        //protected void Application_Error(object sender, EventArgs e) {

        //}

        //protected void Session_End(object sender, EventArgs e) {

        //}

        //protected void Application_End(object sender, EventArgs e) {

        //}
    }
}