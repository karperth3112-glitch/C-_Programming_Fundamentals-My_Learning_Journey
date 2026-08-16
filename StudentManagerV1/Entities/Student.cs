using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagerV1.Entities;

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
    // CONSTRUCTOR
    // Hàm tạo Object – "phễu hứng INFO"
    // =========================================================

    public Student(string id, string name, double gpa, int yob)
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

// Các cách viết tương đương:

// public override string ToString()
// {
//     string k =
//         $"ID: {_id} | Name: {_name} | Gpa: {_gpa} | Yob: {_yob}";
//
//     return k;
// }

// public override string ToString()
//     => $"ID: {_id} | Name: {_name} | Gpa: {_gpa} | Yob: {_yob}";
