using System.Collections.Generic;


namespace LegendOfZelda
{
    class ShootFireballCommand : ICommand
    {
        private IEnemy fire;
        private ICollection<IProjectile> projectiles;
        private string dir;

        public ShootFireballCommand(ICollection<IProjectile> projectiles, IEnemy fire, string dir)
        {
            this.projectiles = projectiles;
            this.fire = fire;
            this.dir = dir;
        }

        public void Execute()
        {         
            projectiles.Add(new FireballProjectile(dir, fire.X, fire.Y));
        }

    }
}