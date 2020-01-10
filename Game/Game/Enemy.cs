using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Game
{
    class Enemy
    {
        private int id;
        private int x;
        private int y;
        private string name;

        public Enemy(int id, int x, int y, string name)
        {
            this.id = id;
            this.x = x;
            this.y = y;
            this.name = name;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Enemy '{name}'(ID:{id}) position: {x}:{y}");
        }

        public int MoveDown()
        {
            return y--;
        }
        public int GetId()
        {
            return id;
        }
    }
}
