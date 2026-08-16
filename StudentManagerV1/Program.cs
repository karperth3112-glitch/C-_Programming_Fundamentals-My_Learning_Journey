using StudentManagerV1.Entities;
// Có thể dùng Alt + Enter để Visual Studio tự thêm using

namespace StudentManagerV1;

class Program
{
    static void Main(string[] args)
    {
        // =====================================================
        // CÁCH 1 – KHAI BÁO RÕ KIỂU Student
        // =====================================================

        Student s1 = new Student("SE1", "Anh",9.8,yob: 2000);

        /*
            Student       s1       =       new Student(...)
               ↓           ↓                  ↓
           data type      biến              tạo Object

            Student = kiểu dữ liệu / Class
            s1      = biến reference
            new     = tạo Object mới

            Object được tạo trong Heap.
            s1 giữ reference để truy cập Object.

            Muốn giao tiếp với Object → dùng dấu "."
        */

        Console.WriteLine("S1 show profile ...");

        s1.ShowProfile();


        Console.WriteLine("--------------------------------");


        // =====================================================
        // CÁCH 2 – TẠO OBJECT + TOSTRING()
        // =====================================================

        Student s2 = new Student("SE2","Bong",gpa: 8.9,yob: 2000);

        /*
            Named Argument:

            gpa: 8.9
            yob: 2000

            Giúp biết rõ giá trị đang truyền vào Parameter nào.
        */

        Console.WriteLine("S2 show profile ...");


        // Cách 1: gọi ToString() trực tiếp

        Console.WriteLine(s2.ToString());


        // Cách 2: không cần ghi .ToString()

        Console.WriteLine(s2);


        /*
            Tại sao Console.WriteLine(s2) lại được?

            C# có thể tự gọi:

            s2.ToString()

            nên:

            Console.WriteLine(s2);

            có thể hiểu gần như:

            Console.WriteLine(s2.ToString());

            Vì vậy khi muốn in thông tin Object,
            nên chủ động override ToString() trong Class Student.
        */


        Console.WriteLine("--------------------------------");
        // =====================================================
        // CÁCH 3 – DÙNG var
        // =====================================================

        var s3 = new Student("SE3","Tong",gpa: 5.9,yob: 2000);

        /*
            var = type inference
                = C# tự suy luận kiểu dữ liệu
            C# nhìn:new Student(...) → biết s3 có kiểu Student.
            Vì vậy: var s3 = new Student(...) tương đương về kiểu với:Student s3 = new Student(...);
        */

        Console.WriteLine("S3 show profile...");

        s3.ShowProfile();

        Console.WriteLine("--------------------------------");

        // =====================================================
        // KIỂM TRA GET
        // =====================================================

        Console.WriteLine("S1 Name: " + s1.GetName());

        Console.WriteLine("S1 GPA: " + s1.GetGpa()); //GetGpa() chỉ trả về giá trị (kiểu double), chứ bản thân nó không có lệnh tự in ra màn hình  neen phai Cw


        Console.WriteLine("--------------------------------");


        // =====================================================
        // KIỂM TRA SET
        // =====================================================

        s1.SetName("An Bình");

        s1.SetGpa(10.0);

        s1.SetYob(2001);


        Console.WriteLine("S1 after SET:");
        // Buoc 1 gọi hàm hiển thị
        s1.ShowProfile();
      

        Console.WriteLine("--------------------------------");


        // =====================================================
        // REFERENCE – 2 BIẾN CÙNG TRỎ 1 OBJECT
        // =====================================================

        Student s4 = s1;

        /*
            s4 KHÔNG tạo Object mới.

            s4 chỉ copy reference của s1.

                  s1 ─────┐
                          ↓
                     ┌───────────────┐
                     │ Student       │
                     │ Object        │
                     │               │
                     │ ID            │
                     │ Name          │
                     │ GPA           │
                     │ YOB           │
                     └───────────────┘
                          ↑
                  s4 ─────┘

            → s1 và s4 cùng tham chiếu đến 1 Object.
        */

        Console.WriteLine("Reference test:");

        s4.SetGpa(7.5);

        // s1 cũng thấy GPA = 7.5
        // vì s1 và s4 cùng trỏ đến một Object.

        Console.WriteLine("s1 GPA: " + s1.GetGpa());
        Console.WriteLine("s4 GPA: " + s4.GetGpa());


        Console.WriteLine("--------------------------------");


        // =====================================================
        // SO SÁNH REFERENCE
        // =====================================================

        Console.WriteLine(s1 == s4);

        /*
            Kết quả:

                True

            Vì s1 và s4 cùng reference đến một Object.
        */


        Console.WriteLine("--------------------------------");


        // =====================================================
        // HAI OBJECT KHÁC NHAU NHƯNG THÔNG TIN CÓ THỂ GIỐNG NHAU T/F
        // =====================================================

        Student s5 = new Student("SE1","Anh Tuan",7.5,2001);

        /*
            s5 là Object mới.

            s1 ─────→ Object A

            s5 ─────→ Object B

            Dù thông tin có thể giống nhau,
            nhưng đây vẫn là 2 Object khác nhau.
        */

        Console.WriteLine("s1 == s5:");

        Console.WriteLine(s1 == s5);

        /*
            Thông thường:

                False

            Vì s1 và s5 không cùng reference.
        */

        Console.WriteLine("--------------------------------");

        Console.WriteLine("CHECK S1 BEFORE CALLING METHOD");
        Console.WriteLine(s1);
        PassAStudent(s1);
        Console.WriteLine("CHECK S1 AFTER CALLLING METHOD");
        Console.WriteLine(s1);

    }

    // BIẾN OBJECT LÀ TRUYỀN OBJECT - BẢN CHẤT LÀ PASS BY VALUE - *PASS BY REFERENCE||* (MÀ KO CẦN REF, OUT)
    static void PassAStudent(Student x)
    {
        x.SetGpa(3.0); // x là biến object //nó sẽ lưu toạ độ 1 vùng new 
                       // 2 chàng trỏ 1 chỗ
                       // x và biến đưa vào -> cùng trỏ 1 vùng new 
                       // x sửa gì vùng new qua x.Set(...)
                       //thì vùng new bên ngoài của biến đưa vào cũng bị sửa luôn
                       // TRUYỀN BIẾN OBJECT QUA HÀM BẢN CHẤT LÀ TRUYỀN THAM CHIẾU MÀ KHÔNG CẦN REF / OUT
                       // TRONG HÀM SỬA BÊN NGOÀI CŨNG BỊ ẢNH HƯỞNG -CHIẾU -REFERENCE 

                        
    }
}

