
using Business.Concrete;
using DataAccess.Concrete.InMemory;

namespace KodlamaioHomePage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CategoryTest();
            TeacherTest();
            //CourseTest();
        }

        private static void CourseTest()
        {
            CourseManager courseManager = new CourseManager(new InMemoryCourseDal());
            foreach (var course in courseManager.GetAll())
            {
                Console.WriteLine(course.CourseName);
            }
        }

        private static void TeacherTest()
        {
            TeacherManager teacherManager = new TeacherManager(new InMemoryTeacherDal());
            foreach (var teacher in teacherManager.GetAll())
            {
                Console.WriteLine(teacher.FirstName + " " + teacher.LastName);
            }
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new InMemoryCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }
    }
}
