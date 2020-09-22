using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShip
{
    class Game
    {

        //member variables
        Player playerOne;
        Player playerTwo;


        //constructor
        public Game()
        {

        }


        //member methods
        public void RunGame()
        {
            MainMenu();
        }

        public void MainMenu()
        {
            Console.WriteLine("Welcome To Battle Ship!" + "\n" + "\n");
            Console.WriteLine("Please choose from the following options:" + "\n" + "\n" + "- Type '1': For single player" + "\n" + "- Type '2': For multiplayer");
            string userInput = Console.ReadLine();
            Console.Clear();

            switch (userInput)
            {
                case "1":
                    playerOne = new Human();
                    playerTwo = new Computer();
                    DoubleCheckRightGameChoiceSinglePlayer();
                    SinglePlayerName();
                    break;
                case "2":
                    playerOne = new Human();
                    playerTwo = new Human();
                    DoubleCheckRightGameChoiceMultiPlayer();
                    MultiPlayerName();
                    break;

                default:
                    Console.WriteLine("Error! Please try again");
                    RunGame();
                    break;
            }
        }
        public void DoubleCheckRightGameChoiceSinglePlayer()
        {
            Console.WriteLine("You've chosen single-player mode, is that correct?" + "\n" + "\n" + "Type: '1' to continue" + "\n" + "Type: '2' to return to the main menu");
            string userAnswer = Console.ReadLine();

            switch (userAnswer)
            {
                case "1":

                    Console.Clear();
                    break;
                case "2":
                    MainMenu();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Error! Please try again");
                    DoubleCheckRightGameChoiceSinglePlayer();
                    Console.Clear();
                    break;

            }
        }

        public void DoubleCheckRightGameChoiceMultiPlayer()
        {
            Console.WriteLine("You've chosen multi-player mode, is that correct?" + "\n" + "\n" + "Type: '1' to continue" + "\n" + "Type: '2' to return to the main menu");
            string userAnswer = Console.ReadLine();

            switch (userAnswer)
            {
                case "1":

                    Console.Clear();
                    break;
                case "2":
                    MainMenu();
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Error! Please try again");
                    DoubleCheckRightGameChoiceMultiPlayer();
                    Console.Clear();
                    break;

            }
        }

        public string SinglePlayerName()
        {
            Console.WriteLine("Please enter your name");
            playerOne.name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Welcome to the game, Admiral " + playerOne.name + "\n");
            ReadTheRulesSingle();
            return playerOne.name;

        }

        public string MultiPlayerName()
        {
            Console.WriteLine("Please enter name for player one:");
            playerOne.name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Please enter name for player two:");
            playerTwo.name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Welcome to war land lovers!" + "\n" + "\n" + "Admiral " + playerOne.name + " VS. Captian " + playerTwo.name);
            this.ReadTheRulesMulti();

            return playerOne.name + playerTwo.name;

        }


        public void ReadTheRulesSingle()
        {
            Console.WriteLine("                       BATTLESHIP V 1.0");
            Console.WriteLine("Allow me to introduce myself " + playerOne.name + ".  My name is  " + playerTwo.name + "\n" + "\n");
            Console.WriteLine("The object of Battleship is to try and sink all of the other player's before they sink all of your ships." + "\n" + "All of the other player's ships are somewhere on his/her board." + "\n" + "You try and hit them by calling out the coordinates of one of the squares on the board." +"\n" + "The other player also tries to hit your ships by calling out coordinates." + "\n" + "Neither you nor the other player should be looking at the other's board so you must try to guess where they are." + "\n" + "Each board in the physical game has two grids:  the lower (horizontal) section for the player's ships and the upper part (vertical during play) for recording the player's guesses." + "\n" + "\n" + "\n");
            Console.WriteLine("Hit 'enter' when your finished");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("                       BATTLESHIP V 1.0");
            Console.WriteLine("- Each player places the 5 ships somewhere on their board." + "\n" + "- The ships can only be placed vertically or horizontally. Diagonal placement is not allowed." + "\n" + "- No part of a ship may hang off the edge of the board." + "\n" + "- Ships may not overlap each other." + "\n"  + "- No ships may be placed on another ship." + "\n" + "- Once the guessing begins, the players may not move the ships.");
            Console.WriteLine("Hit 'enter' when your finished with the rules");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("                       BATTLESHIP V 1.0");
            Console.WriteLine("Playing the Game:" + "\n" +"     - Player's take turns guessing by inputing the coordinates." + "\n" + "     - The console responds with 'hit' or 'miss' as appropriate." + "\n" + "     - Both players boards will be marked with 'pegs':  'X' for hit, 'O' for miss. For example, if you choose F6 and your opponent does not have any ship located at F6, the console would respond with 'miss' and record the miss F6 by placing an 'O' peg on your board at F6." + "\n" + "When all of the squares that one your ships occupies have been hit, the ship will be sunk. The console will announce 'hit and sunk." + "\n" + "\n" + "As all of one player's ships have been sunk, the game ends!");
            Console.WriteLine("Hit 'enter' when your finished with the rules");
            Console.ReadLine();
            Console.Clear();

        }

        public void ReadTheRulesMulti()
        {
            Console.WriteLine("                       BATTLESHIP V 1.0");
            Console.WriteLine("The object of Battleship is to try and sink all of the other player's before they sink all of your ships." + "\n" + "All of the other player's ships are somewhere on his/her board." + "\n" + "You try and hit them by calling out the coordinates of one of the squares on the board." + "\n" + "The other player also tries to hit your ships by calling out coordinates." + "\n" + "Neither you nor the other player should be looking at the other's board so you must try to guess where they are." + "\n" + "Each board in the physical game has two grids:  the lower (horizontal) section for the player's ships and the upper part (vertical during play) for recording the player's guesses." + "\n" + "\n" + "\n");
            Console.WriteLine("Hit 'enter' when your finished");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("                       BATTLESHIP V 1.0");
            Console.WriteLine("- Each player places the 5 ships somewhere on their board." + "\n" + "- The ships can only be placed vertically or horizontally. Diagonal placement is not allowed." + "\n" + "- No part of a ship may hang off the edge of the board." + "\n" + "- Ships may not overlap each other." + "\n" + "- No ships may be placed on another ship." + "\n" + "- Once the guessing begins, the players may not move the ships.");
            Console.WriteLine("Hit 'enter' when your finished with the rules");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("                       BATTLESHIP V 1.0");
            Console.WriteLine("Playing the Game:" + "\n" + "     - Player's take turns guessing by inputing the coordinates." + "\n" + "     - The console responds with 'hit' or 'miss' as appropriate." + "\n" + "     - Both players boards will be marked with 'pegs':  'X' for hit, 'O' for miss. For example, if you choose F6 and your opponent does not have any ship located at F6, the console would respond with 'miss' and record the miss F6 by placing an 'O' peg on your board at F6." + "\n" + "When all of the squares that one your ships occupies have been hit, the ship will be sunk. The console will announce 'hit and sunk." + "\n" + "\n" + "As all of one player's ships have been sunk, the game ends!");
            Console.WriteLine("Hit 'enter' when your finished with the rules");
            Console.ReadLine();
            Console.Clear();


        }

    }
}
