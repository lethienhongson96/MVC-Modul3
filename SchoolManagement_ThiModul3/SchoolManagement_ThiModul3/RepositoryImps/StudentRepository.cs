using SchoolManagement_ThiModul3.Models;
using SchoolManagement_ThiModul3.Models.Entities;
using SchoolManagement_ThiModul3.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagement_ThiModul3.RepositoryImps
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext context;

        public StudentRepository(AppDbContext context)
        {
            this.context = context;
        }
        public int CreateStudent(Student student)
        {
            context.Add(student);
            return context.SaveChanges();
        }

        public int DeleteStudent(int id)
        {
            var student = context.Students.FirstOrDefault(el => el.Id == id);
            context.Remove(student);
            return context.SaveChanges();
        }

        public int EditStudent(Student student)
        {
            if (context.Students.Contains(student))
                context.Update(student);
                
            return context.SaveChanges();
        }

        public Student GetStudentById(int id) => context.Students.FirstOrDefault(el => el.Id == id);
    }
}
