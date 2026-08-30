using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagerV11PropertyAutoBackingField.Entities
{
    public class Student
    {
        //version PROPERTY NGẮN NHẤT NHƯNG KHÔNG DÙNG ĐIỀU KIỆN ĐC
        public int Id { get; set; }// lúc runtime sẽ sinh dùm _id
        public string Name { get; set; } //tự sinh ra giùm backing field _name 
        public int  Yob { get; set; }
        public double Gpa { get; set; }


    }
}
