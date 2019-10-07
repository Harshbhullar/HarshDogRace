using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarshDogRace
{
   public class Game
    {
        //object of the Random clas that is help full in moving the dog from one location to another 
        Random objct = new Random();
        // user define method that is used to genreate a random no that  is pass to the form for the running of  the contestant of the Game 
        public int run() {
            return objct.Next(1,20);
        }

        // argument are used to calculate the amount of the winner for increment 
        public int Increment(int amount, int bet)
        {
            return amount + bet;
        }
        // argument are used to calculate the amount of the looser for Decrement 
        public int Decrement(int amount, int bet)
        {
            return amount - bet;
        }
        // this wil return the value to reset the value of the game 
        public int restart() {
            return 0;
        }
    }
}
