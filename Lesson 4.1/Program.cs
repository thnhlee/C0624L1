namespace Lesson_4._1;

class Program
{
    static void Main(string[] args)
    {


        // //////////////////////////////Tính MBI
        // Console.Write("Can nang = ");
        // var weight = Convert.ToDouble(Console.ReadLine());
        // Console.Write("Chieu cao = ");
        // var height = Convert.ToDouble(Console.ReadLine());
        // double BMI = weight/(height*height);

        // Console.WriteLine($" BMI= {BMI}");


        // if(BMI < 18.5)
        // {
        //     Console.WriteLine("Ban bi gay");
        // }
        // else if(BMI > 18 && BMI < 24.9 )
        // {
        //     Console.WriteLine("Ban binh thuong");
        // }
        // else if(BMI > 25 && BMI < 29.9 )
        // {
        //     Console.WriteLine("Tang can");
        // }
        // else if(BMI > 30 && BMI < 34.9 )
        // {
        //     Console.WriteLine("Ban beo phi do 1");
        // }
        // else if(BMI > 35 && BMI < 39.9 )
        // {
        //     Console.WriteLine("Ban beo phi do 2");
        // }
        // else Console.WriteLine("Ban beo phi do 3");







        // //////////////////////////////Tìm số lớn nhất
        // Console.Write("Number_1 = ");
        // var number_1 = Convert.ToInt32(Console.ReadLine());
        // Console.Write("Number_2 = ");
        // var number_2 = Convert.ToInt32(Console.ReadLine());
        // Console.Write("Number_3 = ");
        // var number_3 = Convert.ToInt32(Console.ReadLine());
        // int max = number_1;


        // if (number_2 > max) 
        // {
        //     max = number_2; 
        // }

        // if (number_3 > max) 
        // {
        //     max = number_3; 
        // }







        //////////////////////////////PT  bậc 2
        Console.WriteLine("Dien a, b, c vao phuong trinh ax^2 +  bx + c = 0");

        Console.Write("a = ");
        var a = Convert.ToInt32(Console.ReadLine());
        Console.Write("b = ");
        var b = Convert.ToInt32(Console.ReadLine());
        Console.Write("b = ");
        var c = Convert.ToInt32(Console.ReadLine());

        double delta = b*b - 4*a*c;
        Console.WriteLine($"Delta = {delta}");

        if(a == 0)
        {
            Console.WriteLine($"Phuong trinh co nghiem x= {(-c)/b}");
        }
        else if(delta < 0)
        {
            Console.WriteLine("Phuong trinh vo nghiem");
        }

        else if(delta > 0)
        {
            double x1 = (-b + Math.Sqrt(delta)) / (2*a);
            double x2 = (-b - Math.Sqrt(delta)) / (2*a);
            Console.WriteLine($"Phuong trinh co nghiem x1= {x1}");
            Console.WriteLine($"Phuong trinh co nghiem x2= {x2}");
        }
        else 
        {
            Console.WriteLine($"Phuong trinh co nghiem kep x= {(-b)/2*a}");
        }



    }
}
