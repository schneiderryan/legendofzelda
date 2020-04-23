using System.Collections.Generic;


namespace LegendOfZelda
{
    class Clock : Item
    {
        private IDictionary<int, IPlayer> players;

        public Clock(IDictionary<int, IPlayer> players)
        {
            sprite = ItemSpriteFactory.GetClock();
            Hitbox = sprite.Box;
            this.players = players;
        }

        public override void Collect(IPlayer player)
        {
            player.Inventory.HasClock = true;
            players[player.ID] = new DamagedLink(player);
        }
    }
}
