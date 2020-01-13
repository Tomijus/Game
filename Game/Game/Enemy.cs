using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Game
{
    class Enemy : Unit
    {
        private int Id;

        public Enemy(int id, int x, int y, string name) : base(x, y, name)
        {
            Id = id;
        }

        public int MoveDown()
        {
            return Y--;
        }
        public int GetId()
        {
            return Id;
        }
    }
}
