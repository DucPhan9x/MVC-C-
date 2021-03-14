using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using StudentMvc.Models;
using StudentMvc.Services;

namespace StudentMvc.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public IActionResult Index()
        {
            var students = _studentService.GetStudents();

            return View(students);
        }
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult SaveStudent(Student student)
        {
            if (student.Id == 0)
            {
                _studentService.AddNewStudent(student);
            }
            else
            {
                _studentService.EditStudent(student);
            }
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int studentId)
        {
            Student student = _studentService.GetStudentById(studentId);
            return View(student);
        }
        public IActionResult DeleteStudent(int studentId)
        {
            _studentService.DeleteStudent(studentId);
            return RedirectToAction("Index");
        }
    }
}