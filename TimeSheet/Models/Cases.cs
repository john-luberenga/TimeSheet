using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace TimeSheet.Models
{
    public class Cases
    {
        [Key]
        
        public int id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        
        public Byte[] File { get; set; }

        //public HttpPostedFileBase file { get; set; }

        [Display(Name="Start Date")]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        [Column(TypeName = "DateTime2")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime EndDate { get; set; }

        

    }
}