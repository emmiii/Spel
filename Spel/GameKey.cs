using System;
using System.Collections.Generic;
using System.Text;

namespace Spel
{
    public class GameKey
    {

        public readonly int colorOptions = 6; //beroende på hur många färger vi tänker ha
        public int[] gameKey;
        public readonly Random random = new Random();

        public GameKey()
        {
            gameKey = new int[5];
            for (int i = 0; i < 5; i++)
            {
                gameKey[i] = i + 1;
            }
        }

        public GameKey(int chosenLevel)
        {
            gameKey = new int[chosenLevel];
            for (int i = 0; i < chosenLevel; i++)
            {
                int randomNumber = random.Next(colorOptions);
                gameKey[i] = randomNumber;
            }
        }


    }
}
