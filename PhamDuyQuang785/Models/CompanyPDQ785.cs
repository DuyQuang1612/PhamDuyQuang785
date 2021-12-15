using System.IO.Enumeration;
using System.IO;
using System.Security.AccessControl;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace PhamDuyQuang785.Models
{
    public class CompanyPDQ785
    {   [Key]
         [StringLength(20)] 
         [Display(Name = "ID công ty")]
        public string CompanyID { get; set; }
         [Display(Name = "Tên công ty")] 
         [StringLength(50)]
         public string CompanyName { get; set; }
    }
}