
namespace LegendOfZelda
{
    public class QuitCommand : ICommand
    {
        private LegendOfZelda game1;

        public QuitCommand(LegendOfZelda game1)
        {
            this.game1 = game1;
        }

        public void Execute()
        {
            game1.Exit();
        }

    }
}