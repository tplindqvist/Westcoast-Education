using System;

namespace WestcoastEducation.Models;

public class Course
{
    public string CourseNumber { get; set; }
    public string Title { get; set; }
    public int LengthInWeeks { get; set; }
    public DateOnly StartDate { get; set; }
    public DateOnly EndDate { get; set; }
    public CourseType CourseType { get; set; }

    public Course(
        string courseNumber,
        string title,
        int lengthInWeeks,
        DateOnly startDate,
        DateOnly endDate,
        CourseType courseType)
    {
        CourseNumber = courseNumber;
        Title = title;
        LengthInWeeks = lengthInWeeks;
        StartDate = startDate;
        EndDate = endDate;
        CourseType = courseType;
    }

    private string GetCourseTypeText()
    {
        if (CourseType == CourseType.Classroom)
        {
            return "Klassrum";
        }
        else
        {
            return "Distans";
        }
    }

    public override string ToString()
    {
        return $"Course: {CourseNumber}, {Title}, {LengthInWeeks}, {StartDate:yyyy-MM-dd} - {EndDate:yyyy-MM-dd}, {GetCourseTypeText()}";
    }

}
