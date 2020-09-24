using SchoolManagement_ThiModul3.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagement_ThiModul3.Repositories
{
    public interface IClassRoomRepository
    {
        List<ClassRoom> classRooms { get; }

        List<Student> GetStudentsById(int id);
    }
}
