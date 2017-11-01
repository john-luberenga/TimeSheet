using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TimeSheet.Models
{
    public class CompanyUser
    {
        [Key]

        public int id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Region { get; set; }

        public string District { get; set; }

        public string Email { get; set; }

        public int Company_ID { get; set; }
        public virtual Companies Companies { get; set; }

        public string Password { get; set; }


    }
}