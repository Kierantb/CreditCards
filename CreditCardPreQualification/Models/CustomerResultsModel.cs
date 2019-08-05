using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CreditCardPreQualification.Models
{
    [Table("CustomerVisit")]
    public class CustomerResultsModel
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String CardResult { get; set; }
    }
}