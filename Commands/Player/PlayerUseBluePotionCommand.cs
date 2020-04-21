

namespace LegendOfZelda
{
    class PlayerUseBluePotionCommand : ICommand
    {
        IPlayer player;

        public PlayerUseBluePotionCommand(IPlayer player)
        {
            this.player = player;
        }
        public void Execute()
        {
            player.CurrentHearts = player.MaxHearts;
            player.Inventory.HasBluePotion = false;
        }
    }
}
