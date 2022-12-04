using SnakeAndLadder;
using System;
using System.Diagnostics;

namespace LogicalProblems
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Snake And Ladder Programs");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("-------SnakeAndLadder Game ------");
                Console.WriteLine("Select the option");
                Console.WriteLine("1.GameStart" + "\n" +
                                  "2.Exit" + "\n");
                int options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:
                        Starts starts = new Starts();
                        starts.GameStart();
                        break;
                    case 12:
                        flag = false;
                        break;
                }
            }
        }
    }
}