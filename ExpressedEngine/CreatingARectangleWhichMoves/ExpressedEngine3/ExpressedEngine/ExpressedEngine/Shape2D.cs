using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpressedEngine.ExpressedEngine
{
    public class Shape2D
    {
        public Vector2 Position = null;
        public Vector2 Scale = null;
        public string Tag = "";

        public Shape2D(Vector2 Position, Vector2 Scale, string Tag)
        {
            //we want this shape 2D to register itself with the engine when we creat a game
            this.Position = Position;
            this.Scale = Scale;
            this.Tag = Tag;

            //call RegisterShape, whenever we create a new shape
            ExpressedEngine.RegisterShape(this);
        }

        public void DestroySelf()
        {
            ExpressedEngine.UnRegisterShape(this);
        }

    }
}
