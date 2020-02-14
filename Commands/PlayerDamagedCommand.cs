namespace LegendOfZelda
{
    internal class PlayerDamagedCommand : ICommand
    {
        private LegendOfZelda game;

        public PlayerDamagedCommand(LegendOfZelda game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.link.TakeDamage();
        }
    }
}