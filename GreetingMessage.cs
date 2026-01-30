
using System.Dynamic;

public class GreetingMessage
{
    public static void Message()
    {
        Console.WriteLine("What is your name?");
        string? name = Console.ReadLine();
        Console.WriteLine("\n");

        //Console.WriteLine(day); just a test to se the format it printed out.
        var time = DateTime.Now.ToString("HH:MM");
        var day = DateTime.Now.DayOfWeek;
        int hour = DateTime.Now.Hour;

        if (hour < 6)
        {
            Console.WriteLine($"Go to bed! {name}\nIt's {day}, {time}");
        }
        else if (hour < 12)
        {
            Console.WriteLine($"Good morning, {name}\nIt's {day}, {time}");
        }
        else if (hour < 16)
        {
            Console.WriteLine($"Good afternoon, {name}\nIt's {day}, {time}");
        }
        else if (hour < 24)
        {
            Console.WriteLine($"Good evening, {name}\nIt's {day}, {time}");
        }
        else
        {
            Console.WriteLine("Unknown ERROR");
        }
    }

}