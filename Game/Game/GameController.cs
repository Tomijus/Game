using System;
using System.Collections.Generic;
using System.Text;

namespace Game.Game
{
    class GameController
    {
        public void StartGame()
        {
            //Hero hero = new Hero(15, 0, "SuperMario");
            //hero.PrintInfo();
            //hero.MoveRight();
            //hero.PrintInfo();
            //List<Enemy> enemyList = new List<Enemy>();
            GameScreen myGame = new GameScreen(30, 120);
            myGame.SetHero(new Hero(15, 0, "SuperMario"));
            for (int i = 0; i < 10; i++)
            {
                myGame.AddEnemy(new Enemy(i, 5 + i, (2 + i) * 10, "Enemy" + i));
            }
            myGame.Render();
            myGame.MoveHeroLeft();
            myGame.MoveAllEnemiesDown();
            Enemy oneEnemy = myGame.GetEnemyById(1);
            oneEnemy.MoveDown();
            myGame.Render();
        }
        
        
    }
}
