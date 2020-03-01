using System.Collections.Generic;


namespace LegendOfZelda
{
    class BreatheFireballCommand : ICommand
    {
        private IEnemy aquamentus;
        private IList<IProjectile> projectiles;

        public BreatheFireballCommand(IList<IProjectile> projectiles, IEnemy aquamentus)
        {
            this.projectiles = projectiles;
            this.aquamentus = aquamentus;
        }

        public void Execute()
        {
            projectiles.Add(new FireballProjectile("leftup", aquamentus.X, aquamentus.Y+10));
            projectiles.Add(new FireballProjectile("left", aquamentus.X, aquamentus.Y));
            projectiles.Add(new FireballProjectile("leftdown", aquamentus.X, aquamentus.Y-10));
        }

    }
}