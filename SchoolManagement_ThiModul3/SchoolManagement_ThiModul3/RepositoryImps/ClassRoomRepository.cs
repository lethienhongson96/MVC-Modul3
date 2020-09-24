using SchoolManagement_ThiModul3.Models;
using SchoolManagement_ThiModul3.Models.Entities;
using SchoolManagement_ThiModul3.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagement_ThiModul3.RepositoryImps
{
    public class ClassRoomRepository : IClassRoomRepository
    {
        private readonly AppDbContext context;

        public ClassRoomRepository(AppDbContext context)
        {
            this.context = context;
        }
        public List<ClassRoom> classRooms => context.ClassRooms.ToList();

        public List<Student> GetStudentsById(int id) => context.Students.ToList().FindAll(el => el.ClassRoomId == id);
    }
}
