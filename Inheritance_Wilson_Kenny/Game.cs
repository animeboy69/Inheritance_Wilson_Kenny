using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Wilson_Kenny
{
    abstract class Game
    {

        public string Esrb { get; set; }

        public string Title { get; set; }

        public Game(string esrbParam, string titleParm)
        {
            Esrb = esrbParam;
            Title = titleParm;

            

        }

        public void PlayGame()
        {
            Console.WriteLine($"{Title} is Starting!");
        }

        public abstract string Describe();


    }
}
