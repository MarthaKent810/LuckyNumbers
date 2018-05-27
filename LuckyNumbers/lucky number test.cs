using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumbers
{
    class Program
    {
        static void Main(string[] args)
        // Declare variables
        {
            int startnum = 0;
            int endnum = 0;
            double jackpot = 245000.00;
            double win = 0;
            string exitresp = "";
            int[] userin = new int[6];
            int[] RandNum = new int[6];
            Random r = new Random();
            double count = 0;
            int med = 0;

            //solicit user input
            Console.WriteLine("W E L C O M E  T O  T H E  L O T T E R Y!");
            Console.WriteLine("You will be asked to enter 6  valid numbers in a range of your choosing");
            Console.WriteLine("Today's jackpot is $245,000.00");
            Console.WriteLine("Do you want to play? (yes or no)");
            exitresp = Console.ReadLine().ToLower();
            while (exitresp.Equals("yes"))
            {
                //User sets range of numbers
                Console.WriteLine("Please enter a starting number for your range");
                startnum = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the end number for your range");
                endnum = int.Parse(Console.ReadLine());

                // Set values to 0 for additional loops  
                Array.Clear(userin, 0, userin.Length);
                count = 0;

                //User inputs numbers; check for numbers out of range or duplicates
                for (int i = 0; i < userin.Length; i++)
                {
                    Console.WriteLine("Please enter a number");

                    med = int.Parse(Console.ReadLine());

                    if (med >= startnum && med <= endnum)
                    {
                        for (int k = 0; k < userin.Length; k++)
                        {
                            if (med == userin[k])
                            {
                                Console.WriteLine("Duplicate. Please enter another");
                                i = i - 1;
                            }
                        }
                        userin[i] = med;

                    }
                    else
                    {
                        Console.WriteLine("Out of range. Please enter another");
                        i = i - 1;
                    }

                    //Create random number
                }
                for (int i = 0; i < RandNum.Length; i++)
                {
                    RandNum[i] = r.Next(startnum, (endnum + 1));
                    Console.WriteLine("Lucky Number = " + RandNum[i]);

                    // Compare user input to random numbers to determine matches
                }
                for (int i = 0; i < userin.Length; i++)
                {
                    for (int j = 0; j < RandNum.Length; j++)
                    {
                        if (userin[i] == RandNum[j])
                        {
                            count += 1;
                            break;
                        }
                    }
                }
                Console.WriteLine("You guessed " + count + " correctly!");

                //Calculate winnings & display to screen
                win = jackpot / 6 * count;
                string winform = win.ToString("00,000.00");
                Console.WriteLine("You won $" + winform);

                //Give option to play again & re-enter loop    
                Console.WriteLine("Play again ?");
                exitresp = Console.ReadLine().ToLower();
            }
            //Exit statement
            Console.WriteLine("Thanks for playing!");

        }
    }
}

