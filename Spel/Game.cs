using System;
using System.Collections.Generic;
using System.Text;

namespace Spel
{
    public class Game {

        public int numberOfGuesses = 0; //håller koll på antalet gissningsrader
        public Guess[] guessRows = new Guess[9]; //nu låtsas vi att man får nio gissningar (det får bra plats i fönstret) 
        //Vi har en array med nio platser där varje plats har en gissning och varje gissning har fem (färg)gissningar i sig
        public int level = 5; //default värde är fem för att kunna testa //detta kan vi nog ta bort när vi får till den riktiga startsidan
        private GameKey gameKey;


        public Game(int level) {
            //töm spelplanen och börja ett nytt spel - hur tömmer jag spelplanen?

            //nytt spel får ett nytt facit
            gameKey = new GameKey(level);
            //skapa en ny gissning
            newGuess();
            //nollställer räknaren för att få korrekt index i fältet
            numberOfGuesses = 0;
        }

        public void setLevel(int lvl) {
            level = lvl;
        }

        public void newGuess() {
            Guess newGuess = new Guess(level);
            guessRows[numberOfGuesses] = newGuess;
            numberOfGuesses++;
        }

        public ResultOptions[] submitGuessRow() {
            //tar in resultatet för gissningsraden genom metoden Results från klassen Guess
            ResultOptions[] results = guessRows[numberOfGuesses].Results(guessRows[numberOfGuesses], gameKey);

            //sortera resultaten så att det inte blir för lätt att se vilka färger som var rätt och inte
            ResultOptions[] temp = new ResultOptions[5];
            int filledSpaces = 0;
            for (int i = 0; i < 5; i++)
            {
                if (results[i] == ResultOptions.RightIconRightPlace)
                {
                    temp[filledSpaces] = results[i];
                    filledSpaces++;
                }
            }
            for (int j = 0; j < 5; j++)
            {
                if (results[j] == ResultOptions.RightIconWrongPlace)
                {
                    temp[filledSpaces] = results[j];
                    filledSpaces++;
                }
            }
            for (int k = 0; k < 5; k++)
            {
                if (results[k] == ResultOptions.WrongIcon)
                {
                    temp[filledSpaces] = results[k];
                    filledSpaces++;
                }
            }

            return results;
        }


    }
}
