using System;

namespace WestcoastEducation.Models;

public class Administrator : EducationManager
{

     public Administrator
    (string firstName,
    string lastName,
    int phone,
    string personalNumber,
    string street,
    int zipCode,
    string city,
    string subject,
    DateOnly employmentDate)
    : base
    (firstName, lastName, phone, personalNumber, street, zipCode, city, subject, employmentDate){}

    public override string ToString()
    {
        return $"Administratör: {base.ToString()}";
    }

}
