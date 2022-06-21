using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ExpressedEngine.ExpressedEngine;

namespace ExpressedEngine
{
    //Inherit from ExpressedEngine class which is in the folder with same name
    class DemoGame : ExpressedEngine.ExpressedEngine
    {
        //instantiate the base of our game engine
        public DemoGame() : base(new Vector2(615, 515), "Expressed Engine Demo") { }
    }
}
