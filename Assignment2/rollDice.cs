using System;
namespace Assignment2
{
	public class rollDice
	{
		public void roll(int numrolls)
		{
            int[] sums = new int[11];
            Double[] percentages = new Double[11];

            // roll dice twice randomly
            Random rnd = new Random();

            // rolls dice # of times indicated by user
            for (int i = 0; i < numrolls; i++)
            {
                // roll 2 dice and add them up 
                int diceOne = rnd.Next(1, 7);
                int diceTwo = rnd.Next(1, 7);
                int diceSum = diceOne + diceTwo;

                int posInArray = diceSum - 2;

                sums[posInArray]++;
                   
            }

            Double total = 0;
            Double percent = 0.0;

            // calculate percentage and store in array 
            for (int i = 0; i < 11; i++)
            {
                total = sums[i];

                percent = (total/numrolls*100);
                percent = Math.Round(percent);
                percent = Convert.ToInt32(percent);

                percentages[i] = percent;
            }


            // print results
            Console.WriteLine("\n" + "DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each ' * ' represents 1 % of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + numrolls.ToString() + '\n');

            string sStars = "";
            Double numStars = 0;

            // display histograph

            for (int i = 0; i < 11; i++)
            {
                numStars = percentages[i];

                for (int j = 0; j < numStars; j++)
                {
                    sStars = sStars + '*';
                }
                Console.WriteLine((i + 2).ToString() + ": " + sStars);

                sStars = "";
            }

        }
	}
}

// testing commit