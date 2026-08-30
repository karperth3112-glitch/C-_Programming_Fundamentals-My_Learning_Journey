using StudentManagerV8PropertyHybrid.Entities;
namespace StudentManagerV8PropertyHybrid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CÁCH 1
            Student s1 = new Student();
            s1.Id = "SE1"; // set từng cháu
            s1.Name = "ALiz"; // cách cũ giống Java: s1.SetName("ALiz"); 
            s1.Yob = 2006;
            s1.Gpa = 9.5;

            Console.WriteLine("s1 details..." + s1.ToString());
            // hoặc gọn hơn
            Console.WriteLine("s1 details..." + s1);

            //CÁCH 2
            Student s2 = new Student()
            {
                Id = "SE1",
                Name = "Baifern",
                Yob = 2008,
                Gpa = 8.9
            };
            // thoải mái đưa/set property theo bất kỳ thứ tự - ko nhầm với name-argument  (Student s4 = new Student("SE4", "Eli Sophia", 2002, 3.4);
            // ctrl + K+ D : để xuống dòng đẹp 
            Console.WriteLine("s2 details: " + s2);
            
            // C2: STYLE VIẾT CHUẨN - NEW OBJECT KÈM SET() VALUE PROPERTY 
            // KĨ THUẬT NEW QUA SET() PROPERTY ĐƯỢC GỌI LÀ:
            //=> OBJECT INITIALIZER - TẠO OBJECT VÀ KHỞI ĐỘNG LUÔN ĐẶC TÍNH 

        }
    }
}
