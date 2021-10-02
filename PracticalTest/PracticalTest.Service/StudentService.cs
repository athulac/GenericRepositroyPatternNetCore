using PractialTest.Repository.Repositories.Interfaces;
using PracticalTest.Domain.Models;
using PracticalTest.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTest.Service
{
    public class StudentService: IStudentService
    {
        private readonly IStudentRepository studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }

        public async Task<List<Student>> GetByGrade(Grade grade)
        {
            var res = await studentRepository.GetByGrade(grade);
            if (!res.Any())
            {
                return new List<Student> { };
            }

            return res.ToList();
        }
    }
}
