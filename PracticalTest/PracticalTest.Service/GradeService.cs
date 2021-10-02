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
    public class GradeService : IGradeService
    {
        private readonly IGradeRepository gradeRepository;

        public GradeService(IGradeRepository gradeRepository)
        {
            this.gradeRepository = gradeRepository;
        }

        public async Task<List<Grade>> GetAll()
        {
            var res = await gradeRepository.GetAll();
            if (!res.Any())
            {
                return new List<Grade> { };
            }

            return res.ToList();
        }
    }
}
