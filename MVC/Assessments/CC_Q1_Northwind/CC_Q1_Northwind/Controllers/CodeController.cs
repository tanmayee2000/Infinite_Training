using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CC_Q1_Northwind.Controllers
{
    public class CodeController : Controller
    {
        public NorthwindEntities db = new NorthwindEntities();
        // GET: Code
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Cust_Germany()
        {
            var cust = db.Customers
                      .Where(c => c.Country == "Germany").ToList();
            return View(cust);
        }

        public ActionResult GetCustomerDetails()
        {
            var customer = db.Orders
                          .Where(o => o.OrderID == 10248)
                          .Select(o => o.Customer)
                          .FirstOrDefault();

            return View(customer);
        }
    }
}