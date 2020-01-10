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
        private List<Enemy> enemyList = new List<Enemy>();

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
            hero.MoveRight();
        }
        public void MoveHeroLeft()
        {
            hero.MoveLeft();
        }
        public void AddEnemy(Enemy enemy)
        {
            enemyList.Add(enemy);
        }
        public void MoveAllEnemiesDown()
        {
            foreach (Enemy item in enemyList)
            {
                item.MoveDown();
            }
        }
        public Enemy GetEnemyById(int id)
        {
            foreach (Enemy enemy in enemyList)
            {
                if (enemy.GetId() == id)
                {
                    return enemy;
                }
            }
            return null;
        }
        public void Render()
        {
            hero.PrintInfo();
            foreach (Enemy enemy in enemyList)
            {
                enemy.PrintInfo();
            }
        }
    }
}
