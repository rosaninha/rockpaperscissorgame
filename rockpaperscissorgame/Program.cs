using System;

namespace rockpaperscissorgame
{
    class Program
    {
        static void Main(string[] args)
        {
            string ans = "";
            int count = 0;
            int count1 = 0;

            Console.WriteLine("Hey there, Welcome to Rock Paper Scissor game");

            while (ans != "NO")
            {
                Console.WriteLine("Do you choose:\n1->ROCK\n2->PAPER\n3->SCISSOR");
                string[] choices = new string[3] { "ROCK", "PAPER", "SCISSOR" };
                Random rnd = new Random();
                int n = rnd.Next(0, 3);
                Console.WriteLine("Enter your choice:");
                string user = Console.ReadLine().ToUpper();
                Console.WriteLine("Computer:" + choices[n]);

                if (user == "ROCK" && choices[n] == "SCISSOR")
                {
                    Console.WriteLine("Congratulation!!! You win!!!");
                    count += 1;
                }
                else if (user == "ROCK" && choices[n] == "PAPER")
                {
                    Console.WriteLine("Sorry, Computer wins this time");
                    count1 += 1;
                }
                else if (user == "PAPER" && choices[n] == "ROCK")
                {
                    Console.WriteLine("That's great! You win champion");
                    count += 1;
                }
                else if (user == "PAPER" && choices[n] == "SCISSOR")
                {
                    Console.WriteLine("Computer Wins, try again.");
                    count1 += 1;
                }
                else if (user == "SCISSOR" && choices[n] == "ROCK")
                {
                    Console.WriteLine("Computer Wins but next time is going to be you");
                    count1 += 1;
                }
                else if (user == "SCISSOR" && choices[n] == "PAPER")
                {
                    Console.WriteLine("You win champion! You are the best");
                    count += 1;
                }
                else
                {
                    Console.WriteLine("It is a tie");
                }
                Console.WriteLine("Do you want to continue(YES/NO):");
                ans = Console.ReadLine().ToUpper();
                Console.WriteLine("---------------------------------------");
            }
            Console.WriteLine("That is not bad. You win " + count + " times");
            Console.WriteLine("Computer wins " + count1 + " times");
        }
    }
}
