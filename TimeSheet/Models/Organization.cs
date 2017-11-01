using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TimeSheet.Models
{
    public class Organization
    {
        [Key]
        
        public Int32 id { get; set; }
        public string Name { get; set; }
        public string address { get; set; }
    }
}