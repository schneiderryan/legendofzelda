using System.Collections.Generic;


namespace LegendOfZelda
{
    class PlayerUseBombCommand : ICommand
    {
        private IPlayer player;
        private IProjectileManager projectiles;

        public PlayerUseBombCommand(IPlayer player, IProjectileManager projectiles)
        {
            this.player = player;
            this.projectiles = projectiles;
        }

        public void Execute()
        {
            if (player.Inventory.Bombs > 0)
            {
                IProjectile bomb = new PlacedBomb(projectiles);
                Util.CenterRelativeToEdge(player.Hitbox, player.Direction, bomb);
                projectiles.Add(bomb);
                player.Inventory.Bombs -= 1;
            }
        }
    }
}
