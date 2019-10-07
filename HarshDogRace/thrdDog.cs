using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarshDogRace
{
    public class thrdDog
    {
        Random obj = new Random();
        public int go()
        {
            return obj.Next(1, 10);
        }
    }
}
