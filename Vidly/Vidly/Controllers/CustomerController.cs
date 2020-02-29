using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;
using System.Web.Mvc;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
       // [Route("/Customer/GetAll")]
       public ActionResult GetAll()
        {
            List<Customer> customers = GetAllCustomers();
            return View("~/Views/Customers/CustomerList.cshtml", customers);
        }

        public ActionResult Details(long id)
        {
            List<Customer> customers = GetAllCustomers();
            Customer customer = customers.Find(x => x.Id == id);
            return View("~/Views/Customers/CustomerDetail.cshtml", customer);
        }
        private List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer{Id=1, Name="Ammar", IsSubscribedToNewsLetter=true, MemberShipTypeId=1},
                new Customer{Id=2, Name="Umer", IsSubscribedToNewsLetter=false, MemberShipTypeId=2}
            };
            return customers;
        }
    }
}