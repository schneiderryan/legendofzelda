using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    class EnemyMoveLeftCommand : ICommand
    {
        private IEnemy enemy;

        public EnemyMoveLeftCommand(IEnemy enemy)
        {
            this.enemy = enemy;
        }

        public void Execute()
        {
            enemy.MoveLeft();
        }
    }
}