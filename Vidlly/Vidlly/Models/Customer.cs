using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidlly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="please enter customer's name.")]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }

        public  MembershipType MembershipType { get; set; }

        [Display(Name = "Membership Type")]
        public int MembershipTypeId { get; set; }
        [Display(Name = "Date of Birth")]
        [Min18YearIfAMember]
        public DateTime? BirthDate { get; set; }





    }
}