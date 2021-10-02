using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTest.Domain.Models
{
    public class Grade
    {
        [Key]
        public int Id { get; set; }
        public int Name { get; set; }

    }
}
