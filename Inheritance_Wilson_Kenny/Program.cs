using System;

namespace Inheritance_Wilson_Kenny
{
    class Program
    {
        static void Main(string[] args)
        {
            FPS myFPS = new FPS("E", "ZombCube");

            Console.WriteLine(myFPS.Describe());
            myFPS.PlayGame();

            FPS Codbo2 = new FPS("M", "Codbo2");
            Console.WriteLine(Codbo2.Describe());
            Codbo2.PlayGame();


        }
    }



}
