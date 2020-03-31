

namespace LegendOfZelda
{
    class HeldBomb : HeldItem
    {
        public HeldBomb()
        {
            sprite = ItemSpriteFactory.GetBomb();
        }

        public override void Use(IPlayer player)
        {
            if (player.Inventory.Bombs > 0)
            {
                //place bomb the direction that the player is facing and let it detonate
                IProjectile proj = new BombPlaced(player.Direction, player, 0);
                player.UseProjectile(proj);
                player.Inventory.Bombs -= 1;
            }
        }
    }
}
