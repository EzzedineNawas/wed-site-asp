using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestMVC.Models
{
    public class car
    {
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string work { get; set; }
        [Required]
        public int phone { get; set; }
    }
}