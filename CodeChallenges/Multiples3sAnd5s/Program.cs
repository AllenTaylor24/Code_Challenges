namespace Multiples3sAnd5s
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Code Challenge 1");

            int sum = 0;
            for (int currentNbr = 1; currentNbr < 1000; currentNbr++)
            {
                if (currentNbr % 3 == 0 || currentNbr % 5 == 0)
                { 
                    sum += currentNbr;
                }
            }
            Console.WriteLine($"The sum of all multiples of 3 or 5 below 1000 is: {sum}");
        }
    }
}
