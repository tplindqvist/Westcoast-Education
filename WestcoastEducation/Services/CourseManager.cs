using System;
using WestcoastEducation.Models;

namespace WestcoastEducation.Services;

public class CourseManager
{
    public List<Course> Courses { get; set; }
    public List<Student> Students { get; set; }
    public CourseManager()
    {
        Courses = new List<Course>();
        Students = new List<Student>();
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
    public void AddStudent(Student student)
    {
        if (Students.Contains(student))
        {
            Console.WriteLine("Student finns redan!");
        }
        else
        {
            Students.Add(student);
        }
    }

    public void ListCourses()
    {
        foreach (Course course in Courses)
        {
            Console.WriteLine(course);
        }
    }
    public void ListStudents()
    {
        foreach (Student student in Students)
        {
            Console.WriteLine(student);
        }
    }

}
