using P03._Database_Before.Contracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace P03._Database_Before
{
    class TextCourseData : ICourseData
    {
        private List<Course> courses;
        public TextCourseData(string textLocation)
        {
            using (StreamReader reader = new StreamReader(textLocation))
            {
                var text = reader.ReadLine();
                while (text != null)
                {
                var line = text.Split(",");
                courses.Add(new Course() { Id = int.Parse(line[0]), Name = line[1] });
                    text = reader.ReadLine();
                }
            }
            //courses = new List<Course>()
            //{
            //    new Course(){Id=5, Name="C# OOP"},
            //    new Course(){Id=12, Name="Python OOP"},
            //    new Course(){Id=16, Name="Java OOP"},
            //    new Course(){Id=5, Name="JavaScript"}
            //};
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
