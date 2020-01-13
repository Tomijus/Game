using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Game
{
    class Hero : Unit
    {

        public Hero(int x, int y, string name) : base(x, y, name)
        {
        }

        public int MoveLeft()
        {
            return X--;
        }
        public int MoveRight()
        {
            return X++;
        }
    }
}
