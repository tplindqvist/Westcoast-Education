using System;

namespace WestcoastEducation.Models;

public class Teacher : Person
{
    public string Subject { get; set; }

    public Teacher
    (string firstName,
    string lastName,
    int phone,
    string personalNumber,
    string street,
    int zipCode,
    string city,
    string subject)
    : base
    (firstName, lastName, phone, personalNumber, street, zipCode, city)
    {
        Subject = subject;
    }

    public override string ToString()
    {
        return $"Teacher: {base.ToString()} | Ämne: {Subject}";
    }
}
