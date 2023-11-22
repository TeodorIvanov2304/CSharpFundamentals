using System.Text.RegularExpressions;
using System.Linq;

namespace _05._Nether_Realms
{
    class Demon
    {
        public Demon(string name, int health, double damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public string Name { get; set; }
        public int Health { get; set; }
        public double Damage { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Health} health, {Damage:F2} damage";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //All numbers regex +-1, +- 0.1 !!!
            string numberPattern = @"([-+]?[0-9]+\.?[0-9]*)";

            Regex numbersRegex = new Regex(numberPattern);
            List<Demon> allDemons = new List<Demon>();
            //Сплитваме демоните по празно място и запетайка, вместо да правя отделен regex
            string[] demons = Console.ReadLine()
                                     .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                     .ToArray();

            foreach (var demonName in demons)
            {
                string filter = "1234567890+-/*.";

                //Взимаме всеки символ, където се съдържа различен от филтъра символ и го сумираме
                int health = demonName.Where(c => !filter.Contains(c)).Sum(c => c);
                double damage = CalculateDamage(numbersRegex, demonName);
                Demon demon = new Demon(demonName, health, damage);
                allDemons.Add(demon);
            }

            foreach (var demon in allDemons.OrderBy(x => x.Name))
            {
                Console.WriteLine(demon);
            }

        }

        public static double CalculateDamage(Regex numbersRegex, string demon)
        {
            MatchCollection numberMatches = numbersRegex.Matches(demon);
            double damage = 0;
            foreach (Match match in numberMatches)
            {
                damage += double.Parse(match.Value);
            }

            foreach (var ch in demon)
            {
                if (ch == '*')
                {
                    damage *= 2.0;
                }
                if (ch == '/')
                {
                    damage /= 2.0;
                }
            }
            return damage;
        }
    }
}