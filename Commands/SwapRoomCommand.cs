

namespace LegendOfZelda
{
    class SwapRoomCommand : ICommand
    {
        private LegendOfZelda game;
        private string swapDirection;
        

        public SwapRoomCommand(LegendOfZelda game, string direction)
        {
            this.game = game;
            this.swapDirection = direction;
        }
        
        public void Execute()
        {
            if (swapDirection.Equals("next"))
            {
                game.state = new ChangeRoomState("right", game);
            }
            else if (swapDirection.Equals("previous"))
            {
                game.state = new ChangeRoomState("left", game);
            }
            else if (swapDirection.Equals("up"))
            {
                game.state = new ChangeRoomState("up",game);
            }
            else if (swapDirection.Equals("down"))
            {
                game.state = new ChangeRoomState("down", game);
            }

            game.ProjectileManager.Clear();

        }
    }
}
