using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagement_ThiModul3.Models.Entities
{
    public class ClassRoom
    {
        public int Id { get; set; }
        public string ClassName { get; set; }

        public ICollection<Student> Student { get; set; }
    }
}
