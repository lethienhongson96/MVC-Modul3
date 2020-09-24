using Microsoft.AspNetCore.Mvc;
using SchoolManagement_ThiModul3.Models.Entities;
using SchoolManagement_ThiModul3.Repositories;

namespace SchoolManagement_ThiModul3.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
        public IActionResult Create(Student student)
        {
            int result = studentRepository.CreateStudent(student);

            if (result > 0)
                return RedirectToAction("Index","ClassRoom");

            return View();
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
            int result = studentRepository.EditStudent(student);

            if (result > 0)
                return RedirectToAction("Index", "ClassRoom");

            return View(student);
        }

        public IActionResult Detail(int id)
        {
            return View(studentRepository.GetStudentById(id));
        }
    }
}
