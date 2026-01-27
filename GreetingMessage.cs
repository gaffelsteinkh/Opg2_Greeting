
public class TimeCheck
{
    public static void Message()
    {
        Console.WriteLine("What is your name?");
        string? name = Console.ReadLine();
        Console.WriteLine("\n");

        
        string time = DateTime.Now.ToString("HH:mm");
        //Console.WriteLine(time);
        int hour = DateTime.Now.Hour;
        if (hour < 6)
        {
            Console.WriteLine($"Go to bed! {name}\nCurrent time is: {time}");
        }
        else if (hour < 12)
        {
            Console.WriteLine($"Good morning, {name}\nCurrent time is: {time}");
        }
        else if (hour < 16)
        {
            Console.WriteLine($"Good afternoon, {name}\nCurrent time is: {time}");
        }
        else if (hour < 24)
        {
            Console.WriteLine($"Good evening, {name}\nCurrent time is: {time}");
        }

    }

}