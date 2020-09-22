using System;

namespace BattleShip
{
    class Program
    {
        static void Main(string[] args)
        {
            //Game game = new Game();
            //game.RunGame();
            //BattleField battlefield = new BattleField();
            //battlefield.array

            //how to access one square (be able to change and check for ships placed)
            //search how to assign each 'square' a number value
            //break down into steps on creation
            //CW the array to see how it looks in console
            
            
                Console.WriteLine("   1" + "  " + "  " + "2" + "  " + "  " + "3" + "  " + "  " + "4" + "  " + "  " + "5" + "  " + "  " + "6" + " " + " " + "7" + " " + " " + "8" + " " + " " + "9" + " " + " " + " 10" + " " + " " + "11" + " " + " " + "12" + " " + " " + "13" + " " + " " + "14" + " " + " " + "15" + " " + " " + "16" + " " + " " + "17" + " " + " " + "18" + " " + " " + "19" + " " + " " + "20");

                for (int i = 1; i <= 20; i++)
                {
                   
                    LetterToWrite(i);
                    Console.WriteLine("");

                }
            
             void LetterToWrite(int i)
             {
                switch (i)
                {
                    case 1:
                        Console.WriteLine("A");
                        break;
                    case 2:
                        Console.WriteLine("B");
                        break;
                    case 3:
                        Console.WriteLine("C");
                        break;
                    case 4:
                        Console.WriteLine("D");
                        break;
                    case 5:
                        Console.WriteLine("E");
                        break;
                    case 6:
                        Console.WriteLine("F");
                        break;
                    case 7:
                        Console.WriteLine("G");
                        break;
                    case 8:
                        Console.WriteLine("H");
                        break;
                    case 9:
                        Console.WriteLine("I");
                        break;
                    case 10:
                        Console.WriteLine("J");
                        break;
                    case 11:
                        Console.WriteLine("K");
                        break;
                    case 12:
                        Console.WriteLine("L");
                        break;
                    case 13:
                        Console.WriteLine("M");
                        break;
                    case 14:
                        Console.WriteLine("N");
                        break;
                    case 15:
                        Console.WriteLine("O");
                        break;
                    case 16:
                        Console.WriteLine("P");
                        break;
                    case 17:
                        Console.WriteLine("Q");
                        break;
                    case 18:
                        Console.WriteLine("R");
                        break;
                    case 19:
                        Console.WriteLine("S");
                        break;
                    case 20:
                        Console.WriteLine("T");
                        break;
                    default:
                        Console.WriteLine("0");
                        break;
                }


             }
        }
    }
}
