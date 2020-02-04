using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint0
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