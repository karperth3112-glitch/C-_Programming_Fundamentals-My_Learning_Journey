namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

 
    public class Student
    {
        // =========================================================
        // FIELD – ĐẶC ĐIỂM / STATE
        // =========================================================

        private string _id;
        private string _name;
        private double _gpa;
        private int _yob;

        // =========================================================
        // CONSTRUCTOR
        // Hàm tạo Object – "phễu hứng INFO"
        // =========================================================

        public Student(string id, string name, double gpa, int yob)
        {
            Id = id;
            Name = name;
            Gpa = gpa;
            Yob = yob;
        }

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public double Gpa { get => _gpa; set => _gpa = value; }
        public int Yob { get => _yob; set => _yob = value; }




        // =========================================================
        // METHOD – HÀNH VI CỦA OBJECT
        // =========================================================

        public void ShowProfile()
        {
            Console.WriteLine("My profile:");

            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Gpa: {Gpa}");
            Console.WriteLine($"Yob: {Yob}");
        }


        // =========================================================
        // TOSTRING()
        // Biểu diễn toàn bộ thông tin Object thành String
        // =========================================================

        public override string ToString()
        {
            return $"ID: {Id} | Name: {Name} | Gpa: {Gpa} | Yob: {Yob}";
        }
    }

    // Các cách viết tương đương:

    // public override string ToString()
    // {
    //     string k =
    //         $"ID: {_id} | Name: {_name} | Gpa: {_gpa} | Yob: {_yob}";
    //
    //     return k;
    // }

    // public override string ToString()
    //     => $"ID: {_id} | Name: {_name} | Gpa: {_gpa} | Yob: {_yob}";

}
