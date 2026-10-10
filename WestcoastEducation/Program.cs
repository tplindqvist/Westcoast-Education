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
                "19960415-4529",
                "Testgatan 15",
                12345,
                "Stockholm");

                Console.WriteLine(student);
        }
    }

}