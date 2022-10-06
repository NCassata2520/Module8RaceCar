using RaceTrack.RaceTrack.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Drivers
{
    public class BusDriver : Driver
    {
        public BusDriver(RaceCar car) : base(car)
        {
            Name = "Bob";
            SkillLevel = 4;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }

       
    }
}
