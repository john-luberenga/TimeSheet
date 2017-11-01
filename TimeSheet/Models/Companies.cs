using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TimeSheet.Models
{
    
    public class Companies
    {
        [Key]

        public int id { get; set; }

        [Display(Name = "List of Firms")]
        public string CompanyName { get; set; }
        public bool Enabled { get; set; }
    }
}