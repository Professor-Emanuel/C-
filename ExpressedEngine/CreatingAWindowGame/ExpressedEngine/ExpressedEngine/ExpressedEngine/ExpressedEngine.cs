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

            Application.Run(Window);


        }
    }
}
