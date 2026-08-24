using System;

namespace StudentManagerV3EmptyConstructor.Entities;

public class Student
{
    private string _id;
    private string _name;
    private double _gpa;
    private int _yob;
    
    public string GetName()
    {
        return _name; 
    }
    public string GetId()
    {
        return _id;
    }
    public double  GetGpa()
        {
        return _gpa;
        }

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetGpa(double gpa)
    {
        _gpa = gpa;
    }
    public void SetYob(int yob)
    {
        _yob = yob; 
    }

    public override string ToString()
    {
        return $"Name: {_name}, Gpa: {_gpa}, Yob: {_yob}"; 
    }

    public void ShowInfo()
    {
        Console.WriteLine("Student's Information");
        Console.WriteLine($"Name: {_name}, Gpa: {_gpa}, Yob: {_yob}");
        
    }
}
