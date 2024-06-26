namespace Lesson_4._1;

class SwitchCase
{
    static void Main(string[] args)
    {
        Console.Write("Enter month: ");
        int month = Convert.ToInt32(Console.ReadLine());
        switch(month)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                Console.Write("31 days");
                break;
            case 2:
                Console.Write("28 or 29 days");
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                Console.Write("30 days");
                break;
            default:
                Console.Write("Invalid month");
                break;
        }

    }
}
