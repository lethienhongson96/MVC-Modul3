using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagement_ThiModul3.Models.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName{ get; set; }
        public DateTime DoB{ get; set; }
        public string Gender{ get; set; }
        public string Email{ get; set; }

        public int ClassRoomId { get; set; }
        public ClassRoom ClassRoom { get; set; }

    }
}
