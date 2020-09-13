using Brainiac;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Input;

namespace Spel
{
    public class MainWindowViewModel : BaseViewModel {

        //nytt spel
        private Game game;

        //skapa variabler för att hitta vilken cirkel som ska fyllas i
        private ColorChoices[] circles = new ColorChoices[45]; //varje cirkel får en egen placering i listan
        //private Dictionary<int[], ColorChoices> circleToRowColum = new Dictionary<int[], ColorChoices>(); //kopplar ihop cirkeln (int[]) med färgalternativet

        //hit binds färgerna för att se så att det funkar (bara test, ta bort sen
        //public ColorChoices circles[0] { get; set; } //= ColorChoices.GREEN;
        public ColorChoices Place12 { get; set; } = ColorChoices.GREEN;
        public ColorChoices Place13 { get; set; } = ColorChoices.PURPLE;
        public ColorChoices Place14 { get; set; } = ColorChoices.RED;
        public ColorChoices Place15 { get; set; } = ColorChoices.RED;


        //kommandon som kopplas till färgknapparna (MVVM-stil isället för click-event)
        public ICommand BlueCommand { get; set; } 
        public ICommand YellowCommand { get; set; }
        public ICommand GreenCommand { get; set; }
        public ICommand BrownCommand { get; set; }
        public ICommand RedCommand { get; set; }
        public ICommand PurpleCommand { get; set; }

        public MainWindowViewModel(int level) {
            //skapa ett nytt spel
            game = new Game(level);

            //kopplar varje command till en egen metod
            BlueCommand = new RelayCommand(Blue);
            YellowCommand = new RelayCommand(Yellow);
            GreenCommand = new RelayCommand(Green);
            BrownCommand = new RelayCommand(Brown);
            RedCommand = new RelayCommand(Red);
            PurpleCommand = new RelayCommand(Purple);
        }

        //metoder att koppla kommandon till
        public void Blue() {
            //hitta aktuell placering (rad och gissning i raden) och lägg in gissad färg och fyll cirkeln på spelplanen
            game.guessRows[game.numberOfGuesses].guessRow[game.guessRows[game.numberOfGuesses].guessesInTheRow] = 1;
            
            Place11 = ColorChoices.BLUE; 
            //bara för att kontrollera att jag kom in i metoden
            Console.Beep();
        }
        public void Yellow() {
            //hitta aktuell placering (rad och gissning i raden) och lägg in gissad färg och fyll cirkeln på spelplanen
            game.guessRows[game.numberOfGuesses].guessRow[game.guessRows[game.numberOfGuesses].guessesInTheRow] = 2;
            //raden blir game.numberOfGuesses och kolumnen blir game.guessRows[game.numberOfGuesses].guessesInTheRow] 
            //antalet rader*5 + antalet gissningar i en nya raden blir cirkelns index
            int temp = (game.numberOfGuesses * 5) + game.guessRows[game.numberOfGuesses].guessesInTheRow;
            circles[temp] = ColorChoices.YELLOW; 

            //rowColumn[game.numberOfGuesses, game.guessRows[game.numberOfGuesses].guessesInTheRow] = ColorChoices.YELLOW;
        }
        public void Green() {
            //hitta aktuell placering (rad och gissning i raden) och lägg in gissad färg och fyll cirkeln på spelplanen
            game.guessRows[game.numberOfGuesses].guessRow[game.guessRows[game.numberOfGuesses].guessesInTheRow] = 3;
            //raden blir game.numberOfGuesses och kolumnen blir game.guessRows[game.numberOfGuesses].guessesInTheRow] 
            //antalet rader*5 + antalet gissningar i en nya raden blir cirkelns index
            int temp = (game.numberOfGuesses * 5) + game.guessRows[game.numberOfGuesses].guessesInTheRow;
            circles[temp] = ColorChoices.GREEN;

            //rowColumn[game.numberOfGuesses, game.guessRows[game.numberOfGuesses].guessesInTheRow] = ColorChoices.GREEN;
        }
        public void Brown() {
            //hitta aktuell placering (rad och gissning i raden) och lägg in gissad färg och fyll cirkeln på spelplanen
            game.guessRows[game.numberOfGuesses].guessRow[game.guessRows[game.numberOfGuesses].guessesInTheRow] = 4;
            //raden blir game.numberOfGuesses och kolumnen blir game.guessRows[game.numberOfGuesses].guessesInTheRow] 
            //antalet rader*5 + antalet gissningar i en nya raden blir cirkelns index
            int temp = (game.numberOfGuesses * 5) + game.guessRows[game.numberOfGuesses].guessesInTheRow;
            circles[temp] = ColorChoices.BROWN;

            //rowColumn[game.numberOfGuesses, game.guessRows[game.numberOfGuesses].guessesInTheRow] = ColorChoices.BROWN;
        }
        public void Red() {
            //hitta aktuell placering (rad och gissning i raden) och lägg in gissad färg och fyll cirkeln på spelplanen
            game.guessRows[game.numberOfGuesses].guessRow[game.guessRows[game.numberOfGuesses].guessesInTheRow] = 5;
            //raden blir game.numberOfGuesses och kolumnen blir game.guessRows[game.numberOfGuesses].guessesInTheRow] 
            //antalet rader*5 + antalet gissningar i en nya raden blir cirkelns index
            int temp = (game.numberOfGuesses * 5) + game.guessRows[game.numberOfGuesses].guessesInTheRow;
            circles[temp] = ColorChoices.RED;

            //rowColumn[game.numberOfGuesses, game.guessRows[game.numberOfGuesses].guessesInTheRow] = ColorChoices.RED;
        }
        public void Purple() {
            //hitta aktuell placering (rad och gissning i raden) och lägg in gissad färg och fyll cirkeln på spelplanen
            game.guessRows[game.numberOfGuesses].guessRow[game.guessRows[game.numberOfGuesses].guessesInTheRow] = 6;
            //raden blir game.numberOfGuesses och kolumnen blir game.guessRows[game.numberOfGuesses].guessesInTheRow] 
            //antalet rader*5 + antalet gissningar i en nya raden blir cirkelns index
            int temp = (game.numberOfGuesses * 5) + game.guessRows[game.numberOfGuesses].guessesInTheRow;
            circles[temp] = ColorChoices.PURPLE;

            //rowColumn[game.numberOfGuesses, game.guessRows[game.numberOfGuesses].guessesInTheRow] = ColorChoices.PURPLE;
        }
    }
}
