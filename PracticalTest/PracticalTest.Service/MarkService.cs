using PractialTest.Repository;
using PractialTest.Repository.Repositories;
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
    public class MarkService : IMarkService
    {
        private readonly IMarkRepository markReposity;
        private readonly ITeacherSubjectRepository teacherSubjectRepository;

        public MarkService(IMarkRepository markReposity,
            ITeacherSubjectRepository teacherSubjectRepository)
        {
            this.markReposity = markReposity;
            this.teacherSubjectRepository = teacherSubjectRepository;
        }

        public async Task<List<Mark>> GetAll()
        {
            var res = await markReposity.GetAll();
            if (!res.Any())
            {
                return new List<Mark> { };
            }

            return res.ToList();
        }

        public async Task<Mark> Add(Mark mark)
        {
            var teaSub = await teacherSubjectRepository.GetTachersBySubject(mark.TeacherSubject.SubjectId, mark.TeacherSubject.TeacherId);
            if (!teaSub.Any())
            {
                return new Mark { };
            }

            var modelMapped = new Mark
            {
                TeacherSubjectId = teaSub.First().Id,
                StudentId = mark.StudentId,
                Marks = mark.Marks,
            };
            var res = await markReposity.AddAsync(modelMapped);
            if (res == 0)
            {
                return new Mark { };
            }

            return mark;
        }
     
    }
}
