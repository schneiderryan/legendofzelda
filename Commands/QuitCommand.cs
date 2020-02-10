
namespace LegendOfZelda
{
    public class QuitCommand : ICommand
    {
        private Game1 game1;

        public QuitCommand(Game1 game1)
        {
            this.game1 = game1;
        }

        public void Execute()
        {
            game1.Exit();
        }

    }
}
