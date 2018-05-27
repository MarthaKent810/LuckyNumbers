﻿using System;
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
            double jackpot = 150000.00;
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
            Console.WriteLine("Do you want to play? (yes or no) The Jackpot is $150,000");
            exitresp = Console.ReadLine().ToLower();
            while (exitresp.Equals("yes"))
            {
                Console.WriteLine("Please enter a starting number for your range");
                startnum = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the end number for your range");
                endnum = int.Parse(Console.ReadLine());
                int i = 0;
               // Array.Clear(userin, 0, userin.Length);
                count = 0;

                for ( i = 0; i < userin.Length; i++)
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
                       
                    } else
                    {
                        Console.WriteLine("Out of range. Please enter another");
                        i = i - 1;
                    }
                    
                }
                for (int i = 0; i < RandNum.Length; i++)
                {
                    RandNum[i] = r.Next(startnum, (endnum + 1));
                    Console.WriteLine("Lucky Number = " + RandNum[i]);

                }

                for (int i = 0; i < userin.Length; i++)

                    for (int j = 0; j < RandNum.Length; j++)
                    {
                        if (userin[i] == RandNum[j])
                        {
                            count += 1;
                        }
                    }
                        Console.WriteLine("You guessed " + count + " correctly!");
                        win = jackpot / 6 * count;
                        Console.WriteLine("You won $" + win);
                        
                    
                Console.WriteLine("Play again ?");
                exitresp = Console.ReadLine().ToLower();
            }
                Console.WriteLine("Thanks for playing!");

        }
    }   
}

