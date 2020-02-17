namespace LegendOfZelda
{
    public class BreatheFireballCommand : ICommand
    {
        private LegendOfZelda game;

        public BreatheFireballCommand(LegendOfZelda game)
        {
            this.game = game;
        }

        public void Execute()
        {
            if (game.enemies[game.enemyIndex] is Aquamentus)
            {
                Aquamentus aq = game.enemies[game.enemyIndex] as Aquamentus;
                aq.BreatheFireball(aq.xPos, aq.yPos);
            }
        }
    }
}