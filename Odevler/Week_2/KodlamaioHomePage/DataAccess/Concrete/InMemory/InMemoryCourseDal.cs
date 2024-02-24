using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCourseDal : ICourseDal
    {
        private List<Course> _courses;
        public InMemoryCourseDal()
        {
            _courses = new List<Course>()
            {
                new Course(){CourseId = 1, CourseName = "Senior Yazılım Geliştirici Yetiştirme Kampı",CourseDescription = "Senior Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.", CategoryId = 1, TeacherId = 1},
                new Course(){CourseId = 2, CourseName = "Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)",CourseDescription = "2 ay sürecek Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.", CategoryId = 1,TeacherId = 1},
                new Course(){CourseId = 3, CourseName = "(2023) Yazılım Geliştirici Yetiştirme Kampı - Python & Selenium",CourseDescription = "Python & Selenium Yazılım Geliştirici Yetiştirme Kampımızın takip, döküman ve duyurularını buradan yapacağız.", CategoryId = 1,TeacherId = 2}
            };
        }
        public void Add(Course course)
        {
            _courses.Add(course);
        }

        public void Delete(Course course)
        {
            Course courseToDelete = _courses.SingleOrDefault(c => c.CourseId == course.CourseId);
            _courses.Remove(courseToDelete);
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        public Course GetCourse(int id)
        {
            return (Course)_courses[id];
        }

        public void Update(Course course)
        {
            Course courseToUpdate = _courses.SingleOrDefault(c => c.CourseId == course.CourseId);
            courseToUpdate.CourseName = course.CourseName;
        }
    }
}
