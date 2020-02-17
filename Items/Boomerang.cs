using Microsoft.Xna.Framework;

namespace LegendOfZelda
{
    public class Boomerang : Item
    {
        public Boomerang()
        {
            sprite = ItemSpriteFactory.GetBoomerang();
        }

        public override void Use(IPlayer player)
        {
            IProjectile proj = new BoomerangProjectile(player.direction,
                player.xPos, player.yPos);
            player.UseProjectile(proj);
        }
    }
}
