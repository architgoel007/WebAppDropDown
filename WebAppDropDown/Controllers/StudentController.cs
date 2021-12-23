using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppDropDown.Models;
using WebAppDropDown.Models.ViewModel;

namespace WebAppDropDown.Controllers
{
    public class StudentController : Controller
    {
        internal IStudent Student { get; }
        public StudentController(IStudent student)
        {
            Student = student;
        }

        public IActionResult Index()
        {
            var stu = Student.GetStudents();
            var cor = Student.GetCourses();
            StudentCourse obj = new StudentCourse();
            obj.students = stu;
            obj.courses = cor;
            return View(obj);
        }
        public IActionResult Create()
        {
            var stds = Student.GetCourses();
            ViewBag.Course = stds;
            return View();
        }

      [HttpPost]
        public IActionResult Create(Student student)
        {
            Student.AddStudent(student);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int Id)
        {
            
            return RedirectToAction("Index");
        }
    }
}
