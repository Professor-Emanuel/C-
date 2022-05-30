using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using ExpressedEngine.ExpressedEngine;

namespace ExpressedEngine
{
    //Inherit from ExpressedEngine class which is in the folder with same name
    class DemoGame : ExpressedEngine.ExpressedEngine
    {
        Shape2D player;

        //instantiate the base of our game engine
        public DemoGame() : base(new Vector2(615, 515), "Expressed Engine Demo") { }

        public override void OnLoad()
        {
            //Console.WriteLine("OnLoad works!");
            BackgroundColour = Color.Black;

            player = new Shape2D(new Vector2(10, 10), new Vector2(10, 10), "test");
        }

        public override void OnDraw()
        {
            
        }

        //method used to load our sprites, game objects, our UI, anything that needs to be rendered before the game starts

        int frame = 0;
        float x = 0.1f;
        public override void OnUpdate()
        {
            Console.WriteLine($"Frame Count: {frame}");
            player.Position.X += x;
            player.Scale.X += x;
            frame++;
        }
    }
}
