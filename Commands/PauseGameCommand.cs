

namespace LegendOfZelda
{
    class PauseGameCommand : ICommand
    {
        private LegendOfZelda game;
        private bool paused = false;
        

        public PauseGameCommand(LegendOfZelda game)
        {
            this.game = game;
            
        }
        
        public void Execute()
        {
            if (paused)
            {
                game.PlayGame();
                paused = false;
            }
            else
            {
                game.PauseGame();
                paused = true;
            }
        }
    }
}
