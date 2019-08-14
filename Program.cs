using System;
using SchoolEntity;
using Type = SchoolEntity.Type;

namespace ETAPA1
{
    class Program
    {
        static void Main(string[] args)
        {
            var school = new School("school", 2000, Type.HighSchool);
            school.city = "Medellín";
            school.country = "Colombia";
            school.types = Type.Garden;

            school.courses = new Course[] {
                new Course() {
                name = "101"
                },
                new Course() {
                name = "201"
                },
                new Course() {
                name = "301"
                }
            };

            printCourses(school.courses);
        }

        public static void printCourses(Course[] courses)
        {
            Console.WriteLine("================");
            Console.WriteLine("     SCHOOL     ");
            Console.WriteLine("================");
            foreach (var course in courses)
            {
                Console.WriteLine($"{course.name}, {course.id}");
            }
        }
    }
}
