using SchoolManagement_ThiModul3.Models;
using SchoolManagement_ThiModul3.Models.Entities;
using SchoolManagement_ThiModul3.Models.ViewModel;
using SchoolManagement_ThiModul3.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace SchoolManagement_ThiModul3.RepositoryImps
{
    public class ClassRoomRepository : IClassRoomRepository
    {
        private readonly AppDbContext context;

        public ClassRoomRepository(AppDbContext context)
        {
            this.context = context;
        }
        public List<ClassRoom> ClassRooms => context.ClassRooms.ToList();

        public WatchStudentView GetStudentViewById(int id)
        {
            var watchStudentView = new WatchStudentView()
            {
                ClassId = id,
                students = context.Students.Where(el => el.ClassRoomId == id)
                                           .OrderByDescending(el => el.Id)
                                           .ToList()
            };
            return watchStudentView;
        }
    }
}
