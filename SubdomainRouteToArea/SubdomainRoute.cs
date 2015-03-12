using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SubdomainRouteToArea
{
    public class SubdomainRoute : RouteBase
    {
        public override RouteData GetRouteData(HttpContextBase httpContext)
        {
            if (httpContext.Request == null || httpContext.Request.Url == null)
            {
                return null;
            }

            var host = httpContext.Request.Url.Host;
            var index = host.IndexOf(".");

            string[] segments = httpContext.Request.Url.PathAndQuery.TrimStart('/').Split('/');

            if (index < 0)
            {
                return null;
            }

            var subdomain = host.Substring(0, index);
            string[] blacklist = { "www", "test", "mail" }; // 這裡可以設定不用subdomain routing的部分

            if (blacklist.Contains(subdomain))
            {
                return null;
            }

            // url 規則
            // aaa.test.com/M/Index
            // aaa : subdomain
            // M: controller
            // Index: action

            string controller = (segments.Length > 0 && !"".Equals(segments[0])) ? segments[0] : "M";   // 預設controller為M
            string action = (segments.Length > 1 && !"".Equals(segments[1])) ? segments[1] : "Index";   // 預設action為Index

            var routeData = new RouteData(this, new MvcRouteHandler());
            routeData.DataTokens.Add("area", "Wed"); // 綁定 Area
            routeData.Values.Add("controller", controller); //Goes to the relevant Controller  class
            routeData.Values.Add("action", action); //Goes to the relevant action method on the specified Controller
            routeData.Values.Add("subdomain", subdomain); //pass subdomain as argument to action method
            return routeData;
        }

        public override VirtualPathData GetVirtualPath(RequestContext requestContext, RouteValueDictionary values)
        {
            //Implement your formating Url formating here
            return null;
        }


    }
}