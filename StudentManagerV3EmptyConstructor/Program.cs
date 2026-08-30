namespace StudentManagerV3EmptyConstructor ;

using StudentManagerV3EmptyConstructor.Entities;

class Program
{
    static void Main(string[] args)
    {
        // nếu  class không có constructor 
        // ta vẫn luôn khuôn ra đúc, đúc được 1 object empty ~ object chứa ko khí bên trong 
        // giống đi photo 1 cái form , chưa điền gì cả
        // java,c# provide cho bạn1 cái constructor empty , ko đầu vào giúp mô tả hành động đúc 1 object mang giá trị default 
        
        //object trống trơn , giống tờ giấy form trống
        //điền từ từ sau , tương ứng hàm Set()
        //Set() đến đâu ta xem đến đó, hàm Get()
        //obj luôn được tạo ra
        
        Student s1 = new Student(); //constructor tự sinh ra 

        // set . get, toString , showprofile 
        Console.WriteLine(" Check s1 object BY USING EMPTY CONSTRUCTOR ");
        Console.WriteLine(s1.ToString());  // CÁCH IN 1 
        Console.WriteLine(s1); // gọi tostring  // CÁCH 1 -2 

        s1.ShowInfo(); // CÁCH IN 2 


        Console.WriteLine(" CHECK s1 object AFTER SETTING ");
        s1.SetName("Jessie Tran ");
        s1.SetYob(2000);
        s1.SetYob(2015);
        s1.ShowInfo();
        Console.WriteLine(s1.ToString());
        Console.WriteLine(s1);






    }
}