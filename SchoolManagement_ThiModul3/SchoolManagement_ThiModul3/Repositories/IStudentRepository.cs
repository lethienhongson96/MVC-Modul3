using SchoolManagement_ThiModul3.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagement_ThiModul3.Repositories
{
    public interface IStudentRepository
    {
        int CreateStudent(Student student);
        int DeleteStudent(int id);

        Student GetStudentById(int id);

        int EditStudent(Student student);
    }
}
