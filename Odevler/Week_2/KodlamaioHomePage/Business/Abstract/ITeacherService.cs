using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITeacherService
    {
        List<Teacher> GetAll();
        void Add(Teacher teacher);
        void Update(Teacher teacher);
        void Delete(Teacher teacher);
        Teacher GetById(int id);
    }
}
