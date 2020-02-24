using Microsoft.Xna.Framework;

namespace LegendOfZelda
{
    class Boomerang : Item
    {
        public Boomerang()
        {
            sprite = ItemSpriteFactory.GetBoomerang();
            Hitbox = sprite.Box;
        }

        public override void Use(IPlayer player)
        {
            IProjectile proj = new BoomerangProjectile(player.direction,
                player.X, player.Y);
            player.UseProjectile(proj);
        }

       
    }
}
