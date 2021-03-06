﻿using Microsoft.AspNetCore.Mvc;
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
            return View(classRoomRepository.ClassRooms);
        }

        public IActionResult WatchStudentsByClassId(int id) => View(classRoomRepository.GetStudentViewById(id));
    }
}
