using System;
using WestcoastEducation.Models;

namespace WestcoastEducation.Services;

public class CourseManager
{
    public List <Course>Courses { get; set; }
    public CourseManager()
    {
        Courses = new List<Course>();
    }
}
