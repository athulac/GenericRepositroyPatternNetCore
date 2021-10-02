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
    public class SubjectService : ISubjectService
    {
        private readonly ISubjectRepository subjectRepository;
        private readonly ITeacherSubjectRepository teacherSubjectRepository;

        public SubjectService(ISubjectRepository subjectRepository,
            ITeacherSubjectRepository teacherSubjectRepository)
        {
            this.subjectRepository = subjectRepository;
            this.teacherSubjectRepository = teacherSubjectRepository;
        }

        public async Task<List<Subject>> GetAll()
        {
            var res = await subjectRepository.GetAll();
            if (!res.Any())
            {
                return new List<Subject> { };
            }

            return res.ToList();
        }

        public async Task<List<Teacher>> GetTeachBySubjectId(int subjectId)
        {
            var res = await teacherSubjectRepository.GetTachersBySubject(subjectId);
            if (!res.Any())
            {
                return new List<Teacher> { };
            }

            var resTeachers = res.Select(x => x.Teacher);
            return resTeachers.ToList();
        }
    }
}
