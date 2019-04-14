using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestMVC.Models
{
    public class Customer
    {
        public int id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public int age { get; set; }
        [Required]
        public string TypeCar { get; set; }
        [Required]
        public int numCar { get; set; }
        public int model { get; set; }
    }
}