using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using ExpressedEngine.ExpressedEngine;
using System.Windows.Forms;

namespace ExpressedEngine
{
    //Inherit from ExpressedEngine class which is in the folder with same name
    class DemoGame : ExpressedEngine.ExpressedEngine
    {
        Sprite2D player;
        bool left;
        bool up;
        bool down;
        bool right;

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
                    {
                        new Sprite2D(new Vector2(i * 50, j * 50), new Vector2(50, 50), "Tiles/Blue tiles/tileBlue_02", "Ground");
                    }
                }
            }

            player = new Sprite2D(new Vector2(30,30), new Vector2(50, 60), "Players/Player Green/playerGreen_walk1", "Player");
        }

        public override void OnDraw()
        {
            
        }

        //method used to load our sprites, game objects, our UI, anything that needs to be rendered before the game starts

        float x = 0.1f;
        public override void OnUpdate()
        {
            if (up)
            {
                player.Position.Y -= 1f;
            }
            if (down)
            {
                player.Position.Y += 1f;
            }
            if (left)
            {
                player.Position.X -= 1f;
            }
            if (right)
            {
                player.Position.X += 1f;
            }
        }

        public override void GetKeyDown(KeyEventArgs e)
        {
            if(e.KeyCode == Keys.W) { up = true; }
            if (e.KeyCode == Keys.S) { down = true; }
            if (e.KeyCode == Keys.A) { left = true; }
            if (e.KeyCode == Keys.D) { right = true; }
        }

        public override void GetKeyUp(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W) { up = false; }
            if (e.KeyCode == Keys.S) { down = false; }
            if (e.KeyCode == Keys.A) { left = false; }
            if (e.KeyCode == Keys.D) { right = false; }
        }
    }
}
