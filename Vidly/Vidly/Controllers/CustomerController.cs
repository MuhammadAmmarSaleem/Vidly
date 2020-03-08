using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;
using System.Web.Mvc;
using System.Data.Entity;
using System.Globalization;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        // [Route("/Customer/GetAll")]
        private ApplicationDbContext context;
        public CustomerController()
        {
            this.context = new ApplicationDbContext();
        }
       public ActionResult GetAll()
        {
            /*
            var customers = GetAllCustomers();
            foreach (var customer in customers)
            {
                context.Customers.Add(customer);
                context.SaveChanges();
            }
            */
            var customersList = context.Customers.Include(x => x.MemberShipType).ToList();
            return View("~/Views/Customers/CustomerList.cshtml", customersList);
        }

        public ActionResult Details(long id)
        {
            var customer = context.Customers.Find(id);
            return View("~/Views/Customers/CustomerDetail.cshtml", customer);
        }
        private List<Customer> GetAllCustomers()
        {
            List<Customer> customers = new List<Customer>
            {
                new Customer{Name="Ahmed", IsSubscribedToNewsLetter=true, MemberShipTypeId=3, TotalPurchases = 200, BirthDate = DateTime.ParseExact("1996-02-07", "yyyy-MM-dd", CultureInfo.InvariantCulture)},
                new Customer{Name="Saad", IsSubscribedToNewsLetter=false, MemberShipTypeId=2,  TotalPurchases = 500}
            };
            return customers;
        }
    }
}