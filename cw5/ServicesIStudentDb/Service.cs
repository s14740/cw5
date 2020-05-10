using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw5.DTOs.Requests;

namespace cw5.Services
{
    public interface IStudentDbService
    {
        void EnrollStudent(EnrollStudentRequest request);
        void PromoteStudents(int semester, string studies);
    }
}
