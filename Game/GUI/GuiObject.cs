using System;
using System.Collections.Generic;
using System.Text;

namespace Game.GUI
{
    abstract class GuiObject
    {
        protected int X;
        protected int Y;
        protected int Height;
        protected int Width;

        public GuiObject(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public abstract void Render();
    }
}
