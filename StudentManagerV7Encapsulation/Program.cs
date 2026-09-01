using StudentManagerV7Encapsulation.Entities;
namespace StudentManagerV7Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayWithGetSetWithouEncapsulation(); 
        }

        static void PlayWithGetSetWithouEncapsulation()
        {
            Student s1= new Student();
            //Get()
            Console.WriteLine("GET: Id= " + s1.Id);
            Console.WriteLine("GET: Yob= " + s1.Yob);

            //Set() 
            s1.Yob = 2006; //change value 
            Console.WriteLine("GET: Yob= " + s1.Yob);
            Console.WriteLine("GET: Yob= " + s1.Yob);
        }









        //---------------------------------------------------
        // KHẢO SÁT GET -LẤY INFOR CỦA 1 BIẾN  | SET - THAY ĐỔI INFOR 1 BIẾN
        // THỰC RA KHI KHAI BÁO 1 BIẾN , LÀ TA ĐÃ DÙNG SET()/ GET() TRỰC TIẾP, KHỎI CẦN HÀM

        static void PlayWithGetSet()
        {
            int yob = 2000; //local variable 
            // dùng tên biến là có value, lấy đi,mà sài 
            Console.WriteLine("Get yob|"+ yob);

            int age = 2026 - yob;
            Console.WriteLine("Get age|" + age);


            //SET - THAY ĐỔI ĐIỀU GÌ ĐÓ
            yob = 2004; //hỏi -get yob đang là mấy again 
            Console.WriteLine("Get yob (again - after setting) " + yob) ;
            //biến =value nào đố , chính là set , tức LÀ THAY ĐỔI VALUE CỦA 1 BIẾN , BIÉN ĐC ĐỔI VALUE QUA = 


        }
    }
}
// CHỐT HẠ : TÊN BIẾN LÀ ĐẠI DIỆN CHO VALUE NÀO ĐÓ Ư
//              LẤY TÊN BIẾN LÀ TA CÓ ĐƯỢC VALUE , TÊN BIÉN THAM GIA VÀO BIỂU THỨC 
//              CHÍNH LÀ GET VALUE CỦA BIẾN
//
// 1. TÊN BIẾN CHÍNH LÀ VALUE - CHÍNH LÀ GET -TỨC LÀ LẤY GTRI VÀ RETURN GIATR
// 2. TÊN BIẾN =VALUE - CHÍNH LÀ SET - TỨC LÀ THAY ĐỔI GTRI CUA BIẾN

// TÊN BIẾN ĐÃ MANG THEO 2 Ý NGHĨA GET SET TUỲ CÁCH DÙNG 
// TÊN ĐỨNG MÌNH ÊN - GET ()
// TÊN =     VALUE - SET () 
