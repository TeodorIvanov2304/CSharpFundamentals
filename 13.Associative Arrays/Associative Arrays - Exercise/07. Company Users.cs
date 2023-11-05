namespace _07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //Създаваме речник от типове strting и List<string>
            Dictionary<string, List<string>> database = new Dictionary<string, List<string>>();
            //Четем данните от конзолата, докатоа не получим End
            string input = "";
            while ((input = Console.ReadLine()) != "End") 
            {   
                //Създаваме в променлива, в която сплитваме по раделител името и id-то
                string[] data = input.Split(" -> ");
                string companyName = data[0];
                string id = data[1];

                //Проверяваме, дали компанията съществува
                if (!database.ContainsKey(companyName)) 
                {   
                    //Ако не, я добавяме заедно с NEW LIST с id-та и добавяме първото
                    database[companyName] = new List<string>
                    {
                        id
                    };
                }
                //Ако компанията вече съществува, но id-тo не , добавяме само новото id
                else if (database.ContainsKey(companyName) && !database[companyName].Contains(id))
                {
                    database[companyName].Add(id);
                }
            }

            //Изпечатваме с foreach
            foreach (var kvp in database) 
            {
                Console.WriteLine(kvp.Key);
                foreach (var id in kvp.Value) 
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}