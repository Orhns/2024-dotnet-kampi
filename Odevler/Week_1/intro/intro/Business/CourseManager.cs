using intro.DataAccess.Abstracts;
using intro.DataAccess.Concretes;
using intro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intro.Business;

public class CourseManager
{
    ICourseDal _courseDal;
    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }
    // newlediğimizde ilk classın constructor'ı çalışır.

    public List<Course> GetAll()
    {
        // business rules

        return _courseDal.GetAll();
    }
}
