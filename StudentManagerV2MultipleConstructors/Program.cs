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
            Student s4 = new Student("SE4", "Eli Sophia", 2002, 3.4);
            //New trả về toạ độ, trả về địa chỉ trong RAM
            //trả về địa chỉ vùng NEW, byte thứ mấy trong 
            //địa chỉ đó đc gán cho s4 , s4 hay gội là con trỏ pointer, points to vùng new
            //s4. tức là vào vùng new, xem ai public ko thì giao tiếp với nó
            //y chang đến 1 căn nhà, bấm chuông, gia chủ có muón ra tiếp không -public hay private 
            s4.ShowProfile(); 
            //định luật dấu bằng -tự bịa để hiểu
            Console.WriteLine("--------------------");
            new Student("SE4" , "Eli", 2002, 3.4).ShowProfile();
            //object anomymous vô danh  - object được tạo ra nhưng ko có biến để gọi - ko có biến để móc vào tham chiếu lâu 
            //không có gọi hàm object nhiều lần
            //=> ta chỉ có cơ hội gọi hàm của nó, vào vùng new chấm đúng 1 lần, vì vừa new là có toạ độ, chấm được ngay
            //sao đó không lưu toạ độ lâu dài , làm sao chấm tiếp, làm gọi hàm tiếp tục
            // vùng ram mà ko có con trỏ móc vào, chơi này mau hết RAM 
            
            //Java và C# có cơ chế giám sát vùng RAM. runtime có 1 đoạn nho nhỏ , định kỳ quét vùng RAM, coi có chỗ nào object ko có con trỏ --> nó clean , đánh dấu vùng ram tự do, để sau này new tiếp ~~ GARBAGE COLLECTOR 
            
            //java 
            //Random rd = new Random(); class sinh ra con số ngẫu nhiên
            // double x = rd.nextDouble() // [0...1) 
            // gangliake
            //double x = new Random().nextDouble(); 
            // làm sao 1 biến đang trỏ mà lại không trỏ
            //-> cho nó trỏ vùng khác / hoặc cho xuống null ,1  biến = null
            //=====
            //NẾU TA MUỐN LOẠI BỎ 1 OBJECT TRONG RAM ~ DẸP1 VÙNG NEW TRONG RAM
            // LOẠI BỎ HẾT CÁC BIẾN TRỎ ĐẾN NÓ
            // = CÁCH : CHO BIẾN TRỎ VÙNG NEW KHÁC HOẶC CHO BIẾN = NULL , TRỎ ĐÁY RAM LÀ XONG 
            s4 = null; // VÙNG NEW TRƯỚC ĐÓ BỊ TRO BỞI S4 ĐÃ MỒ CÔI 
            
            // KHI NÀO DÙNG NULL : RESET BIẾN OBJECT CỦA TA, HOẶC TRẢ VỀ NOTHING KHI SEARCH 1 OBJECT KHÔNG THẤY 
            // THẤY THÌ PHẢI TRỎ VÙNG NEW ĐÃ CÓ !!!





        }
    }
}
