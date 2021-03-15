using P03._Database_Before.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P03._Database_Before
{
    class MemoryCourseData : ICourseData
    {

        private List<Course> courses;
        public MemoryCourseData()
        {
            courses = new List<Course>()
            {
                new Course(){Id=5, Name="C# OOP"},
                new Course(){Id=12, Name="Python OOP"},
                new Course(){Id=16, Name="Java OOP"},
                new Course(){Id=5, Name="JavaScript"}
            };
        }
        public IEnumerable<int> CourseIds()
        {
            return courses.Select(c => c.Id);
        }

        public IEnumerable<string> CourseNames()
        {
            return courses.Select(c => c.Name);
        }

        public string GetCourseById(int id)
        {
            return courses.First(c => c.Id == id).Name;
        }
    }
}
