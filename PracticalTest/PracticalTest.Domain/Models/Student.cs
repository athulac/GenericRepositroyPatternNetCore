using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTest.Domain.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }


        public School School { get; set; }
        [ForeignKey("School")]
        public int SchoolId { get; set; }



        public Grade Grade { get; set; }
        [ForeignKey("Grade")]
        public int GradeId { get; set; }



        public string Name { get; set; }
        public DateTime Dob { get; set; }
    }
}
