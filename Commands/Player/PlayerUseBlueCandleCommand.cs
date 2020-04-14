using System.Collections.Generic;


namespace LegendOfZelda
{
    class PlayerUseBlueCandleCommand : ICommand
    {
        private IPlayer player;
        private IProjectileManager projectiles;

        public PlayerUseBlueCandleCommand(IPlayer player, IProjectileManager projectiles)
        {
            this.player = player;
            this.projectiles = projectiles;
        }

        public void Execute()
        {
            if (player.Inventory.HasBlueCandle)
            {
                IProjectile blueCandle = new BlueCandleFlame();
                Util.CenterRelativeToEdge(player.Hitbox, player.Direction, blueCandle);
                projectiles.Add(blueCandle);
            }
        }
    }
}
