using System.Collections.Generic;


namespace LegendOfZelda
{
    class BreatheFireballCommand : ICommand
    {
        private IEnemy aquamentus;
        private ICollection<IProjectile> projectiles;

        public BreatheFireballCommand(ICollection<IProjectile> projectiles, IEnemy aquamentus)
        {
            this.projectiles = projectiles;
            this.aquamentus = aquamentus;
        }

        public void Execute()
        {
            projectiles.Add(new FireballProjectile("leftup", aquamentus));
            projectiles.Add(new FireballProjectile("left", aquamentus));
            projectiles.Add(new FireballProjectile("leftdown", aquamentus));
        }

    }
}