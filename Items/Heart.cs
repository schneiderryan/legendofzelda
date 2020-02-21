using Microsoft.Xna.Framework;

namespace LegendOfZelda
{
    class Heart : Item
    {
        public Heart()
        {
            sprite = ItemSpriteFactory.GetHeart();
            Hitbox = sprite.Box;
        }

        public override void Update()
        {
            base.Update();
        }

        public override void Use(IPlayer player)
        {
            if ((player.maxHearts - player.currentHearts) < 1)
            {
                player.currentHearts = player.maxHearts;
            } else
            {
                player.currentHearts++;
            }
        }
    }
}
