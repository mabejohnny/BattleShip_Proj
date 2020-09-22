using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShip
{
    abstract class Player
    {

        //member variables
        public string name;
        public int score;

        public List<Ships> ships;



        //constructor
        public Player()
        {
            this.name = name;
            this.score = 0;

            ships = new List<Ships>();
            ships.Add(new Ships("Destroyer", 2));
            ships.Add(new Ships("Destroyer", 3));
            ships.Add(new Ships("Battleship", 4));
            ships.Add(new Ships("Aircraft Carrier", 5));

        }

        
        //member methods





    }
}
