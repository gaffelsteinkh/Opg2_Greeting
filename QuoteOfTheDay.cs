public class QuoteOfTheDay
{
    public string? quote;

    public static void Quote()
    {
        List<string> quote = new List<string>
        {
            "Alt skal en prøve og velge det beste.\n- Henrik Ibsen",
            "Der det er vilje, er det vei\n- Albert Einstein?",
            "I am a cage, in search of a bird\n- Franz Kafka",
            "I had to big fart in the last swing\n- Petter Solberg",
            "2 plus 2 is 4, minus 1 that's 3, quick maths\n- Big Shaq",
            "You could leave life right now. Let that determine what you do and say and think.\n- Marcus Aurelius",
            "You are free, and that is why you are lost.\n- Franz Kafka",
            "If you're good at something, never do it for free.\n- Heath Ledger(The Joker)",
            "Here's Johnny!\n— Jack Torrance",
            "Velkommen Kato, Thailand, eneste plassen med meir klamydia enn Finnmark.\n- Jompa Tormann",
            "Vi kommer til å dæævee\n- Grethe Kausland(Fru Packard) i 'Atlantis: En forsvunnet verden'",

        };

        Random random = Random.Shared;

        int randomIndex = random.Next(0, quote.Count);
        string randomQuote = quote[randomIndex];

        Console.WriteLine($"Here is a random Quote making this program seem a bit more fancy:\n\n {randomQuote}");
    }
    
}