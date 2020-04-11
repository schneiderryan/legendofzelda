using Microsoft.Xna.Framework;
using System.Collections.Generic;


namespace LegendOfZelda
{
    class ShootFireballCommand : ICommand
    {
        private IEnemy fire;
        private ICollection<IProjectile> projectileManager;
        private IPlayer player;

        public ShootFireballCommand(ICollection<IProjectile> projectileManager,
                IEnemy fire, IPlayer player)
        {
            this.projectileManager = projectileManager;
            this.fire = fire;
            this.player = player;
        }

        public void Execute()
        {
            Vector2 v = Util.VelocityVectorToTarget(player.Center, fire.Center, 3.5f);
            projectileManager.Add(new FireballProjectile(fire.Center.X,
                    fire.Center.Y, v.X, v.Y));
        }

    }
}