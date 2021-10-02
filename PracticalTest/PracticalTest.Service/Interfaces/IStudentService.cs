using PracticalTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTest.Service.Interfaces
{
    public interface IStudentService
    {
        Task<List<Student>> GetByGrade(Grade grade);
    }
}
