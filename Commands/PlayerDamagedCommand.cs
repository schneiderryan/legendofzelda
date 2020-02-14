namespace LegendOfZelda
{
    internal class PlayerDamagedCommand : ICommand
    {
        private IPlayer player;

        public PlayerDamagedCommand(IPlayer player)
        {
            this.player = player;
        }

        public void Execute()
        {
            player.TakeDamage();
        }
    }
}