using System;
namespace SnakeAndLadder
{
    public class Snakes
    {
        int PositionP1 = 0;
        Random random = new Random();
        const int NoPlay = 0, PlayerAhead = 1, PlayerBehind = 1;
        //UC-3
        public void Check()
        {
            int check = random.Next(0, 3);
            Console.WriteLine("Select the option");
            Console.WriteLine("1.NoPlay" + "\n" +
                              "2.PlayerAhead" + "\n" +
                              "3.PlayerBehind" + "\n");
            int options = Convert.ToInt32(Console.ReadLine());
            bool flag = true;
            switch (check)
            {
                case 0:
                    PositionP1 = 0;
                    break;
                case 1:
                    this.PositionP1 += PlayerAhead;
                    break;
                case 2:
                    this.PositionP1 -= PlayerAhead;
                    break;
                case 3:
                    flag = false;
                    break;
            }
            Console.WriteLine("Player is at {0} PositionP1", PositionP1);
        }

    }
}