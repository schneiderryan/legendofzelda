

namespace LegendOfZelda
{
    class PlayerUseThrowingSwordCommand : ICommand
    {
        private IPlayer player;

        public PlayerUseThrowingSwordCommand(IPlayer player)
        {
            this.player = player;
        }

        public void Execute()
        {
            player.UseProjectile(new SwordProjectile(player.Direction, player.X, player.Y));
        }
    }
}
