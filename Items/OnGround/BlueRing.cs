using System.Collections.Generic;


namespace LegendOfZelda
{
    class BlueRing : Item
    {
        private IDictionary<int, IPlayer> players;

        public BlueRing(IDictionary<int, IPlayer> players)
        {
            sprite = ItemSpriteFactory.GetBlueRing();
            Hitbox = sprite.Box;
            this.players = players;
        }

        public override void Collect(IPlayer player)
        {
            if (!player.Color.Equals("blue"))
            {
                if (player is DamagedLink)
                {
                    DamagedLink link = player as DamagedLink;
                    link.InnerLink = new BlueLink(link.InnerLink);
                }
                else
                {
                    players[player.ID] = new BlueLink(player);
                }
            }
        }
    }
}
