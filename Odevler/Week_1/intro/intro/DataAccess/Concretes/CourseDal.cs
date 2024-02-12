using intro.DataAccess.Abstracts;
using intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro.DataAccess.Concretes
{
    public class CourseDal:ICourseDal
    {
        List<Course> courses;
        public CourseDal()
        {
            Course course1 = new Course();
            course1.Id = 1;
            course1.Name = "C#";
            course1.Description = ".Net 8";
            course1.Price = 0;

            Course course2 = new Course();
            course2.Id = 2;
            course2.Name = "JAVA";
            course2.Description = "JAVA 17";
            course2.Price = 10;

            Course course3 = new Course();
            course3.Id = 3;
            course3.Name = "PYTHON";
            course3.Description = "Python 3.12";
            course3.Price = 0;

            courses = new List<Course>() { course1, course2, course3};
        }
        public List<Course> GetAll()
        {
            // burada db işlemlerini yapıyoruz
            return courses;
        }
        public void Add(Course course)
        {
            courses.Add(course);
        }
    }
}
