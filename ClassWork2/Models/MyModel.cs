using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ClassWork2.Models
{
    public class MyModel
    {
        [Required]
        public string RollNo { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public short Marks { get; set; }
    }
}