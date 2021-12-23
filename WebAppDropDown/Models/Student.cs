using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDropDown.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }
        public String Gender { get; set; }
        public string Image { get; set; }
        public Course MyCourse { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        
    }
}
