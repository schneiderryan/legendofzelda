using System.Collections.Generic;


namespace LegendOfZelda
{
    class ShootFireballCommand : ICommand
    {
        private IEnemy fire;
        private ICollection<IProjectile> projectileManager;
        private string dir;

        public ShootFireballCommand(ICollection<IProjectile> projectileManager, IEnemy fire, string dir)
        {
            this.projectileManager = projectileManager;
            this.fire = fire;
            this.dir = dir;
        }

        public void Execute()
        {
            projectileManager.Add(new FireballProjectile(dir, fire.X, fire.Y));
        }

    }
}