using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Wilson_Kenny
{
    class FPS : Game
    {

        public FPS(string esrbParam, string titleParm) : base(esrbParam, titleParm)
        {
            Title = titleParm;
            Esrb = esrbParam;
        }
       
        
        public override string Describe()
        {
            return $"{Title} is a fps game rated {Esrb}!";
        }
    }
}
