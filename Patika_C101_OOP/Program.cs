using System;

namespace Patika_C101_OOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            SeedPlants  seedPlants = new SeedPlants();

            Console.WriteLine("*******Birds********");
            Birds birds = new Birds();
            birds.BirdMovement();

        }

    }
}