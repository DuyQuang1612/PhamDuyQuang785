using System.IO.Enumeration;
using System.IO;
using System.Security.AccessControl;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace PhamDuyQuang785.Models
{
    public class PDQ0785
    {   [Key]
         [StringLength(20)] 
         [Display(Name = "ID PDQ")]
        public string PDQid { get; set; }
        [Display(Name = "Tên ")] 
         [StringLength(50)]
         public string PDQName { get; set; }
         [Display(Name = "Giới tính")] 
         public string PDQgender { get; set; }
    }
}