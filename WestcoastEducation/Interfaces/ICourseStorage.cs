using System;
using WestcoastEducation.Models;

namespace WestcoastEducation.Interfaces;

// Med interface kan lagringen bytas ut mot en databas senare
public interface ICourseStorage
{
    void Save(List<Course> courses);
    List<Course> Load();
}
