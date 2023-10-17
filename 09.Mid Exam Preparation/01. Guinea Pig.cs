namespace _09.Mid_Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Merry has a guinea pig named Puppy, that she loves very much.Every month she goes to the nearest pet store and buys him everything he needs – food, hay and cover.
            //On the first three lines, you will receive the quantity of food, hay and cover, which Merry buys for a month (30 days). On the fourth line, you will receive the guinea pig's weight.
            //Every day Puppy eats 300 gr of food.Every second day Merry first feeds the pet, then gives it a certain amount of hay equal to 5 % of the rest of the food.On every third day, Merry puts Puppy cover with a quantity of 1 / 3 of its weight.
            //Calculate whether the quantity of food, hay and cover will be enough for a month.
            //If Merry runs out of food, hay, or cover, stop the program!


            double food = double.Parse(Console.ReadLine());
            double hay = double.Parse(Console.ReadLine());
            double cover = double.Parse(Console.ReadLine());
            double puppyWeight = double.Parse(Console.ReadLine());
            

            for (int days = 1; days <= 30; days++)
            {
                food -= 0.3;
                if(food<0)
                {
                    food = 0;
                    break;
                }

                if (days%2==0)
                {
                    double currentHay = 0.05 * food;
                    hay -= currentHay;
                }

                if(hay<0) 
                {
                    hay = 0;
                    break;
                }
                
                if(days%3==0)
                {
                    double currentCover = puppyWeight / 3;
                    cover -= currentCover;
                }
                if (cover < 0)
                {
                    cover = 0;
                    break;
                }


            }

            if (food>0&&hay>0&&cover>0) 
            {
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {food:F2}, Hay: {hay:F2}, Cover: {cover:F2}.");
            }

            else
            {
                Console.WriteLine($"Merry must go to the pet store!");
            }
            
        }
    }
}