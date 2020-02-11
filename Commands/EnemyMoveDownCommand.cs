using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class EnemyMoveDownCommand : ICommand
    {
        private IEnemy enemy;

        public EnemyMoveDownCommand(IEnemy enemy)
        {
            this.enemy = enemy;
        }

        public void Execute()
        {
            enemy.MoveDown();
        }
    }
}