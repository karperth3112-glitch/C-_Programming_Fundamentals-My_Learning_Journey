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
        Student s2 = new Student();
        Student s3 = new Student();
        
    // set . get, toString , showprofile 
        Console.WriteLine(s1.ToString());
        Console.WriteLine(s2);
        Console.WriteLine(s3);
        


    }
}