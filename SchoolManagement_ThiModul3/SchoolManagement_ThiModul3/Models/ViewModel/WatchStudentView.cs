using SchoolManagement_ThiModul3.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagement_ThiModul3.Models.ViewModel
{
    public class WatchStudentView
    {
        public int ClassId { get; set; }
        public List<Student> students { get; set; }
    }
}
