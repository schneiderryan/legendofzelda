using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class EnemyMoveUpCommand : ICommand
    {
        private IEnemy enemy;

        public EnemyMoveUpCommand(IEnemy enemy)
        {
            this.enemy = enemy;
        }

        public void Execute()
        {
            enemy.MoveUp();
        }
    }
}