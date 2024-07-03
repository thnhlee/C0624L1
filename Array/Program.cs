using System;
using System.ComponentModel.DataAnnotations;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
                
            /////////////////////////////////////Nhập 10 số nguyên cho mảng
            double[] numberList = new double[10];
            Console.WriteLine("Nhap diem:");

            for (int i = 0 ; i < numberList.Length; i++)
            {
                Console.Write($"Diem thu {i + 1}: ");
                numberList[i] = double.Parse(Console.ReadLine());
            }


            Console.WriteLine("Toan bo diem:");
            for(int i = 0; i < numberList.Length; i++)
            {
                Console.Write($"{numberList[i]}; ");
            }

            // double DiemLonNhat = numberList.Max();
            // double DiemNhoNhat = numberList.Min();
            double diemLonNhat = numberList[0];
            double diemNhoNhat = numberList[0];

            for(int y = 1; y < numberList.Length; y++)
            {
                if(numberList[y] > diemLonNhat)
                {
                    diemLonNhat = numberList[y];
                }
                
                if(numberList[y] < diemNhoNhat)
                {
                    diemNhoNhat = numberList[y];
                }
            }

            Console.WriteLine($"\nDiem lon nhat: {diemLonNhat}");
            Console.WriteLine($"Diem nho nhat: {diemNhoNhat}");









        }
    }
}