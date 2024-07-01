namespace Loops;

class Program
{
    static void Main(string[] args)
    {
        {
            //loops
            int count = 0;
            for (int i = 100; i <= 400; i++)
                if (i % 5 == 0)
                {
                    Console.WriteLine($"{i}");
                    count++;
                    if (count == 5) break;
                }
        }
    }
}
