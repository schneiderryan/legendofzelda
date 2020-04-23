using Microsoft.Xna.Framework;
using System.Collections.Generic;


namespace LegendOfZelda
{
    class ShootFireballCommand : ICommand
    {
        private IEnemy fire;
        private ICollection<IProjectile> projectileManager;
        private ICollection<IPlayer> players;

        public ShootFireballCommand(ICollection<IProjectile> projectileManager,
                IEnemy fire, ICollection<IPlayer> players)
        {
            this.projectileManager = projectileManager;
            this.fire = fire;
            this.players = players;
        }

        public void Execute()
        {
            IPlayer player = Util.FindClosestPlayer(fire.Center, players);
            Vector2 v = Util.VelocityVectorToTarget(player.Center, fire.Center, 3.5f);
            projectileManager.Add(new FireballProjectile(fire.Center.X,
                    fire.Center.Y, v.X, v.Y));
        }

    }
}