using System;

namespace LegendOfZelda
{
    abstract class RandomMovingEnemy : Enemy
    {
        protected RandomEnemyController controller;

        private int currentStep;
        private int stepsToTake;
        private readonly int maxRandomSteps;
        private Random randomStep;

        public RandomMovingEnemy(int maxRandomSteps = 150)
        {
            this.maxRandomSteps = maxRandomSteps;
            controller = new RandomEnemyController(this);
            randomStep = new Random();
            currentStep = 0;
            stepsToTake = randomStep.Next(0, maxRandomSteps);
        }

        public override void Update()
        {
            currentStep++;
            if (currentStep > stepsToTake)
            {
                controller.Update();
                currentStep = 0;
                stepsToTake = this.randomStep.Next(0, maxRandomSteps);
            }
            base.Update();
        }
    }
}
