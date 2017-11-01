using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TimeSheet.Models
{
    public class UserModel
    {
        [Key]
        public Int32 id { get; set; }
        public int organization_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
    }
}