using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace ExpressedEngine.ExpressedEngine
{
    class Canvas : Form
    {
        public Canvas()
        {
            //not enabled by default, but we need it in the game
            this.DoubleBuffered = true;
        }
    }
    public abstract class ExpressedEngine
    {
        private Vector2 ScreenSize = new Vector2(512, 512);
        private string Title = "New Game";
        private Canvas Window = null;
        private Thread GameLoopThread = null;

        public Color BackgroundColour = Color.Beige;

        public ExpressedEngine(Vector2 ScreenSize, string Title)
        {
            this.ScreenSize = ScreenSize;
            this.Title = Title;

            //Windows.Drawing doesn't automatically refresh the window
            Window = new Canvas();
            //we reference using "this", to be sure we reference our game engine
            //atributes and not the parameters of ExpressedEngine
            Window.Size = new Size((int)this.ScreenSize.X, (int)this.ScreenSize.Y);
            Window.Text = this.Title;
            Window.Paint += Renderer;

            GameLoopThread = new Thread(GameLoop);
            GameLoopThread.Start();

            Application.Run(Window);
        }

        void GameLoop()
        {
            OnLoad();
            while (GameLoopThread.IsAlive)
            {
                try
                {
                    //if we draw in the game
                    OnDraw();
                    //break windows, tell it to call this regardles of what you do
                    //telling windows to refresh something it doesn't want to refresh
                    Window.BeginInvoke((MethodInvoker)delegate { Window.Refresh(); });

                    //movement and physics
                    //call onupdate after the frame
                    OnUpdate();

                    //delay so the window doesn't freeze
                    Thread.Sleep(1);
                }
                catch
                {
                    Console.WriteLine("Game is loading...");
                }
            }
        }

        //new thread that tells windows to force call this every millisecond
        private void Renderer(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //this will be the color used to clear the screen, background color
            g.Clear(BackgroundColour);
        }

        public abstract void OnLoad();

        public abstract void OnUpdate();

        public abstract void OnDraw();
    }
}
