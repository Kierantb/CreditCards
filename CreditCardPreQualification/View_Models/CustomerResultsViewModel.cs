using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreditCardPreQualification.View_Models
{
    public class CustomerResultsViewModel
    {
        public string FirstName { get; set; }
        public string CardResult { get; set; }

        public string APR()
        {
            string apr = "";
            if (CardResult == "Barclaycard")
            {
                apr = "5%";
            }
            else if (CardResult == "Vanquis card")
            {
                apr = "4.5%";
            }
            return apr;
        }

        public string PromoMessage()
        {
            string promo = "";
            if (CardResult == "Barclaycard")
            {
                promo = "Collect now for great deals";
            }
            else if (CardResult == "Vanquis card")
            {
                promo = "Collect quickly for better offers";
            }
            return promo;
        }
    }
}