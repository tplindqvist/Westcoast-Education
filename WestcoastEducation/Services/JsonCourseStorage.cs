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
        Directory.CreateDirectory(Path.GetDirectoryName(FilePath)); // Mappen måste finnas innan filen skrivs
        var options = new JsonSerializerOptions { WriteIndented = true };
        string json = JsonSerializer.Serialize(courses, options);
        File.WriteAllText(FilePath, json);
    }

    public List<Course> Load()
    {
        if (!File.Exists(FilePath)) // Filen finns inte vid första körning, den tomma listan förhindrar krasch
        {
            return new List<Course>();
        }

        string json = File.ReadAllText(FilePath);
        List<Course>? courses = JsonSerializer.Deserialize<List<Course>>(json);

        if (courses == null)
        {
            return new List<Course>();
        }

        return courses;
    }
}
