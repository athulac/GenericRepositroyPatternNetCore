using PracticalTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTest.Service.Interfaces
{
    public interface ISubjectService
    {
        Task<List<Subject>> GetAll();
        Task<List<Teacher>> GetTeachBySubjectId(int subjectId);
    }
}
