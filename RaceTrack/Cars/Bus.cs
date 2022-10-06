using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    internal class Bus : RaceCar
    {
        public Bus()
        {
            Name = "Bus";
            TopSpeed = 40;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} goes on a steady pace to pick up the students for school. Definitly not meant for the track");
        }

        public object Brake()
        {
            Console.WriteLine($"The {Name} ends in position {Position}!");
            return Name;
            return Position;
        }
    }
    
    
}
