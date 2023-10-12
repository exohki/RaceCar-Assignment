using System;
using RaceTrack.RaceTrack.Cars;

namespace RaceTrack.RaceTrack.Drivers
{
    public class SpeedyDriver : Driver
    {
        public SpeedyDriver(RaceCar car) : base(car)
        {
            Name = "Speedy Driver";
            SkillLevel = 9;
        }

        public override void Drive()
        {
            Car.Accelerate(SkillLevel);
        }
    }
}
