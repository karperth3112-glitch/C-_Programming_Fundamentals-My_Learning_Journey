using System;
using System.Collections.Generic;
using System.Text;

namespace StudentMangerV9Property.Entities
{
    public  class Student
    {
        //VERSION PROPERTY GỌN GÀN HƠN 
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;
        // Get()/ Set() theo style hybrid - property 
        // 
        public string Id
        {
            get => _id; 
            set => _id = value; 

        }
        public string Name { get => _name; set => _name = value;}
        public int Yob
        {
            get =>  _yob; 
            set => _yob = value; 
        }
        public double Gpa
        {
            get => _gpa; 
            set => _gpa = value; 
        }




    }
}
