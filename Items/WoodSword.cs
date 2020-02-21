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
            IProjectile proj = new SwordProjectile(player.direction,
                player.xPos, player.yPos);
            player.UseProjectile(proj);
        }
    }
}
