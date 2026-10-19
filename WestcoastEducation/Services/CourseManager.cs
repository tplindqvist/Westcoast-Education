using System;
using WestcoastEducation.Models;

namespace WestcoastEducation.Services;

public class CourseManager
{
    public List<Course> Courses { get; set; }
    public CourseManager()
    {
        Courses = new List<Course>();
    }
    public void AddCourse(Course course)
    {
        if (Courses.Contains(course))
        {
            Console.WriteLine("Kurs finns redan!");
        }
        else
        {
            Courses.Add(course);
        }
    }
}
