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
        Sprite2D player;

        //instantiate the base of our game engine
        public DemoGame() : base(new Vector2(615, 515), "Expressed Engine Demo") { }

        public override void OnLoad()
        {
            //Console.WriteLine("OnLoad works!");
            BackgroundColour = Color.Black;

            player = new Sprite2D(new Vector2(10, 10), new Vector2(20, 20), "Players/Player Grey/playerGrey_walk1", "Player");
        }

        public override void OnDraw()
        {
            
        }

        //method used to load our sprites, game objects, our UI, anything that needs to be rendered before the game starts

        int time = 0;
        public override void OnUpdate()
        {
            if (time > 400)
            {
                if (player != null)
                {
                    player.DestroySelf();
                    player = null;
                }
            }
            time++;
            //Console.WriteLine($"Frame Count: {frame}");
            //frame++;
        }
    }
}
