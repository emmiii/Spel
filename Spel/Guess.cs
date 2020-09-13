using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spel
{
    public class Guess {

        public int[] guessRow;
        public int guessesInTheRow = 0;
        public bool submitted;
        public int level;

        public Guess()
        {
            guessRow = new int[5];
            submitted = false;
        }

        public Guess(int lvl)
        {
            guessRow = new int[lvl];
            submitted = false;
        }

        public void addGuessToRow(int selectedColor)
        {
            if (!submitted && guessesInTheRow < 6)
            {
                guessRow[guessesInTheRow] = selectedColor;
                guessesInTheRow++;
            }
            else
            {
                //om raden är full kan man inte lägga in fler färger
            }
        }

        //denna metod ska anropas när gissningen låses in
        //metod som jämför den låsta gisningen mot facit från GameKey
        public ResultOptions[] Results(Guess guess, GameKey key)
        {
            ResultOptions[] results = new ResultOptions[level];
            for (int i = 0; i < level; i++)
            {

                if (guess.guessRow[i] == key.gameKey[i])
                {
                    results[i] = ResultOptions.RightIconRightPlace;
                }
                else if (key.gameKey.Contains(guess.guessRow[i]))
                {
                    results[i] = ResultOptions.RightIconWrongPlace;
                }
                else
                {
                    results[i] = ResultOptions.WrongIcon;
                }
            }
            return results;
        }



    }
}
