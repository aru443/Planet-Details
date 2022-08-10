using System;

namespace ConsoleApp1
{
    class Program
    {
        public class Planet
        {
            // properties
            public string Name;
            public double Surface_gasses;
            public double Number_of_Moons;
            public double Rings;

            // constructor of Planet
            public Planet(string name, double suface_gasses, double no_of_moons, double rings)
            {
                Name = name;
                Surface_Gasses = suface_gasses;
                Number_of_Moons = no_of_moons;
                Rings = rings;
            }

            // Output data about planet to console
            public void Display()
            {
                Console.WriteLine("Planet: Name = {0}, Surface_Gasses = {0}, Number_of_Moons = {0}, Rings = {0}", Name, Surface_gasses, Number_of_Moons, Rings);
            }
        }
        static void Main(string[] args)
        {
            // Make objects
            Planet earth = new Planet("Earth", O2, 1, No); ;
            Planet Mars = new Planet("Mars", CO2, 2, No);

            // Display data
            earth.Display();
            Mars.Display();
        }
    }
}