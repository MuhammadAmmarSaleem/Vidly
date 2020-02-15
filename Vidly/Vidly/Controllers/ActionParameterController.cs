using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vidly.Controllers
{
    public class ActionParameterController : Controller
    {
        // GET: ActionParameter
        /*
         * In Url: /movies/edit/1
         * In query string: /movies/edit/?id=1
         * In the form data: id=1
         */
        
            /*
             * Parameter Binding: when the request come to action, MVC frame work automatically map request data
             * to parameter in action. If the parameter and request name are same, MVC framework will pass the value
             *  of request data to parameter.
             */

        public ActionResult Edit(long id)
        {
            return Content("Id = " + id);
        }

        public ActionResult Editing(long Id)
        {
            return Content("Id = " + Id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            //if parameter are null then assign default value.
            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if (string.IsNullOrEmpty(sortBy))
            {
                sortBy = "Name";
            }
            return Content($"pageIndex = {pageIndex} sortBy = {sortBy}");
        }
    }
}