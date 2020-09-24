using SchoolManagement_ThiModul3.Models.Entities;
using SchoolManagement_ThiModul3.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagement_ThiModul3.Repositories
{
    public interface IClassRoomRepository
    {
        List<ClassRoom> classRooms { get; }

        WatchStudentView GetStudentViewById(int id);
    }
}
