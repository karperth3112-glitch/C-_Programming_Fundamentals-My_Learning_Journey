using System;
using System.Collections.Generic;
using System.Text;

namespace StudentManagerV7Encapsulation.Entities
{ 
    public class Student
    {
        public string Id; // nếu private ..._id
        public string Name;
        public int Yob;
        public double Gpa;

        //ko lam CONSTRUCTOR , DÙNG DEFAULT CONSTRUCTOR , MỌI FIELD (LÚC NÀY LÀ PUBLIC - KO PHẢI PRIVATE) SẼ DEFALUT :SỐ LÀ 0 / BOOL LÀ FALSE/ 
        //VÌ ĐỂ PUBLIC , CHO NÊN TA SẼ CHẠM ĐC 4 BIẾN TRÊN NGAY VÀ LUÔN SAU KHI NEW , MÀ KO CẦN GET () / SET()
        // VÌ CHẠM ĐC BIẾN CHÍNH LÀ GET () / SET()


        // xài GET/SET KHỎI BOLER-PLATE - KO NHÀM CHÁN . NGẮN GỌN !!
        // NHƯNG !!!
        
    }
}
// CHỐT HẠ QUAN TRỌNG - KỐC BÊN JAVA
// TA MUỐN CÓ 1 GIẢI PHÁP THIẾT KẾ CLASS TỐT 
// 1, ĐẢM BẢO TÍNH ĐÓNG GÓI CỦA INFO CỦA OBJECT , TỨC LÀ PRIVATE _ FIELD
// CHE GIẤU INFO TRONG OBJECT - TÍNH ENCAPSULATION

//2. KO CÓ BOILER - PLATE ( CODE VÔ CẢM NHÀM KO TƯ DUY)

//3. KO ĐC PUBLIC CÁC PRIVATE _ FIELD 

//4. GET() / SET() TƯ NHIÊN ,DỄ DÀNG NHƯ XÀI BIẾN OUBLIC Ở BÊN ENCAPSULATION PROJECT , GET ()/ SET() GỌN GÀNG NHƯ BIẾN BÌNH THƯỜNH
//       TÊN BIẾN LÀ GET();  BIẾN = VALUE LÀ SET() 