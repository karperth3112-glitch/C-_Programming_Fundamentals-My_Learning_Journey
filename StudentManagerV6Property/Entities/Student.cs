using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagerV6Property.Entities
{
   public class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;
        // bỏ qua constructor , gọi defalut -> sau đó gọi get()/ set()
        //----------------------------------------------------------
        public string GetId()
        {
            return _id;
        }

        public void SetId(string id)
        {
            _id = id;
        }
        public string GetName()
        {
            return _name;

        }
        public void SetName(string value) 
        {
            _name = value;
        }
        // ta làm tương tư cho _gpa, _yob 




    }
}
