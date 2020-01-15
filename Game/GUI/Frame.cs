using System;
using System.Collections.Generic;
using System.Text;

namespace Game.GUI
{
    class Frame : GuiObject
    {
        protected char RenderChar;

        public Frame(int x, int y, int width, int height, char renderChar) : base(x, y, width, height)
        {
            RenderChar = renderChar;
        }
        public override void Render()
        {

        }
    }
}
