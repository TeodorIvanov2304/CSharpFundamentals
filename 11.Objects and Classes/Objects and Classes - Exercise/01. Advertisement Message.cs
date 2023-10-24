namespace _01._Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that generates random fake advertisement messages to advertise a product.The messages must consist of 4 parts: phrase + event + author + city. Use the following predefined parts:
            //•	Phrases – { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product."}
            //•	Events – { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"}
            //•	Authors – { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"}
            //•	Cities – { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"}
            //The format of the output message is the following: "{phrase} {event} {author} – {city}."
            //You will receive the number of messages to be generated. Print each random message at a separate line.

            int messages = int.Parse(Console.ReadLine());
            List<string> phrases = new List<string> { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can't live without this product." };

            List<string> events = new List<string> { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };

            List<string> authors = new List<string> { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            List<string> cities = new List<string> { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random random = new Random();

            for (int i = 0; i < messages; i++)
            {
                string randomPhrase = "";
                for (int j = 0; j < phrases.Count; j++)
                {
                    int randomPhraseIndex = random.Next(0, phrases.Count);
                    randomPhrase = phrases[randomPhraseIndex];
                }

                string randomEvent = "";
                for (int j = 0; j < events.Count; j++)
                {
                    int randomEventIndex = random.Next(0, phrases.Count);
                    randomEvent = events[randomEventIndex];
                }

                string randomAuthor = "";
                for (int j = 0; j < authors.Count; j++)
                {
                    int randomAuthorIndex = random.Next(0, authors.Count);
                    randomAuthor = authors[randomAuthorIndex];
                }

                string randomCity = "";
                for (int j = 0; j < cities.Count; j++)
                {
                    int randomCityIndex = random.Next(0, cities.Count);
                    randomCity = cities[randomCityIndex];
                }

                Console.WriteLine($"{randomPhrase} {randomEvent} {randomAuthor} – {randomCity}.");
            }
        }
    }
}