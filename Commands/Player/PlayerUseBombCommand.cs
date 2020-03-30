

namespace LegendOfZelda
{
    class PlayerUseBombCommand : ICommand
    {
        private IPlayer player;

        public PlayerUseBombCommand(IPlayer player)
        {
            this.player = player;
        }

        public void Execute()
        {
            if (player.Inventory.Bombs > 0)
            {
                IProjectile proj = new BombPlaced(player.Direction, player);
                player.UseProjectile(proj);
                player.Inventory.Bombs -= 1;
            }
        }
    }
}
