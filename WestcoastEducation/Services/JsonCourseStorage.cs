using System;
using System.Text.Json;
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
        Directory.CreateDirectory(Path.GetDirectoryName(FilePath));
        var options = new JsonSerializerOptions { WriteIndented = true };
        string json = JsonSerializer.Serialize(courses, options);
        File.WriteAllText(FilePath, json);
    }

    public List<Course> Load()
    {
        return new List<Course>();
    }
}
