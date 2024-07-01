using System.ComponentModel;
using System.Globalization;
using System.Linq.Expressions;
using System.Security.Cryptography;

namespace Loops;
class NestedLoop
{
    static void Main(string[] args)
    {
        // int rows = 10, elements = 15;
        // int row = 1;


        ////C1
        // while (row <= rows)
        // {
        //     int element = 1;
        //     do
        //     {
        //         Console.Write("*");
        //         element++;
        //     } 
            
        //     while (element <= elements);
            
        //         Console.Write("\n");
        //         row++;           
        // }



        ////C2
        // do
        // {
        //     int element = 1;
        //     Console.Write($"{row}\t");
        //     do
        //     {
        //         Console.Write("*");
        //         element++;
        //     } 
        //     while (element <= elements);

        //     Console.WriteLine();
        //     row++;
  
        // } 
        // while (row <= rows);




        ////HCN ko có bên trong
        ////C1
        // do
        // {
        //     if (row == 1 || row == rows)
        //     {
                
        //         int element = 1;
        //         do
        //         {
        //             Console.Write("*");
        //             element++;
        //         } while (element <= elements);
        //     }
        //     else
        //     {                
        //         Console.Write("*");
        //         for (int blank = 2; blank < elements; blank++)
        //         {
        //             Console.Write(" ");
        //         }
        //         Console.Write("*");
        //     }
            
        //     Console.WriteLine();
        //     row++;
        // } while (row <= rows);
        




        // //// Vẽ tam giác
        // int elements = 15;
        // for (int row = 1; row <= elements; row++)
        // {
        //     Console.Write($"{row}\t");
        //     for (int element = 1; element <= row; element++)
        //     {               
        //         if (element == 1 || element == row || row == elements)
        //         {
        //             Console.Write("*");
        //         }
        //         else
        //         {
        //             Console.Write(" ");
        //         }
        //     }
        //     Console.WriteLine();
        // }


        // //Bang cuu chuong
        // int number;
        // do
        // {
        //     Console.Clear();
        //     Console.Write("Nhap so tu 2-9: ");
        //     // number = Convert.ToInt32(Console.ReadLine());
        //     int.TryParse(Console.ReadLine(), out number);
        // }
        // while(number < 2 || number > 9);

        // for (int element = 1; element <= 10; element++ )
        // {
        //     Console.Write($"{number} x {element} = {number * element}\n");
        // }





        // //BCC
        // int num, element;
        // for(num = 1 ; num <= 10; num++)
        // {
        //     for(element = 2; element <= 9; element++)
        //     Console.Write($" {element} x {num} = {num * element}\t");
        //     Console.Write("\n");
        // }
        






    }
}