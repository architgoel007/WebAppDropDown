using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDropDown.Models
{
    public class StudentServices : IStudent
    {
        public ApplicationContext Context { get; }
        public StudentServices(ApplicationContext context)
        {
            Context = context;
        }

        public Student AddStudent(Student student)
        {
            Context.Students.Add(student);
            Context.SaveChanges();
            return student;
        }

        public List<Student> GetStudents()
        {
            return Context.Students.ToList();
        }
        public bool DeleteStudent(int Id)
        {
            if (Context.Students.Any(e => e.Id == Id))
            {
                var stu = Context.Students.SingleOrDefault(e => e.Id == Id);
                Context.Students.Remove(stu);
                Context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public List<Course> GetCourses()
        {
            var cors = Context.Courses.ToList();
            return cors;
        }
    }
}
