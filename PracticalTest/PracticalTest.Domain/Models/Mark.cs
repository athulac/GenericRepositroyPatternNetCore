using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTest.Domain.Models
{
    public class Mark
    {
        public int Id { get; set; }        

        public Student Student { get; set; }
        [ForeignKey("TeacStudenther")]
        public int StudentId { get; set; }
           

        public TeacherSubject TeacherSubject { get; set; }
        [ForeignKey("TeacherSubject")]
        public int TeacherSubjectId { get; set; }


        public int Marks { get; set; }
    }
}
