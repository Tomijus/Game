using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Game
{
    class GameScreen
    {
        private int width;
        private int height;
        private Hero hero;

        public GameScreen(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public void SetHero(Hero hero)
        {
            this.hero = hero;
        }
        public void MoveHeroRight()
        {

        }
        public void MoveHeroLeft()
        {

        }
    }
}
