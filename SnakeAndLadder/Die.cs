using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    // UC2
    public class Die
    {
        // Declare Local Variable
        int PositionP1 = 0, PositionP2 = 0; int Dice;
        public void Dices()
        {
            Random random = new Random();
            Dice = random.Next(1, 6);
            Console.WriteLine(" Player rolls the die to get a number:" + Dice);

        }
    }
}
