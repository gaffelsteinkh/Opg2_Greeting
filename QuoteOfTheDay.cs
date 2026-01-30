public class QuoteOfTheDay
{
    public string? quote;

    public static void Quote()
    {
        List<string> quote = new List<string>
        {
            "Alt skal en prøve og velge det beste.\n-Henrik Ibsen",
            "Der det er vilje, er det vei\n-Albert Einstein?",
            "I am a cage, in search of a bird\n-Franz Kafka",
            "I had to big fart in the last swing\n-Petter Solberg",


        };

        Random random = Random.Shared;

        int randomIndex = random.Next(0, quote.Count);
        string randomQuote = quote[randomIndex];

        Console.WriteLine($"Here is a random Quote making this program seem a bit more fancy:\n\n {randomQuote}");
    }
    
}