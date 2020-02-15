using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vidly.Controllers
{
    public class ActionController : Controller
    {
        //                ActionResults
       /*  
        *     Type                   HelperMethod
        *     ViewResult              View()
        *     PartialViewResult       PartialView()
        *     ContentResult           Content()
        *     RedirectResult          Redirect()
        *     RedirectToRouteResult   RedirectToAction()
        *     JsonResult              Json()
        *     FileResult              File()
        *     HttpNotFoundResult      HttpNotFound()
        *     EmptyResult             
        */
        public ActionResult TestContent(string name)
        {
            var message = $"Ammar {name}";
            return Content(message);
        }

        public ActionResult NoPage()
        {
            return HttpNotFound();
        }

        public ActionResult EmptyPage()
        {
            return new EmptyResult();
        }

        public ActionResult TestRedirectToAction()
        {
            return RedirectToAction("TestContent", "Action", new { name = "Saleem" });
        }
    }
}