using Game.Game;
using System;
using System.Collections.Generic;

namespace Game
{
    class Program
    {
        static void Main()
        {
            Hero hero = new Hero(15, 0, "SuperMario");
            hero.PrintInfo();
            hero.MoveRight();
            hero.PrintInfo();
            List<Enemy> enemyList = new List<Enemy>();
            for (int i = 0; i < 10; i++)
            {
                enemyList.Add(new Enemy(i, 2 + i, i * 10, "BadGuy" + i));
            }
            foreach (Enemy item in enemyList)
            {
                item.PrintInfo();
            }
            GameScreen myGame = new GameScreen(30, 120);
            myGame.SetHero(new Hero(15, 0, "SuperMario"));
        }
    }
}
