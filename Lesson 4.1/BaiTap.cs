namespace Lesson_4._1;

class BaiTap
{
    static void Main(string[] args)
    {

        // Console.WriteLine("Dien a, b, c vao phuong trinh ax^2 +  bx + c = 0");

        // Console.Write("a = ");
        // var a = Convert.ToInt32(Console.ReadLine());
        // Console.Write("b = ");
        // var b = Convert.ToInt32(Console.ReadLine());
        // Console.Write("c = ");
        // var c = Convert.ToInt32(Console.ReadLine());

        // double delta = b * b - 4 * a * c;
        // Console.WriteLine($"Delta = {delta}");

        // switch (delta)
        // {
        //     case 0:
        //         Console.WriteLine($"Phuong trinh co nghiem kep x= {(-b) / 2 * a}");
        //         break;
        //     case > 0:
        //         double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
        //         double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
        //         Console.WriteLine($"Phuong trinh co nghiem x1= {x1}");
        //         Console.WriteLine($"Phuong trinh co nghiem x2= {x2}");
        //         break;

        //     default:
        //         Console.Write("Phuong trinh vo nghiem");
        //         break;
        // }


        // //////////////////////////////Tính Diem trung binh
        // Console.Write("Nhap diem trung binh = ");
        // var score = Convert.ToDouble(Console.ReadLine());

        // if( score >= 9 && score <= 10)
        // {
        //     Console.WriteLine("Xuat sac");
        // }
        // else if(score >= 8 && score < 9 )
        // {
        //     Console.WriteLine("Gioi");
        // }
        // else if(score >= 7  && score < 8 )
        // {
        //     Console.WriteLine("Kha");
        // }
        // else if(score >= 5  && score < 7 )
        // {
        //     Console.WriteLine("Trung binh");
        // }
        // else if(score >= 0 &&  score < 5)
        // {
        //     Console.Write("Yeu");
        // }
        // else Console.WriteLine("Invalid score! ");



        //Ternary operator (Toán tử 3 ngôi)
        // bool gender = false;
        // bool married = true;
        // string firstName = "Le";

        // Console.Write($"{(gender ? "Mr" : 
        //                     married ? "Mrs" : "Ms")}. {firstName}");


        //Tìm số lớn nhất bằng toán tử 3 ngôi
        Console.Write("Nhap a: ");
        var a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap b: ");
        var b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap c: ");
        var c = Convert.ToInt32(Console.ReadLine());

        int max = a > b ? (a > c ? a : c) : (b > c ? b : c);
        Console.Write($"So lon nhat la {max}");

    }
}
