using System;
using System.Collections.Generic;
using System.Text;

namespace StudentMangerVFinalFantasy.Entities
{
    public class Student
    {
        // quên cách gõ cho version ngắn gọn nhất
        // nó TỰ ĐỘNG GENERATE RA _BACKING FIELD, LOẠI BỎ BOILER PALTE 
        //GÕ : PROP TAB TAB 
        // SAU ĐÓ, SỬA LẠI CHO PHÙ HỢP , RỒI NHẤN ENTER GỢI Ý TIẾP 
        // 
       // public int MyProperty { get; set; }
       public string Id { get; set; }
       public string Name { get; set; }
       public int Yob { get; set; }
       public double Gpa { get; set; }
        // KỸ THUẬT NÀY TRONG C# GỌI LÀ: AUTO - IMPLEMENTED PROPERTY 
        // hậu trường runtime generate ra _backing 


    }
}
