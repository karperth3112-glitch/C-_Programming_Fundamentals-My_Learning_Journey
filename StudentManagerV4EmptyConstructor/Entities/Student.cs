using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagerV4EmptyConstructor.Entities
{
    public class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;
        // MẶC ĐỊNH NẾU CLASS KHÔNG CÓ CONSTRUCTOR,KHI RUNTIME/RUNTIME SDK/ HOẶC MÁY ẢO SẼ TỰ TẠO DÙM TA 1 CONSTRUCTOR RỖNG/DEFAULT - KO ĐẦU VÀO, KO LỆNH ĐỔ DATA - IMPLICIT CONSTRUCTOR ( NGẦM/ KO TƯỜNG MINH)  
        // BẠN CÓ QUYỀN CHỦ ĐỘNG TẠO CONSTRUCTOR DEFAULT NẾU BẠN THÍCH - EXPLICIT CONSTRUCTOR 

        //public Student() { }
        // gõ : ctor + phím tab . ra đc constructor default 
        public Student()
        {
            
        }

    }
}
