using System;

namespace RaceTrack.RaceTrack.Cars
{
    public class SportsCar : RaceCar
    {
        public SportsCar()
        {
            Name = "Sports Car";
            TopSpeed = 120;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} engine roars to life!");
        }

        public override void StopEngine()
        {
            Console.WriteLine($"The {Name} engine has stopped.");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} is having a hard time stopping!");
            base.Brake();
        }
    }
}
