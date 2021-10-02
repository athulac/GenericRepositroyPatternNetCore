using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTest.Domain.Models
{
    public class TeacherSubject
    {
        [Key]
        public int Id { get; set; }
       
        public Teacher Teacher { get; set; }
        [ForeignKey("Teacher")]
        public int TeacherId { get; set; }

      
        public Subject Subject { get; set; }
        [ForeignKey("Subject")]
        public int SubjectId { get; set; }
    }
}
