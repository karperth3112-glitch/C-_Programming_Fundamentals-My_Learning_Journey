using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagerV8PropertyHybrid.Entities
{
    internal class Student
    {
        private string _id; 
        private string _name;
        private int _yob;
        private double _gpa;

        public string Id
        {
            get { return _id; }
            set { _id = value; }

        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Yob
        {
            get { return _yob; }
            set {
                if (value < 1950) //già quá hay data sai 
                    _yob = 2000;
                else
                    _uob = value; 
                }
        }
        public double Gpa 
        { 
            get { return _gpa; }
            set { _gpa = value; }
        }
        public override string ToString()
        {
            return $"{_id} | {_name} | {_yob} | {_gpa}"; 
        }


        
    }
}
