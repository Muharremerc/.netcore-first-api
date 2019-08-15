using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StCourse.Model
{
    public class Student
    {
      
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter Name")]
        [Phone(ErrorMessage ="Enter Phone")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Select item")]
        public bool? WillAttend { get; set; }
    }
}
