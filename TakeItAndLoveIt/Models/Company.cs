using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace TakeItAndLoveIt.Models
{
    public class Company
    {
        [Key]
        public int CompanyId { get; set; }

        public string CompanyName { get; set; }
        public string PrimaryContact { get; set; }

        [DataType(DataType.EmailAddress)]
        public string PrimaryContactEmail { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PrimaryContactPhone { get; set; }

        public virtual List<Interaction> Interactions { get; set; }
    }
}