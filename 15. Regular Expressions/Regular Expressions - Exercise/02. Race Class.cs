using System.Text;
using System.Text.RegularExpressions;

namespace _02._Race_Class
{   
    //Създаваме клас Участник, с prop име и дистанция
    class Participant
    {   
        //Конструктора е само с име?
        public Participant(string name)
        {
            Name = name;
        }

        //Пропъртита
        public string Name { get; set; }
        public uint Distance { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {   
            //Създаваме лист от string, в който сплитваме по , и запазваме имената на рег. участници
            List<string> participantsNames = Console.ReadLine()
                                        .Split(", ")
                                        .ToList();

            //Правим лист от обекти participant/участник
            List<Participant> participants = new List<Participant>();

            //Добавяме към листа от обекти имената на всички участници
            foreach (string name in participantsNames) 
            {
                Participant participant = new Participant(name);
                participants.Add(participant);
            }

            //Четем участници и дистанции, докато не получим end of race
            string input = "";
            while ((input = Console.ReadLine()) != "end of race")
            {   
                //Създаваме StringBuilder, който ще събира буквите на имената
                StringBuilder nameBuilder = new StringBuilder();
                //Създаваме стринг променлива, която пази pattern за буквите
                string lettersPattern = @"[A-Za-z]";
                //Пускаме foreach loop за всеки match, който отговаря на letter-pattern-a 
                foreach (Match match in Regex.Matches(input, lettersPattern))
                {   
                    //Добавяме към StringBuilder-a
                    nameBuilder.Append(match.Value);
                }

                string participantName = nameBuilder.ToString();
                //Създаваме променлива, която пази дистанцията
                uint distance = 0;
                //Създаваме стринг променлива, която пази pattern за цифрите
                string numbersPattern = @"\d";
                //Пускаме foreach loop за всеки match, който отговаря на number-pattern-a
                foreach (Match match in Regex.Matches(input, numbersPattern))
                {   
                    //Добавяме стойността към distance, като преди това Parse-ваме
                    distance += uint.Parse(match.Value);
                }

                Participant foundParticipant = participants.FirstOrDefault(p=>p.Name == participantName);
                if (foundParticipant != null)
                {
                    foundParticipant.Distance += distance;
                }

            }
            List<Participant> firstThreeParticipants = participants
                                                       .OrderByDescending(p=>p.Distance)
                                                       .Take(3)
                                                       .ToList();

            Console.WriteLine($"1st place: {firstThreeParticipants[0].Name}");
            Console.WriteLine($"2nd place: {firstThreeParticipants[1].Name}");
            Console.WriteLine($"3rd place: {firstThreeParticipants[2].Name}");

        }
    }
}