
namespace LegendOfZelda
{
    public class ResetCommand : ICommand
    {
        private LegendOfZelda game1;

        public ResetCommand(LegendOfZelda game1)
        {
            this.game1 = game1;
            
        }

        public void Execute()
        {
            game1.list[0] = new Gel();
            game1.list[1] = new Goriya();
            game1.list[2] = new Keese();
            game1.list[3] = new Stalfo();
            game1.list[4] = new Trap();
            game1.list[5] = new LFWallmaster();
            game1.list[6] = new RFWallmaster();
            game1.list[7] = new Aquamentus();
            game1.index = 0;

        }

    }
}