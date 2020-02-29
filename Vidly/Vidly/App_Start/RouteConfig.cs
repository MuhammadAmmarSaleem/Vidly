using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            /*Custom Routes, specific routes are defined on top of more generic routes. Otherwise generic route will be applied.
             * We can add constraint to route, like year be 4 digits and month be 2 digit.
             */
            /*
             * @ is verbatim string, used to escape character.
             */

            /*
             * Attribte Route: is a cleaner way to define routes, use them instead of Convention Route.
             * To use Attribute route we have to enable them.
             * Code Snippet: 'routes.MapMvcAttributeRoute()';
             */

           // routes.MapMvcAttributeRoutes();

            /*
            routes.MapRoute(
                    name: "MoviesByReleaseDate",
                    url: "movies/released/{year}/{month}",
                    defaults: new { controller = "Movies", action = "ByReleaseDate" },
                    constraints: new { year = @"\d{4}", month = @"\d{2}" }
                );
                */
            
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
