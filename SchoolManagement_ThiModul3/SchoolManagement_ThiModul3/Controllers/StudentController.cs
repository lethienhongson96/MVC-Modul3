using Microsoft.AspNetCore.Mvc;
using SchoolManagement_ThiModul3.Models.Entities;
using SchoolManagement_ThiModul3.Models.ViewModel;
using SchoolManagement_ThiModul3.Repositories;

namespace SchoolManagement_ThiModul3.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository studentRepository;
        private readonly IClassRoomRepository classRoomRepository;

        public StudentController(IStudentRepository studentRepository, IClassRoomRepository classRoomRepository)
        {
            this.studentRepository = studentRepository;
            this.classRoomRepository = classRoomRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create(int id) => View(new CreateStudentView { ClassRoomId = id });

        [HttpPost]
        public IActionResult Create(CreateStudentView createStudentView)
        {
            if (ModelState.IsValid)
            {
                Student student = new Student()
                {
                    ClassRoomId = createStudentView.ClassRoomId,
                    FullName = createStudentView.FullName,
                    DoB = createStudentView.DoB,
                    Email = createStudentView.Email,
                    Gender = createStudentView.Gender
                };
                if (studentRepository.CreateStudent(student) > 0)
                {
                    var ModelForWatchStudentsByClassIdView = classRoomRepository.GetStudentViewById(student.ClassRoomId);
                    return View("Views/ClassRoom/WatchStudentsByClassId.cshtml", ModelForWatchStudentsByClassIdView);
                }
            }
            return View(createStudentView);
        }

        [Route("/Student/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            return Json(studentRepository.DeleteStudent(id));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(studentRepository.GetStudentById(id));
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                int result = studentRepository.EditStudent(student);
                var ModelForWatchStudentsByClassIdView = classRoomRepository.GetStudentViewById(student.ClassRoomId);

                if (result > 0)
                    return View("Views/ClassRoom/WatchStudentsByClassId.cshtml", ModelForWatchStudentsByClassIdView);
            }
            return View(student);
        }

        public IActionResult Detail(int id)
        {
            return View(studentRepository.GetStudentById(id));
        }
    }
}
