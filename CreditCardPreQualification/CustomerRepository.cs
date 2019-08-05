using CreditCardPreQualification.Models;
using CreditCardPreQualification.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreditCardPreQualification
{
    public static class CustomerRepository
    {
        public static int AddCustomerResults(int id, int customerId, string firstName, string lastName, string cardResult)
        {
            CustomerResultsModel data = new CustomerResultsModel
            {
                Id = id,
                CustomerId = customerId,
                FirstName = firstName,
                LastName = lastName,
                CardResult = cardResult
            };

            string sql = @"INSERT  into dbo.CustomerVisit (Id, CustomerId, FirstName, LastName, CardResult)
                            values (@Id, @CustomerId, @FirstName, @LastName, @CardResult);";

            return SqlDataAccess.Add(sql, data);
        }

        public static List<CustomerResultsModel> GetCustomerResults()
        {
            string sql = @"SELECT id, CustomerId, FirstName, LastName, CardResult
                            FROM dbo.CustomerVisit;";

            return SqlDataAccess.Get<CustomerResultsModel>(sql);
        }
    }
}