using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreditCardPreQualification.View_Models
{
    public class CustomerViewModel
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime Dob { get; set; }
        public double AnnualIncome { get; set; }

        public bool Validate()
        {
            bool isValid = true;
            return isValid;
        }

        public bool IsOldEnough()
        {
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - Dob.Year; // this is not accurate and does not consider culture
            if (age >= 18)
            {
                return true;
            }
            return false;
        }

        public String GetResult()
        {
            String result = "no credit cards are available"; // result could be a card class object

            if (IsOldEnough() && AnnualIncome > 30000)
            {
                result = "Barclaycard";
            }
            else if (IsOldEnough())
            {
                result = "Vanquis card";
            }

            return result;
        }
    }
}