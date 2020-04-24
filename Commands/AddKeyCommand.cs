
namespace LegendOfZelda
{
    class AddKeyCommand : ICommand
    {
        private LegendOfZelda game;

        public AddKeyCommand(LegendOfZelda game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.Link.Inventory.Keys++;
        }

    }
}