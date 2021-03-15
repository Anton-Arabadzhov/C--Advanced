using P03._Database;
using System;

namespace P03._Database_Before
{
    class Program
    {
        static void Main(string[] args)
        {
            Courses courses = new Courses(new TextCourseData("../../../coursesData.txt"));

            courses.PrintAll();
            courses.PrintById(5);
            courses.PrintIds();

                 
        }
    }
}
