using System;

namespace Assignment2
{
    class Program
    {
        public static void Main(string[] args)
        {
            rollDice rd = new rollDice();

            int diceRolls = 0;

            // get dice roll count 
            Console.WriteLine("Welcome to the dice throwing simulator!");
            Console.WriteLine("How many dice rolls would you like to simulate? ");
            diceRolls = Convert.ToInt32(Console.ReadLine());

            rd.roll(diceRolls);

            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        }
    }
}

