using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6DiceRoll
{
    class Program
    {

        static Random rnd = new Random();
        static int counter = 0;
        static void Main(string[] args)
        {
            Greet();
            Game();
        }

        static void Game()
        {
            string response = Console.ReadLine().ToLower();
            if (response == "exit")
            {
                return;
            }

            while (true)
            {
                Console.Write("How many sides on your pair of dice? ");

                string sides = Console.ReadLine();
                int numberSides = int.Parse(sides);

                int rolledNum = RollDice(numberSides);
                int rolledNumTwo = RollDice(numberSides);
                counter++;

                Console.WriteLine($"Roll #: {counter}\nFirst number is: {rolledNum} \nSecond number is: {rolledNumTwo}");
                if (rolledNum == 1 && rolledNumTwo == 1)
                {
                    Console.WriteLine("Congratulions, you've rolled snake eyes!");
                }
                else if (rolledNum == 6 && rolledNumTwo == 6)
                {
                    Console.WriteLine("Congratulations you've rolled boxcars!");
                }
                else if (rolledNum + rolledNumTwo == 7 || rolledNum + rolledNumTwo == 11)
                {
                    Console.WriteLine("Congratulations you've rolled craps!");
                }

                Console.WriteLine("Play again (y/n)?");
                response = Console.ReadLine();
                if (response.ToLower() != "y")
                    return; 
            }
        }

        static int RollDice(int numberSides)
        {
            int num = rnd.Next(1, numberSides);
            return num;
        }
        static void Greet()
        {
            Console.WriteLine("Welcome to Grand Circus Casino! Would you like to roll the dice or exit?");
        }

    }
}