using CreditCardPreQualification.Models;
using CreditCardPreQualification.View_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CreditCardPreQualification.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Apply()
        {
            ViewBag.Message = "Apply for credit card.";

            return View();
        }

        public ActionResult Results()
        {
            ViewBag.Message = "Results";
            var results = CustomerRepository.GetCustomerResults().FirstOrDefault(); // normally would use customer id to get result
   
            CustomerResultsViewModel model = new CustomerResultsViewModel();
            model.FirstName = results.FirstName;
            model.CardResult = results.CardResult;

            // get results and send model to view

            return View(model);
        }
    }
}