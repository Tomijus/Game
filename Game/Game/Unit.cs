using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Game
{
    class Unit
    {
        protected int X;
        protected int Y;
        private string Name;

        public Unit(int x, int y, string name)
        {
            X = x;
            Y = y;
            Name = name;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Object '{Name}' is in position {X}:{Y}");
        }
    }
}
