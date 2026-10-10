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

        }
    }

}