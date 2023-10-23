namespace _03._Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //Четем броя на песните
            int numberOfSongs = int.Parse(Console.ReadLine());
            //Създаваме лист от тип Song, който сме дефинирали в класа Song
            List<Song> songs = new List<Song>();

            //Пускаме цикъл, който върти докато стане равен на бр. на песните
            for (int i = 0; i < numberOfSongs; i++)
            {   
                //Създаваме масив, в който ще отделим данните по тип, име и време
                string[] data = Console.ReadLine()
                                       .Split("_", StringSplitOptions.RemoveEmptyEntries);
                string type = data[0];
                string name = data[1];
                string time = data[2];
                //Създаваме инстанция/обект от класа Song
                Song song = new Song();

                //Приравняваме му стойностите, които сме прочели от масива data
                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                //Добавяме обктите към листа с обекти songs
                songs.Add(song);       

            }
            //Четем последния вход, с типа на листата
            string typeList = Console.ReadLine();

            //Ако листата е == на All
            if (typeList == "all") 
            {   
                //Изпечатваме всички обекти от листата songs
                foreach (Song song in songs) 
                {
                    Console.WriteLine(song.Name);
                }
            }
            //Изпечатваме само обкетите, които отговарят на типа листа, например favourites/ listen later
            else
            {
                foreach (Song song in songs) 
                {
                    if (song.TypeList == typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }
        }
    }

    //Kлас Song с properties Type, Name, Time, винаги с главна буква
    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
    
}