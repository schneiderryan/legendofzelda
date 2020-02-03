
namespace Sprint0
{
    public class QuitCommand : IPlayerCommand
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
