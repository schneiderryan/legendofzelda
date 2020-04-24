

namespace LegendOfZelda
{
    class SwapRoomCommand : ICommand
    {
        private LegendOfZelda game;
        private string swapDirection;
        private IPlayer player;

        public SwapRoomCommand(LegendOfZelda game, IPlayer player, string direction)
        {
            this.game = game;
            this.swapDirection = direction;
            this.player = player;
        }
        
        public void Execute()
        {
            if (swapDirection.Equals("next"))
            {
                game.state = new ChangeRoomState("right", player, game);
            }
            else if (swapDirection.Equals("previous"))
            {
                game.state = new ChangeRoomState("left", player, game);
            }
            else if (swapDirection.Equals("up"))
            {
                game.state = new ChangeRoomState("up", player, game);
            }
            else if (swapDirection.Equals("down"))
            {
                game.state = new ChangeRoomState("down", player, game);
            }
        }
    }
}
