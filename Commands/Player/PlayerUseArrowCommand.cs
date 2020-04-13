

namespace LegendOfZelda
{
    class PlayerUseArrowCommand : ICommand
    {
        private IPlayer player;

        public PlayerUseArrowCommand(IPlayer player)
        {
            this.player = player;
        }

        public void Execute()
        {
            if (player.Inventory.HasBow && player.Inventory.HasArrow
                    && player.Inventory.Rupees > 0)
            {
                IProjectile proj = new GreenArrowProjectile(player.Direction,
                        player.Center.X, player.Center.Y);
                proj.OwningTeam = Team.Link;
                player.UseProjectile(proj);
                player.Inventory.Rupees -= 1;
            }
        }
    }
}
