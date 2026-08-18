using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace StudentManagerV2MultipleConstructors.Entities
{
    public class Student
    {
        private string _id;      //__________~ such as space of form 
        private string _name;
        private int _yob;
        private double _gpa;

        public Student(string id, string name) //local variable - là biến khaibao trong function 
        {
            _id = id;
            _name = name;
            //vì sao lại đổ thiếu 2 fields ??? 
        }
        //NẾU 1 OBJECT LÚC ĐC KHỞI TẠO, LÚC ĐƯỢC NEW MÀ KO GÁN/ ĐỔ HẾT VALUE VÀO TRONGG , THÌ CÁC FIELDS KO ĐC ĐỔ SẼ MANG DEFAULT VALUE (KHÁC LOCAL VALUE LÀ MANG RÁC) 
        // NUMBER --> DEFALUT : 0
        // STRING --> NULL
        // BOOL --> FALSE 
        // --> KHONG SO BI CANH BAO SAI CODE VI DUNG RAC 
        //  public override string ToString()
        //{ 
        //    return $"Student's Information/n | ID: {_id} | Name: {_name} | YourOfBirht: {_yob} | GPA: {_gpa}"; 
        //}

        public override string ToString() => $"Student's Information | ID: {_id} | Name: {_name} | YourOfBirht: {_yob} | GPA: {_gpa}";

        //ham showprofile in luon

        public void ShowProfile() => Console.WriteLine(ToString());
    
    
        public string GetName()
        {
            return _name;
        }
        // Ham SET nhan value ben ngoai dat ten bien la gi cung duoc ~ mien co y nghia 
     // public void SetName(string value) => _name = value;
         public void SetName(string name) => _name = name;

        public int GetYob()
        {
            return _yob;
        }
        public void SetYob(int value) => _yob = value;

        public double Getgpa() => _gpa;
        public void SetGpa(double value) => _gpa = value;

    } 
}
