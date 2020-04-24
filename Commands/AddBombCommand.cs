
namespace LegendOfZelda
{
    class AddBombCommand : ICommand
    {
        private LegendOfZelda game;

        public AddBombCommand(LegendOfZelda game)
        {
            this.game = game;
        }

        public void Execute()
        {
            game.Link.Inventory.Bombs++;
        }

    }
}