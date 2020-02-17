using System;
using System.Collections.Generic;
using System.Text;

namespace LegendOfZelda
{
    public class EnemyMoveRightCommand : ICommand
    {
        private IEnemy enemy;

        public EnemyMoveRightCommand(IEnemy enemy)
        {
            this.enemy = enemy;
        }

        public void Execute()
        {
            enemy.MoveRight();
        }
    }
}