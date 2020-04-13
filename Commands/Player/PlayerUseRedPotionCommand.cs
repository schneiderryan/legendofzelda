

namespace LegendOfZelda
{
    class PlayerUseRedPotionCommand : ICommand
    {
        IPlayer player;

        public PlayerUseRedPotionCommand(IPlayer player)
        {
            this.player = player;
        }
        public void Execute()
        {
            player.CurrentHearts = player.MaxHearts;
            player.Inventory.HasRedPotion = false;
            player.Inventory.HasBluePotion = true;
        }
    }
}
