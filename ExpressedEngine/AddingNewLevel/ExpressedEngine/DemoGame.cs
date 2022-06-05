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
        //Sprite2D player2;
        bool left;
        bool up;
        bool down;
        bool right;

        Vector2 lastPos = Vector2.Zero();

        string[,] Map =
        {
            {"g", "g", "g", "g", "g", "g", "g","g", "g", "g", "g", "g", "g", "g","g"},
            {"g", ".", ".", ".", ".", ".", "c","c", "c", "c", "c", "g", ".", "g","g"},
            {"g", "c", "c", "c", "g", ".", "g",".", ".", "g", "c", ".", ".", "g","g"},
            {"g", "c", "g", "g", "g", ".", "g","g", ".", "g", "c", "g", ".", "g","g"},
            {"g", "c", "g", ".", "g", ".", ".","g", "g", ".", "c", "g", ".", "g","g"},
            {"g", "c", "c", ".", "c", "c", ".",".", ".", ".", "c", "g", ".", "g","g"},
            {"g", "g", "c", "g", "g", "g", ".","g", "g", "g", "g", "g", ".", "g","g"},
            {"g", "g", "c", "g", "g", "g", ".","g", "g", "g", "g", "g", ".", "g","g"},
            {"g", "g", "p", "g", "g", "g", ".","g", "g", "g", "g", "g", ".", "g","g"},
            {"g", "c", "c", "c", "c", "c", ".","c", "g", "g", "g", ".", ".", "g","g"},
            {"g", "g", "c", "g", "g", "g", "g","c", "c", "c", "c", ".", "g", "g","g"},
            {"g", "g", "g", "g", "g", "g", "g","g", "g", "g", "g", "g", "g", "g","g"}
        };

        //instantiate the base of our game engine
        public DemoGame() : base(new Vector2(615, 515), "Expressed Engine Demo") { }

        public override void OnLoad()
        {
            //Console.WriteLine("OnLoad works!");
            BackgroundColour = Color.Black;
            CameraZoom = new Vector2(.75f, .75f);
            //start by creat one ground sprite and position at (1000, 1000), so we do not see it; //same for coins
            //Sprite2D groundRef = new Sprite2D(new Vector2(1000, 1000), new Vector2(50, 50), "Tiles/Blue tiles/tileBlue_03", "Ground");
            //Sprite2D coinRef = new Sprite2D(new Vector2(1000, 1000), new Vector2(25, 25), "Items/yellowCrystal", "Coin");

            Sprite2D groundRef = new Sprite2D("Tiles/Blue tiles/tileBlue_03");
            Sprite2D coinRef = new Sprite2D("Items/yellowCrystal");

            CameraPosition.X = 0;

            //player = new Sprite2D(new Vector2(10, 10), new Vector2(36, 45), "Players/Player Grey/playerGrey_walk1", "Player");
            for(int i=0; i<Map.GetLength(0); i++)
            {
                for(int j=0; j<Map.GetLength(1); j++)
                {
                    if(Map[j, i] == "g")
                    {
                        new Sprite2D(new Vector2(i * 50, j * 50), new Vector2(50, 50), groundRef, "Ground");
                    }

                    if (Map[j, i] == "c")
                    {
                        new Sprite2D(new Vector2(i * 50 + 15, j * 50 +15), new Vector2(25, 25), coinRef, "Coin");
                    }

                    if (Map[j, i] == "p")
                    {
                        new Sprite2D(new Vector2(i * 50 + 15, j * 50), new Vector2(25, 25),"Players/Player Green/playerGreen_walk1", "Player");
                    }
                }
            }

            //player = new Sprite2D(new Vector2(100,100), new Vector2(30, 40), "Players/Player Green/playerGreen_walk1", "Player");
            //player2 = new Sprite2D(new Vector2(100, 30), new Vector2(50, 60), "Players/Player Green/playerGreen_walk1", "Player2");
            //player.IsColliding(player, player2);
        }

        public override void OnDraw()
        {
            
        }

        //method used to load our sprites, game objects, our UI, anything that needs to be rendered before the game starts

        float x = 0.1f;
        int times = 0;
        public override void OnUpdate()
        {
            if(player == null)
            {
                return;
            }
            times++;
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

            Sprite2D coin = player.IsColliding("Coin");
            if(player.IsColliding("Coin") != null)
            {
                coin.DestroySelf();
            }
            if(player.IsColliding("Ground") != null)
            {
                //Log.Info($"Colliding!!! {times}");
                //times++;
                //player.Position = Vector2.Zero();
                player.Position.X = lastPos.X;
                player.Position.Y = lastPos.Y;
            }
            else
            {
                lastPos.X = player.Position.X;
                lastPos.Y = player.Position.Y;
                //lastPos = player.Position;
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
