using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagerV5MultipleConstructors.Entities
{
    public class Student
    {
        private string _id;
        private string _name;
        private int _yob;
        private double _gpa;
        //1 class CÓ BAO NHIÊU CONSTRUCTOR LÀ ĐỦ ???
        // -> KO CÓ CÂU TRẢ LỜI, TÙY CÁCH BẠN MUỐN ĐỔ INFO VÀO CÁC FIELDS _
        // FORM ĐĂNG KÝ TRÊN MẠNG CŨNG VẬY : CÓ FIELD (*)  REQUIRED, CÓ FIELD LÀ OPTIONAL 
        //1. NẾU BẠN KO TẠO CONSTRUCTOR RỖNG , VÀ CLASS KO CÓ CONSTRUCTOR NÀO KHÁC  THÌ RUNTIME TỰ TẠO DÙM  (IMPLICIT) 
        // ĐỂ TA NEW ĐC 1 OBJECT CHỨA DEFALUT _FIELD, SAU ĐÓ DÙNG SET() ĐỂ CHỈNH LẠI VALUE 

        //2. TA CÓ THỂ CHÚ ĐỘNG TẠO CONSTRUCTOR RỖNG /DEFAULT NẾU BẠN THÍCH - EXPLICIT CONSTRUCTOR 
        //   TỪ KHOÁ CTOR TAB --> TỰ GENERATE 

        //3. NẾU CLASS CÓ 1 CONSTRUCTOR CÓ THAM SỐ BẤT KỲ (VD ĐỔ DUY NHẤT ID)
        // THÌ RUNTIME TUYỆT ĐÓI KO TẠO DÙM CONSTRUCTOR DEFAULT, LÝ DO:ĐÃ CÓ 1 CÁCH ĐÚC VỪA NÓI RỒI, CẦN J CONSTRUCTOR KHÁC NỮA !!!

        public Student (string id)
        {
            _id=id;
        }

        //public Student(string id, string name) : this(id)
        //{
        //    _name = name;
        //}
        public Student(string id, string name) 
        {
            _id = id;
            _name = name;
        }
        // mẹo TẠO NHANH CONSTRUCTOR CÓ THAM SỐ BẤT KỲ
        // GÕ KEYWORD CTRL. GERENATE CONS



    }
}
