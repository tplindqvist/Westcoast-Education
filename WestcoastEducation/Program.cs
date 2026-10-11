using System;
using WestcoastEducation.Models;

namespace WestcoastEducation
{
    class Program
    {
        static void Main()
        {
            Student student = new(
                "Test",
                "Testsson",
                0704501010,
                "19960415-4539",
                "Testgatan 15",
                12345,
                "Stockholm"
                );

            Console.WriteLine(student);

            Console.WriteLine("=============================");

            Teacher teacher = new("Anders",
             "Andersson",
              0701011010,
               "19640612-5217",
               "Storgatan 52",
               13439,
               "Karlstad",
               "Hemkunskap"
               );

            Console.WriteLine(teacher);

            Console.WriteLine("=============================");

            EducationManager educationManager = new(
                "Peter",
                "Grandqvist",
                0705010550,
                "19750715-6510",
                "Maximusgatan 13B",
                43941,
                "Surte",
                "Drejning",
                new DateOnly(2026, 1, 2)
                );

                Console.WriteLine(educationManager);

            Console.WriteLine("=============================");
            
            Administrator administrator = new(
                "Admin",
                "Adminsson",
                0701032133,
                "850113-3319",
                "Admingatan 15",
                12456,
                "Karlshamn",
                "None",
                new DateOnly(2024,5, 4)
                );

                Console.WriteLine(administrator);

            Console.WriteLine("=============================");

            Course course = new Course(
                "FS26B",
                "Filosofi",
                40,
                new DateOnly(2026,08,25),
                new DateOnly(2027,06,25),
                CourseType.Remote
            );

            Console.WriteLine(course);
        }
    }

}