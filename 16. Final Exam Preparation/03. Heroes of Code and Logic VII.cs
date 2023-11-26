/*
You got your hands on the most recent update on the best MMORPG of all time – Heroes of Code and Logic. You want to play it all day long! So cancel all other arrangements and create your party!
On the first line of the standard input, you will receive an integer n – the number of heroes that you can choose for your party. On the next n lines, the heroes themselves will follow with their hit points and mana points separated by a single space in the following format: 
"{hero name} {HP} {MP}"
-	HP stands for hit points and MP for mana points
-	a hero can have a maximum of 100 HP and 200 MP
After you have successfully picked your heroes, you can start playing the game. You will be receiving different commands, each on a new line, separated by " – ", until the "End" command is given. 
There are several actions that the heroes can perform:
"CastSpell – {hero name} – {MP needed} – {spell name}"
•	If the hero has the required MP, he casts the spell, thus reducing his MP. Print this message: 
o	"{hero name} has successfully cast {spell name} and now has {mana points left} MP!"
•	If the hero is unable to cast the spell print:
o	"{hero name} does not have enough MP to cast {spell name}!"
"TakeDamage – {hero name} – {damage} – {attacker}"
•	Reduce the hero HP by the given damage amount. If the hero is still alive (his HP is greater than 0) print:
o	"{hero name} was hit for {damage} HP by {attacker} and now has {current HP} HP left!"
•	If the hero has died, remove him from your party and print:
o	"{hero name} has been killed by {attacker}!"
"Recharge – {hero name} – {amount}"
•	The hero increases his MP. If it brings the MP of the hero above the maximum value (200), MP is increased to 200. (the MP can't go over the maximum value).
•	 Print the following message:
o	"{hero name} recharged for {amount recovered} MP!"
"Heal – {hero name} – {amount}"
•	The hero increases his HP. If a command is given that would bring the HP of the hero above the maximum value (100), HP is increased to 100 (the HP can't go over the maximum value).
•	 Print the following message:
o	"{hero name} healed for {amount recovered} HP!"
Input
•	On the first line of the standard input, you will receive an integer n.
•	On the following n lines, the heroes themselves will follow with their hit points and mana points separated by a space in the following format
•	You will be receiving different commands, each on a new line, separated by " – ", until the "End" command is given.
Output
•	Print all members of your party who are still alive in the following format (their HP/MP need to be indented 2 spaces):
"{hero name}
  HP: {current HP}
  MP: {current MP}"
*/
namespace _03._Heroes_of_Code_and_Logic_VII
{
    class Hero
    {
        public Hero(string name, short healthPoints, short manaPoints)
        {
            Name = name;
            HealthPoints = healthPoints;
            ManaPoints = manaPoints;
        }

        public string Name { get; set; }
        public short HealthPoints { get; set; }
        public short ManaPoints { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfHeroes = int.Parse(Console.ReadLine());
            List<Hero> listOfHeroes = new List<Hero>();
            for (int i = 0; i < numberOfHeroes; i++)
            {
                string heroInformation = Console.ReadLine();
                string[] heroTokens = heroInformation.Split().ToArray();
                string name = heroTokens[0];
                short healthPoints = short.Parse(heroTokens[1]);
                short manaPoints = short.Parse(heroTokens[2]);
                Hero hero = new Hero(name, healthPoints, manaPoints);
                listOfHeroes.Add(hero);
            }

            string heroActions = "";
            while ((heroActions = Console.ReadLine()) != "End")
            {
                string[] actionTokens = heroActions.Split(" - ").ToArray();
                string action = actionTokens[0];

                switch (action)
                {
                    case "CastSpell":
                        Hero hero = listOfHeroes.FirstOrDefault(n => n.Name == actionTokens[1]);
                        short manaPointsNeeded = short.Parse(actionTokens[2]);
                        string spellName = actionTokens[3];

                        if (hero is not null)
                        {
                            if (hero.ManaPoints >= manaPointsNeeded)
                            {
                                hero.ManaPoints -= manaPointsNeeded;
                                Console.WriteLine($"{hero.Name} has successfully cast {spellName} and now has {hero.ManaPoints} MP!");
                            }
                            else
                            {
                                Console.WriteLine($"{hero.Name} does not have enough MP to cast {spellName}!");
                            }
                        }
                        break;
                    case "TakeDamage":
                        hero = listOfHeroes.FirstOrDefault(n => n.Name == actionTokens[1]);
                        short damage = short.Parse(actionTokens[2]);
                        string attacker = actionTokens[3];
                        if (hero is not null)
                        {
                            hero.HealthPoints -= damage;
                            if (hero.HealthPoints > 0)
                            {
                                Console.WriteLine($"{hero.Name} was hit for {damage} HP by {attacker} and now has {hero.HealthPoints} HP left!");
                            }
                            else if (hero.HealthPoints <= 0)
                            {
                                Console.WriteLine($"{hero.Name} has been killed by {attacker}!");
                                listOfHeroes.Remove(hero);
                            }
                        }
                        break;
                    case "Recharge":
                        hero = listOfHeroes.FirstOrDefault(n => n.Name == actionTokens[1]);
                        short rechargeManaAmount = short.Parse(actionTokens[2]);
                        if (hero is not null)
                        {
                            if (hero.ManaPoints + rechargeManaAmount > 200)
                            {
                                rechargeManaAmount = (short)(200 - hero.ManaPoints);
                            }
                            hero.ManaPoints += rechargeManaAmount;
                            Console.WriteLine($"{hero.Name} recharged for {rechargeManaAmount} MP!");
                        }
                        break;
                    case "Heal":
                        hero = listOfHeroes.FirstOrDefault(n => n.Name == actionTokens[1]);
                        short rechargeHealthAmount = short.Parse(actionTokens[2]);
                        if (hero is not null)
                        {
                            if (hero.HealthPoints + rechargeHealthAmount > 100)
                            {
                                rechargeHealthAmount = (short)(100 - hero.HealthPoints);
                            }
                            hero.HealthPoints += rechargeHealthAmount;
                            Console.WriteLine($"{hero.Name} healed for {rechargeHealthAmount} HP!");
                        }
                        break;
                }
            }

            foreach (var hero in listOfHeroes)
            {
                Console.WriteLine($"{hero.Name}");
                Console.WriteLine($"  HP: {hero.HealthPoints}");
                Console.WriteLine($"  MP: {hero.ManaPoints}");
            }
        }
    }
}