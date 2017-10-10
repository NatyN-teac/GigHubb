using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vudly.Models;

namespace vudly.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable <MembershipType> MembershipTypes { get; set; }
        public Customer Customers { get; set; }
    }
}