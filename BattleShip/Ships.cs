using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShip
{
    public class Ships
    {
        //member variables
        List<Ships> ships;
        public string name;
        public int length;
        public bool shipIsSunk = false; //sunk or not
        public int currentHits;
        public int maximumHits;
        


        //constructor
        public Ships(string name, int length, int currentHits, int maximumHits)
        {
            this.name = name;
            this.length = length;
            this.currentHits = 0;
            this.maximumHits = maximumHits;

        }

        //member methods 
        public void CheckIfShipIsSunk()
        {
            if(currentHits <= maximumHits)
            {
                shipIsSunk = true;
                RemoveShipFromList();
            }
            else
            {
                shipIsSunk = false;
            }
            
           
        }
        public void RemoveShipFromList()
        {
            foreach (Ships item in ships)
            {
                if (shipIsSunk == true)
                ships.Remove(item);


            }
        }
    }
}
