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
                "Stockholm");

                Console.WriteLine(student);

                Teacher teacher = new("Anders", "Andersson", 0701011010, "19640612-5217", "Storgatan 52", 13439, "Karlstad", "Hemkunskap");
                Console.WriteLine(teacher);
        }
    }

}