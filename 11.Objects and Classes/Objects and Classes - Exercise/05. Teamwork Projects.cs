using System.ComponentModel;
using System.Text;

namespace _05._Teamwork_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int teamCount = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 0; i < teamCount; i++)
            {
                string[] newTeam = Console.ReadLine().Split("-");
                string creatorName = newTeam[0];
                string teamName = newTeam[1];

                Team team = new Team (teamName, creatorName);
                bool isTeamNameExisting = teams.Select(x => x.TeamName).Contains(teamName);
                bool isCreatorNameExisting = teams.Select(x => x.CreatorName).Contains(creatorName);

                if (!isTeamNameExisting)
                {
                    if (!isCreatorNameExisting)
                    {
                        teams.Add(team);
                        Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
                    }
                    else
                    {
                        Console.WriteLine($"{creatorName} cannot create another team!");
                    }
                }
                else
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
            }

            string teamMembers = "";

            while ((teamMembers = Console.ReadLine()) != "end of assignment")
            {   

                //Сплитваме по два разделиятеля, - и >
                string[] commandArgs = teamMembers.Split(new char[] { '-', '>' }).ToArray();
                string newUser = commandArgs[0];
                string teamName = commandArgs[1];

                bool isTeamExisting = teams.Select(x => x.TeamName).Contains(teamName);
                bool isCreatorExisting = teams.Select(x => x.CreatorName).Contains(newUser);
                // От колекцията teams в колекцията Members, проверяваме дали съдъжва newUser
                bool isMemberExisting = teams.Select(x=>x.Members).Any(x=>x.Contains(newUser));

                if (!isTeamExisting)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if(isCreatorExisting || isMemberExisting)
                {
                    Console.WriteLine($"Member {newUser} cannot join team {teamName}!");
                }
                else 
                {   
                    //Намираме индекса на търсения отбор с метода FindIndex и го записваме в променливата
                    //индекс
                    int index = teams.FindIndex(x=>x.TeamName == teamName);
                    //Добавяме в List<Team> teams от index/Members новият играч newUser
                    teams[index].Members.Add(newUser);
                }
            }

            //Сортираме отборите, които имат само създател, и ги премахваме 
            //Where филтрира колецията, на базата на даден предикат
            Team[] teamsToDisband = teams.OrderBy(x => x.TeamName)
                                         .Where(x => x.Members.Count == 0)
                                         .ToArray();
            //Сортираме в низходящ ред отборите по брой членове, след това (thenBy) по име, където (where)
            // броя на членовете Members.Count > 0.  
            Team[] fullTeam = teams.OrderByDescending(x => x.Members.Count)
                                    .ThenBy(x => x.TeamName)
                                    .Where(x => x.Members.Count > 0)
                                    .ToArray();
            //AppendLine добавя нова линия
            StringBuilder stringBuild = new StringBuilder();
            
            foreach (Team team in fullTeam) 
            {
                stringBuild.AppendLine($"{team.TeamName}");
                stringBuild.AppendLine($"- {team.CreatorName}");

                foreach(string member in team.Members.OrderBy(x => x))
                {
                    stringBuild.AppendLine($"-- {member}…");
                }
            }

            stringBuild.AppendLine("Teams to disband");

            foreach(Team team in teamsToDisband)
            {
                stringBuild.AppendLine(team.TeamName);
            }

            Console.WriteLine(stringBuild.ToString());


        }
    }

    class Team
    {   
        public Team(string name, string creator)
        {
            TeamName = name;
            CreatorName = creator;
            //Object reference not set to an instance of an object
            //Трябва да създадем тази колекция с new в конструктора, иначе тя няма да същетвува
            Members = new List<string>();
        }
        public string TeamName { get; set; }
        public string CreatorName { get; set; }
        public List<string> Members { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}