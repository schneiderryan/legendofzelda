namespace LegendOfZelda
{
    internal class ResetCommand : ICommand
    {
        private LegendOfZelda game;

        public ResetCommand(LegendOfZelda game)
        {
            this.game = game;
            
        }

        public void Execute()
        {
            game.currentIndex = 0;
            game.currentItem = game.items[game.currentIndex];
            game.enemy = new Gel();
            game.link = new GreenLink(game);
        }
    }
}