using StudentManagerV2MultipleConstructors.Entities;

namespace StudentManagerV2MultipleConstructors
{
    public class Program

    {
        static void Main(string[] args)
        {
            //int xxx;
            //Console.WriteLine(xxx);
            // biến khai bao kgan value --> loi NGAY LUC GO VI LAY RAC TRONG RAM 

            var s3 = new Student("SE3", "David"); 
            Console.WriteLine("se3 detail with default values inside ");
            Console.WriteLine(s3); // toString 

            // cobnh constructor co bay nhieu cach new 
            // gia tri default neu ko dien du info - ko mang rac nhu bien local 

            s3.SetYob(1987);
            s3.SetGpa(10);
            Console.WriteLine(" student's details after setting");
            Console.WriteLine(s3);
            // ham GET /SET GOI THOAI MAI , N LAN TREN TUNG OBJECT MA HAM KHONG TAO VUNG NEW MOI
            // NO CHI CHINH SUA INFO CUA OBJ , VUNG NEW DA TUNG TAO TRUOC DO 
            Student s4 = new Student("SE4", "Eli", 2002, 3.4);

        }
    }
}
