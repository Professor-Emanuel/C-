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

        public static List<Shape2D> AllShapes = new List<Shape2D>();
        public static List<Sprite2D> AllSprites = new List<Sprite2D>();

        public Color BackgroundColour = Color.Beige;

        public Vector2 CameraZoom = new Vector2(1, 1);
        public Vector2 CameraPosition = Vector2.Zero();
        public float CameraAngle = 0f;

        public ExpressedEngine(Vector2 ScreenSize, string Title)
        {
            Log.Info("Game is starting...");
            this.ScreenSize = ScreenSize;
            this.Title = Title;

            //Windows.Drawing doesn't automatically refresh the window
            Window = new Canvas();
            //we reference using "this", to be sure we reference our game engine
            //atributes and not the parameters of ExpressedEngine
            Window.Size = new Size((int)this.ScreenSize.X, (int)this.ScreenSize.Y);
            Window.Text = this.Title;
            Window.Paint += Renderer;
            Window.KeyDown += Window_KeyDown;
            Window.KeyUp += Window_KeyUp;

            Window.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            //Window.FormClosing += Window_FormClosing();

            GameLoopThread = new Thread(GameLoop);
            GameLoopThread.Start();

            Application.Run(Window);
        }
        /*
        private FormClosingEventHandler Window_FormClosing()
        {
            GameLoopThread.Abort();
        }
        */
        //private void Window_FormClosing(object sender, FormClosingEventArgs e)
        //{
         //   GameLoopThread.Abort();
        //}

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            GetKeyDown(e);
        }

        private void Window_KeyUp(object sender, KeyEventArgs e)
        {
            GetKeyUp(e);
        }

        public static void RegisterShape(Shape2D shape)
        {
            AllShapes.Add(shape);
        }
        public static void UnRegisterShape(Shape2D shape)
        {
            AllShapes.Remove(shape);
        }


        public static void RegisterSprites(Sprite2D sprite)
        {
            AllSprites.Add(sprite);
        }

        public static void UnRegisterSprites(Sprite2D sprite)
        {
            AllSprites.Remove(sprite);
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
                    Thread.Sleep(3);
                }
                catch
                {
                    Log.Error("Game  has not been found...");
                }
            }
        }

        //new thread that tells windows to force call this every millisecond
        private void Renderer(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //this will be the color used to clear the screen, background color
            g.Clear(BackgroundColour);
            g.TranslateTransform(CameraPosition.X, CameraPosition.Y);
            g.RotateTransform(CameraAngle);
            g.ScaleTransform(CameraZoom.X, CameraZoom.Y);

            try
            {
            foreach (Shape2D shape in AllShapes)
            {
                g.FillRectangle(new SolidBrush(Color.Red), shape.Position.X, shape.Position.Y, shape.Scale.X, shape.Scale.Y);
            }
            foreach (Sprite2D sprite in AllSprites)
            {
                    if (!sprite.IsReference)
                    {
                        g.DrawImage(sprite.Sprite, sprite.Position.X, sprite.Position.Y, sprite.Scale.X, sprite.Scale.Y);
                    }
                
            }
            }
            catch
            {

            }

            
        }

        public abstract void OnLoad();

        public abstract void OnUpdate();

        public abstract void OnDraw();

        public abstract void GetKeyDown(KeyEventArgs e);
        public abstract void GetKeyUp(KeyEventArgs e);
    }
}
