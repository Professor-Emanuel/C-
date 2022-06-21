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
        //Sprite2D player;

        string[,] Map =
        {
            {".", ".", ".", ".", ".", ".", "." },
            {".", ".", ".", ".", ".", ".", "." },
            {".", ".", ".", ".", ".", ".", "." },
            {".", ".", ".", ".", ".", "g", "." },
            {".", ".", "g", ".", ".", "g", "." },
            {"g", "g", "g", "g", "g", "g", "g" },
            {".", ".", ".", ".", ".", ".", "." }
        };

        //instantiate the base of our game engine
        public DemoGame() : base(new Vector2(615, 515), "Expressed Engine Demo") { }

        public override void OnLoad()
        {
            //Console.WriteLine("OnLoad works!");
            BackgroundColour = Color.Black;
            CameraPosition.X = 100;

            //player = new Sprite2D(new Vector2(10, 10), new Vector2(36, 45), "Players/Player Grey/playerGrey_walk1", "Player");
            for(int i=0; i<Map.GetLength(0); i++)
            {
                for(int j=0; j<Map.GetLength(1); j++)
                {
                    if(Map[j, i] == "g")
                    new Sprite2D(new Vector2(i * 50, j * 50), new Vector2(50, 50), "Tiles/Blue tiles/tileBlue_02", "Ground");
                }
            }
        }

        public override void OnDraw()
        {
            
        }

        //method used to load our sprites, game objects, our UI, anything that needs to be rendered before the game starts

        float x = 0.1f;
        public override void OnUpdate()
        {
            CameraPosition.X += 0.1f;
            CameraPosition.Y += 0.1f;
            CameraAngle += .2f;
            //player.Position.X += x;
            //player.Scale.X += x;
        }
    }
}
