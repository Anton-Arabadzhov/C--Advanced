using P03._Database_Before.Contracts;

namespace P03._Database
{
    public class Courses
    {
        private ICourseData coursesDatabase;

        public Courses(ICourseData courseData)
        {
            coursesDatabase = courseData;
        }


        public void PrintAll()
        {
            var courses = coursesDatabase.CourseNames();
            System.Console.WriteLine(string.Join(',', courses));
        }

        public void PrintIds()
        {
            var coursesIds = coursesDatabase.CourseIds();
            System.Console.WriteLine(string.Join(',', coursesIds));
        }

        public void PrintById(int id)
        {
            var coursesByIds = coursesDatabase.GetCourseById(id);
            System.Console.WriteLine(coursesByIds);
        }

        
    }
}
