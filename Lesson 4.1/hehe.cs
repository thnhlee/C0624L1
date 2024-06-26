// namespace Lesson_4._1;

// class hehe
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Nhập cân nặng (kg): ");
//         double weight = Convert.ToDouble(Console.ReadLine());
        
//         Console.Write("Nhập chiều cao (m): ");
//         double height = Convert.ToDouble(Console.ReadLine());
        
//         PrintBMICategory(CalculateBMI(weight, height));
//     }
    
//     public static double CalculateBMI(double weight, double height)
//     {
//         return weight / (height * height);
//     }
    
//     public static void PrintBMICategory(double bmi)
//     {
//         Console.WriteLine("BMI của bạn là: " + Math.Round(bmi, 2));
//         string category = bmi < 18.5 ? "Gầy" :
//                           bmi < 25 ? "Bình thường" :
//                           bmi < 30 ? "Tăng cân" :
//                           bmi < 35 ? "Béo phì độ 1" :
//                           bmi < 40 ? "Béo phì độ 2" : "Béo phì độ 3";
//         Console.WriteLine("Cấp độ: " + category);

//     }
// }
