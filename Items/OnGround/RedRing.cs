using System.Collections.Generic;


namespace LegendOfZelda
{
    class RedRing : Item
    {
        private IDictionary<int, IPlayer> players;

        public RedRing(IDictionary<int, IPlayer> players)
        {
            sprite = ItemSpriteFactory.GetRedRing();
            Hitbox = sprite.Box;
            this.players = players;
        }

        public override void Collect(IPlayer player)
        {
            if (!player.Color.Equals("red"))
            {
                if (player is DamagedLink)
                {
                    DamagedLink link = player as DamagedLink;
                    link.InnerLink = new RedLink(link.InnerLink);
                }
                else
                {
                    players[player.ID] = new RedLink(player);
                }
            }
        }
    }
}
