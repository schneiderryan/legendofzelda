using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace LegendOfZelda
{
    static class DespawnEffectSpriteFactory
    {
        private static Texture2D link = Textures.GetLinkSheet();
        private static Texture2D weapons = Textures.GetWeaponSheet();
        private const int DELAY = 3;

        public static ISprite SwordSpriteUpperRight()
        {
            return new AnimatedSprite(link, new Rectangle(158, 282, 8, 10), 3)
                { AnimationDelay = DELAY };
        }

        public static ISprite SwordSpriteUpperLeft()
        {
            return new AnimatedSprite(link, new Rectangle(150, 282, 8, 10), 3)
                { AnimationDelay = DELAY };
        }

        public static ISprite SwordSpriteLowerRight()
        {
            return new AnimatedSprite(link, new Rectangle(158, 293, 8, 10), 3)
                { AnimationDelay = DELAY };
        }

        public static ISprite SwordSpriteLowerLeft()
        {
            return new AnimatedSprite(link, new Rectangle(150, 293, 8, 10), 3)
                { AnimationDelay = DELAY };
        }

        public static ISprite GenericProjectileDespawn()
        {
            return new Sprite(weapons, new Rectangle(53, 189, 8, 8));
        }

        public static ISprite GetExplodingBomb()
        {
            return new AnimateOnceSprite(weapons,
                new Rectangle(138, 203, 16, 16), 4)
            {
                AnimationDelay = 10,
                Scale = 2
            };
        }

        public static ISprite GetBlueCandleFlame()
        {
            return new AnimatedSprite(weapons, new Rectangle(262, 237, 16, 32), 2, true)
            {
                AnimationDelay = 10,
                Scale = 2
            };
        }

    }
}
