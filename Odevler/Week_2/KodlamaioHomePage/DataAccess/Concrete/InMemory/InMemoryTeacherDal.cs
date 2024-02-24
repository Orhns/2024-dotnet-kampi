using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryTeacherDal : ITeacherDal
    {
        private List<Teacher> _teachers;
        public InMemoryTeacherDal()
        {
            _teachers = new List<Teacher>();
            _teachers.Add(new Teacher() { FirstName= "Engin", LastName= "Demiroğ", Description ="Perfecto hoca", TeacherId=1});
            _teachers.Add(new Teacher() { FirstName= "Orhun", LastName= "Kırkağaç", Description ="Mat hoca", TeacherId=2});
            _teachers.Add(new Teacher() { FirstName= "Doğu", LastName= "Temel", Description ="Lise hoca", TeacherId=3});
        }
        public void Add(Teacher teacher)
        {
            _teachers.Add(teacher);
        }

        public void Delete(Teacher teacher)
        {
            Teacher teacherToDelete = _teachers.SingleOrDefault(c=>c.TeacherId == teacher.TeacherId);
            _teachers.Remove(teacherToDelete);
        }

        public List<Teacher> GetAll()
        {
            return _teachers.ToList();
        }

        public Teacher GetTeacher(int id)
        {
            return _teachers[id];
        }

        public void Update(Teacher teacher)
        {
            Teacher teacherToUpdate = _teachers.SingleOrDefault(c=>c.TeacherId==teacher.TeacherId);
            teacherToUpdate.FirstName = teacher.FirstName;
            teacherToUpdate.LastName = teacher.LastName;
            teacherToUpdate.Description = teacher.Description;
        }
    }
}
