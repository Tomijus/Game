using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Game
{
    class Hero
    {
        private int x;
        private int y;
        private string name;

        public Hero(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Hero '{name}' position {x}:{y}");
        }

        public int MoveLeft()
        {
            return x--;
        }
        public int MoveRight()
        {
            return x++;
        }
    }
}
