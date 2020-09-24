using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolManagement_ThiModul3.Repositories;

namespace SchoolManagement_ThiModul3.Controllers
{
    public class ClassRoomController : Controller
    {
        private readonly IClassRoomRepository classRoomRepository;

        public ClassRoomController(IClassRoomRepository classRoomRepository)
        {
            this.classRoomRepository = classRoomRepository;
        }
        public IActionResult Index()
        {
            return View(classRoomRepository.classRooms);
        }

        public IActionResult WatchStudentsByClassId(int id)
        {
            return View(classRoomRepository.GetStudentsById(id));
        }
    }
}
