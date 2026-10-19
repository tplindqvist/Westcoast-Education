using System;
using WestcoastEducation.Interfaces;
using WestcoastEducation.Models;

namespace WestcoastEducation.Services;

public class JsonCourseStorage : ICourseStorage
{
    public string FilePath { get; set; }

    public JsonCourseStorage(string filePath)
    {
        FilePath = filePath;
    }

    public void Save(List<Course> courses)
    {

    }

    public List<Course> Load()
    {
        return new List<Course>();
    }
}
