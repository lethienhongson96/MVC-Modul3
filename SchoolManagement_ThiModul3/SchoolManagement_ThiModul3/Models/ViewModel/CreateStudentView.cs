using SchoolManagement_ThiModul3.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagement_ThiModul3.Models.ViewModel
{
    public class CreateStudentView
    {
        [Required(ErrorMessage = "Họ và tên không được để trống !")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Ngày sinh không được để trống !")]
        public DateTime DoB { get; set; }

        public string Gender { get; set; }

        [Required(ErrorMessage = "Email không được để trống !")]
        public string Email { get; set; }

        public int ClassRoomId { get; set; }
    }
}
