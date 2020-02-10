using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;

namespace LegendOfZelda
{
    public class RandomEnemyController : IController
    {
        private ICommand[] directions;
        private Random random = new Random();
        

        public RandomEnemyController(IEnemy enemy)
        {
            this.directions = new ICommand[] { 
                new EnemyMoveUpCommand(enemy),
                new EnemyMoveDownCommand(enemy),
                new EnemyMoveLeftCommand(enemy),
                new EnemyMoveRightCommand(enemy)
                    };
        }

        public void Update()
        {
            directions[random.Next(0, 4)].Execute();
          
        }
    }
}
