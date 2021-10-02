using PracticalTest.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticalTest.Service.Interfaces
{
    public interface IMarkService
    {
        Task<List<Mark>> GetAll();
        Task<Mark> Add(Mark mark);
    }
}
