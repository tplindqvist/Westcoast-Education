using System;
using WestcoastEducation.Models;

namespace WestcoastEducation.Interfaces;

public interface ICourseStorage
{
    void Save(List<Course> courses);
    List<Course> Load();
}
