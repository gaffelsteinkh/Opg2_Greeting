
public class TimeCheck
{
    public static void Message()
    {
        int time = DateTime.Now.Minute;
        int hour = DateTime.Now.Hour;
        if (hour < 6)
        {
            Console.WriteLine("Go to bed! The time is:",hour);
        }
        else if (hour < 12)
        {
            Console.WriteLine("Good morning");
        }
        else if (hour < 16)
        {
            Console.WriteLine("Good afternoon");
        }
        else if (hour < 24)
        {
            Console.WriteLine("Good evening");
        }

    }

}