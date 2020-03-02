﻿
namespace LegendOfZelda
{
    class WoodSword : Item
    {
        public WoodSword()
        {
            sprite = ItemSpriteFactory.GetWoodSword();
            Hitbox = sprite.Box;
        }

        public override void Use(IPlayer player)
        {
            IProjectile proj = new SwordProjectile(player.Direction, player.X, player.Y);
            player.UseProjectile(proj);
        }
    }
}
