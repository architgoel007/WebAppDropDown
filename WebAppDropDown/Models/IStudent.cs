using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDropDown.Models
{
     public interface IStudent
     {
        Student AddStudent(Student student);
        List<Student> GetStudents();
        bool DeleteStudent(int Id);
        List<Course> GetCourses();
     }
}
