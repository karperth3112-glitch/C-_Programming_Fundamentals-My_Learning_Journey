using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagerV2MultipleConstructors.Entities;

public class Student
{
    // =========================================================
    // FIELD – ĐẶC ĐIỂM / STATE
    // =========================================================

    private string _id;
    private string _name;
    private double _gpa;
    private int _yob;

    // =========================================================
    // MULTIPLE CONSTRUCTORS
    // Hàm tạo Object – "phễu hứng INFO"
    // =========================================================

    // Constructor with 2 parameters (id, name)
    public Student(string id, string name)
    {
        _id = id;
        _name = name;
        _gpa = 0.0;
        _yob = 0;
    }

    // Constructor with 4 parameters (full)
    public Student(string id, string name, int yob, double gpa)
    {
        _id = id;
        _name = name;
        _gpa = gpa;
        _yob = yob;
    }

    // =========================================================
    // GET – LẤY THÔNG TIN
    // =========================================================

    public string GetName()
    {
        return _name;
    }

    public double GetGpa() => _gpa;

    public int GetYob() => _yob;

    public string GetId() => _id;

    // =========================================================
    // SET – THAY ĐỔI THÔNG TIN
    // =========================================================

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetGpa(double gpa) => _gpa = gpa;

    public void SetYob(int yob)
    {
        _yob = yob;
    }

    public void SetId(string id)
    {
        _id = id;
    }

    // =========================================================
    // METHOD – HÀNH VI CỦA OBJECT
    // =========================================================

    public void ShowProfile()
    {
        Console.WriteLine("My profile:");

        Console.WriteLine($"ID: {_id}");
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Gpa: {_gpa}");
        Console.WriteLine($"Yob: {_yob}");
    }


    // =========================================================
    // TOSTRING()
    // Biểu diễn toàn bộ thông tin Object thành String
    // =========================================================

    public override string ToString()
    {
        return $"ID: {_id} | Name: {_name} | Gpa: {_gpa} | Yob: {_yob}";
    }
}
