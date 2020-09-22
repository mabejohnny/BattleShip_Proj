using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShip
{
    class GameBoard
    {

        //member variables 
        public int[,] array = new int[20, 20];





        //construtor
        public GameBoard()
        { 

        }


        //member methods 
        public void PrintBoard()
        {
            Console.WriteLine("  1  2  3  4  5  6  7  8  9  10  11  12  13  14  15  16  17  18  19  20  ");
            for (int i = 1; i <= 20; i++)
            {
                Console.Write($"{LetterToWrite(i)}");
                for (int y = 1; y <= 20; y++)
                {

                    Coordinate coordinate = new Coordinate(i, y);
                    ShotHistory ValShotHist = GameBoard.CheckCoordinate(coordinate);
                    switch (ValShotHist)
                    {
                        case ShotHistory.Unknown:
                            Console.Write(" ! ");
                            break;
                        case ShotHistory.Miss:
                            Console.Write(" M ");
                            break;
                        case ShotHistory.Hit:
                            Console.Write(" H ");
                            break;
                        default:
                            Console.Write(" ! ");
                            break;
                    }
                }
                Console.WriteLine("");
            }
        }
        public static char LetterToWrite(int i)
        {
            switch (i)
            {
                case 1:
                    return 'A';
                case 2:
                    return 'B';
                case 3:
                    return 'C';
                case 4:
                    return 'D';
                case 5:
                    return 'E';
                case 6:
                    return 'F';
                case 7:
                    return 'G';
                case 8:
                    return 'H';
                case 9:
                    return 'I';
                default:
                    return 'J';

            }


        }
    }
       
    
}

