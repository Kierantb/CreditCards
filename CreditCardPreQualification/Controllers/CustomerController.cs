using CreditCardPreQualification.Models;
using CreditCardPreQualification.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CreditCardPreQualification.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitApplication(CustomerViewModel customerViewModel)
        {
            if (customerViewModel.Validate())
            {
                int test = CustomerRepository.AddCustomerResults(1, 1, customerViewModel.FirstName, customerViewModel.LastName, customerViewModel.GetResult());

                return RedirectToAction("Results", "Home"); // Results page
            }
            return RedirectToAction("Apply", "Home");

        }
    }
}