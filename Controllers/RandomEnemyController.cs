using System;


namespace LegendOfZelda
{
    class RandomEnemyController : IController
    {
        public ICommand[] Directions { get; set; }
        private Random random = new Random();
        

        public RandomEnemyController(IEnemy enemy)
        {
            Directions = new ICommand[] { 
                new EnemyMoveUpCommand(enemy),
                new EnemyMoveDownCommand(enemy),
                new EnemyMoveLeftCommand(enemy),
                new EnemyMoveRightCommand(enemy)
            };
        }

        public void Update()
        {
            Directions[random.Next(0, Directions.Length)].Execute();
        }
    }
}
