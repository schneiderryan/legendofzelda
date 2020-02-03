using System;
using System.Collections.Generic;
using System.Text;

namespace Sprint0
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