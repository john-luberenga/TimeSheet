using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TimeSheet.Models
{
    public class UserCases
    {
        [Key]
        public int id { get; set; }
        public int UserID { get; set; }
        public virtual CompanyUser User { get; set; }
        public int Co_identity { get; set; }
        public virtual Companies Companies { get; set; }
    }
}