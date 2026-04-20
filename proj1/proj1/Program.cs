using System.ComponentModel.Design;

namespace proj1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int secret = rng.Next(1, 101);
            int attemps = 0;

            Console.WriteLine("Guess a number between 1 and 100!!!1!1!!");

            while (true)
            {
                Console.Write("Your guess: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int guess))
                {
                    Console.WriteLine("only numbers");
                    continue;
                }
                attemps++;

                if (guess < secret)
                {
                    Console.WriteLine("higher!");
                }
                else if (guess > secret)
                {
                    Console.WriteLine("lower!");
                }
                else
                {
                    Console.WriteLine($"Correct!! it took you {attemps} attempts!!");
                    break;
                }
            }
        }
    }
}
